using System.Windows.Forms;
using GestionMenusRecettes.Data;
using GestionMenusRecettes.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionMenusRecettes.Ui;

/// <summary>Gérer les ingrédients (chef cuisinier) : ajouter, modifier, supprimer, consulter, consommer, réapprovisionner.</summary>
public partial class IngredientsForm : Form
{
    private sealed record ChoixUnite(Unite Valeur, string Texte);

    private List<Choix> _fournisseurs = new();

    public IngredientsForm()
    {
        InitializeComponent();
        Theme.Grille(dgvIngredients);

        cmbUnite.DisplayMember = nameof(ChoixUnite.Texte);
        cmbUnite.DataSource = Enum.GetValues<Unite>().Select(u => new ChoixUnite(u, u.Symbole())).ToList();
        cmbFournisseur.DisplayMember = nameof(Choix.Texte);
    }

    private void IngredientsForm_Load(object? sender, EventArgs e)
    {
        if (DesignMode) return;
        Rafraichir();
    }

    /// <summary>Consulter : relit les ingrédients et la liste des fournisseurs.</summary>
    private void Rafraichir(int? selectionId = null)
    {
        using var db = new RestaurantDbContext();

        _fournisseurs = db.Fournisseurs.OrderBy(f => f.Nom).ToList().Select(f => new Choix(f.Id, f.Nom)).ToList();
        cmbFournisseur.DataSource = _fournisseurs;

        dgvIngredients.DataSource = db.Ingredients
            .Include(i => i.Fournisseur)
            .OrderBy(i => i.Id)
            .ToList()
            .Select(i => new
            {
                i.Id,
                i.Nom,
                Unite = i.Unite.Symbole(),
                Prix_DT = i.PrixUnitaire,
                i.Stock,
                Fournisseur = i.Fournisseur.Nom,
                i.FournisseurId
            })
            .ToList();

        Vider();
        if (selectionId is int id) Theme.Selectionner(dgvIngredients, id, "Nom");
    }

    private void dgvIngredients_SelectionChanged(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvIngredients) is null) return;
        var l = dgvIngredients.CurrentRow!;

        txtNom.Text = l.Cells["Nom"].Value?.ToString() ?? "";
        nudPrix.Value = ConvertirDecimal(l.Cells["Prix_DT"].Value);
        nudStock.Value = ConvertirDecimal(l.Cells["Stock"].Value);

        int fid = l.Cells["FournisseurId"].Value is int v ? v : 0;
        int index = _fournisseurs.FindIndex(c => c.Id == fid);
        if (index >= 0) cmbFournisseur.SelectedIndex = index;

        // L'unité et le stock ne se modifient pas ici (le stock change avec Consommer / Réapprovisionner)
        cmbUnite.Enabled = false;
        nudStock.Enabled = false;
    }

    private static decimal ConvertirDecimal(object? valeur) =>
        valeur is double d ? (decimal)Math.Min(d, 100000) : 0m;

    private void Vider()
    {
        Theme.Deselectionner(dgvIngredients);
        txtNom.Clear();
        nudPrix.Value = 0;
        nudStock.Value = 0;
        nudQuantite.Value = 0;
        cmbUnite.Enabled = true;
        nudStock.Enabled = true;
        if (cmbUnite.Items.Count > 0) cmbUnite.SelectedIndex = 0;
        if (cmbFournisseur.Items.Count > 0) cmbFournisseur.SelectedIndex = 0;
        txtNom.Focus();
    }

    private void btnNouveau_Click(object? sender, EventArgs e) => Vider();

    // AJOUTER : Restaurant.AjouterIngredient
    private void btnAjouter_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvIngredients) is not null)
        {
            Theme.Info("Une ligne est sélectionnée. Cliquez d'abord sur « Nouveau » pour saisir un nouvel ingrédient.");
            return;
        }
        if (cmbFournisseur.SelectedItem is not Choix choix)
        {
            Theme.Info("Créez d'abord un fournisseur (menu Gérant, Gérer les fournisseurs).");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var restaurant = db.Restaurants.Single();
            var fournisseur = db.Fournisseurs.Find(choix.Id)!;
            var unite = ((ChoixUnite)cmbUnite.SelectedItem!).Valeur;

            var ingredient = restaurant.AjouterIngredient(txtNom.Text.Trim(), unite,
                (double)nudPrix.Value, (double)nudStock.Value, fournisseur);
            db.SaveChanges();
            Rafraichir();
            Theme.Info($"Ingrédient « {ingredient.Nom} » ajouté.");
        }
        catch (Exception ex) when (ex is ArgumentException or DbUpdateException)
        {
            Theme.Erreur("Échec de l'ajout : " + ex.Message);
        }
    }

    // MODIFIER : nom, prix (Ingredient.ModifierPrix) et fournisseur
    private void btnModifier_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvIngredients) is not int id || cmbFournisseur.SelectedItem is not Choix choix)
        {
            Theme.Info("Sélectionnez d'abord un ingrédient dans le tableau.");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var ingredient = db.Ingredients.Find(id);
            if (ingredient is null) return;
            ingredient.Nom = txtNom.Text.Trim();
            ingredient.ModifierPrix((double)nudPrix.Value);
            ingredient.Fournisseur = db.Fournisseurs.Find(choix.Id)!;
            db.SaveChanges();
            Rafraichir(id);
            Theme.Info("Ingrédient modifié.");
        }
        catch (Exception ex) when (ex is ArgumentException or DbUpdateException)
        {
            Theme.Erreur("Échec de la modification : " + ex.Message);
        }
    }

    // SUPPRIMER : Restaurant.SupprimerIngredient
    private void btnSupprimer_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvIngredients) is not int id)
        {
            Theme.Info("Sélectionnez d'abord un ingrédient dans le tableau.");
            return;
        }
        if (!Theme.Confirmer("Supprimer cet ingrédient ?")) return;

        try
        {
            using var db = new RestaurantDbContext();
            var restaurant = db.Restaurants.Include(r => r.Ingredients).Single();
            var ingredient = restaurant.Ingredients.FirstOrDefault(i => i.Id == id);
            if (ingredient is null) return;
            restaurant.SupprimerIngredient(ingredient);
            db.Ingredients.Remove(ingredient);
            db.SaveChanges();
            Rafraichir();
        }
        catch (DbUpdateException)
        {
            // Restrict : l'ingrédient est utilisé dans une recette
            Theme.Erreur("Suppression impossible : cet ingrédient est utilisé dans une recette.");
        }
    }

    private void btnConsommer_Click(object? sender, EventArgs e) => MouvementStock(consommer: true);

    private void btnReapprovisionner_Click(object? sender, EventArgs e) => MouvementStock(consommer: false);

    // Ingredient.Consommer / Ingredient.Reapprovisionner
    private void MouvementStock(bool consommer)
    {
        if (Theme.IdSelectionne(dgvIngredients) is not int id)
        {
            Theme.Info("Sélectionnez d'abord un ingrédient dans le tableau.");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var ingredient = db.Ingredients.Find(id);
            if (ingredient is null) return;

            double quantite = (double)nudQuantite.Value;
            if (consommer) ingredient.Consommer(quantite);
            else ingredient.Reapprovisionner(quantite);

            db.SaveChanges();
            Rafraichir(id);
        }
        catch (Exception ex) when (ex is ArgumentException or InvalidOperationException or DbUpdateException)
        {
            Theme.Erreur("Opération refusée : " + ex.Message);
        }
    }

    private void btnFermer_Click(object? sender, EventArgs e) => Close();
}
