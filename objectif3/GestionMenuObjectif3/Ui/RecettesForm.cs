using System.Windows.Forms;
using GestionMenusRecettes.Data;
using GestionMenusRecettes.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionMenusRecettes.Ui;

/// <summary>Gérer les recettes (chef cuisinier) : créer, modifier, supprimer, consulter, ajouter/retirer des ingrédients.</summary>
public partial class RecettesForm : Form
{
    public RecettesForm()
    {
        InitializeComponent();
        Theme.Grille(dgvRecettes);
        Theme.Grille(dgvLignes);
        cmbIngredient.DisplayMember = nameof(Choix.Texte);
    }

    private void RecettesForm_Load(object? sender, EventArgs e)
    {
        if (DesignMode) return;
        Rafraichir();
    }

    /// <summary>Consulter : recettes avec leur coût, et liste des ingrédients disponibles.</summary>
    private void Rafraichir(int? selectionId = null)
    {
        using var db = new RestaurantDbContext();

        cmbIngredient.DataSource = db.Ingredients.OrderBy(i => i.Nom).ToList()
            .Select(i => new Choix(i.Id, $"{i.Nom} ({i.Unite.Symbole()})")).ToList();

        dgvRecettes.DataSource = db.Recettes
            .Include(r => r.Lignes).ThenInclude(l => l.Ingredient)
            .OrderBy(r => r.Id)
            .ToList()
            .Select(r => new
            {
                r.Id,
                r.Nom,
                Portions = r.NbPortions,
                Cout_Total_DT = r.CalculerCoutTotal(),
                Cout_Portion_DT = r.CalculerCoutParPortion()
            })
            .ToList();

        Vider();
        if (selectionId is int id) Theme.Selectionner(dgvRecettes, id, "Nom");
    }

    private void RafraichirLignes()
    {
        if (Theme.IdSelectionne(dgvRecettes) is not int idRecette)
        {
            dgvLignes.DataSource = null;
            return;
        }

        using var db = new RestaurantDbContext();
        dgvLignes.DataSource = db.LignesRecette
            .Include(l => l.Ingredient)
            .Where(l => l.RecetteId == idRecette)
            .OrderBy(l => l.Id)
            .ToList()
            .Select(l => new
            {
                l.Id,
                Ingredient = l.Ingredient.Nom,
                l.Quantite,
                Unite = l.Ingredient.Unite.Symbole(),
                Prix_Unitaire_DT = l.Ingredient.PrixUnitaire,
                Cout_DT = l.CalculerCout()
            })
            .ToList();
    }

    private void dgvRecettes_SelectionChanged(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvRecettes) is null)
        {
            dgvLignes.DataSource = null;
            return;
        }
        var l = dgvRecettes.CurrentRow!;
        txtNom.Text = l.Cells["Nom"].Value?.ToString() ?? "";
        nudPortions.Value = l.Cells["Portions"].Value is int p ? Math.Clamp(p, 1, 1000) : 1;
        RafraichirLignes();
    }

    private void Vider()
    {
        Theme.Deselectionner(dgvRecettes);
        dgvLignes.DataSource = null;
        txtNom.Clear();
        nudPortions.Value = 1;
        nudQuantite.Value = 0;
        txtNom.Focus();
    }

    private void btnNouveau_Click(object? sender, EventArgs e) => Vider();

    // CRÉER : Restaurant.CreerRecette
    private void btnAjouter_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvRecettes) is not null)
        {
            Theme.Info("Une ligne est sélectionnée. Cliquez d'abord sur « Nouveau » pour créer une nouvelle recette.");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var restaurant = db.Restaurants.Single();
            var recette = restaurant.CreerRecette(txtNom.Text.Trim(), (int)nudPortions.Value);
            db.SaveChanges();
            Rafraichir(recette.Id);
            Theme.Info("Recette créée. Ajoutez maintenant ses ingrédients en bas de la fenêtre.");
        }
        catch (Exception ex) when (ex is ArgumentException or DbUpdateException)
        {
            Theme.Erreur("Échec de la création : " + ex.Message);
        }
    }

    // MODIFIER : nom et nombre de portions
    private void btnModifier_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvRecettes) is not int id)
        {
            Theme.Info("Sélectionnez d'abord une recette dans le tableau.");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var recette = db.Recettes.Find(id);
            if (recette is null) return;
            recette.Nom = txtNom.Text.Trim();
            recette.NbPortions = (int)nudPortions.Value;
            db.SaveChanges();
            Rafraichir(id);
            Theme.Info("Recette modifiée.");
        }
        catch (Exception ex) when (ex is ArgumentException or DbUpdateException)
        {
            Theme.Erreur("Échec de la modification : " + ex.Message);
        }
    }

    // SUPPRIMER : Restaurant.SupprimerRecette
    private void btnSupprimer_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvRecettes) is not int id)
        {
            Theme.Info("Sélectionnez d'abord une recette dans le tableau.");
            return;
        }
        if (!Theme.Confirmer("Supprimer cette recette et ses lignes d'ingrédients ?")) return;

        try
        {
            using var db = new RestaurantDbContext();
            var restaurant = db.Restaurants.Include(r => r.Recettes).Single();
            var recette = restaurant.Recettes.FirstOrDefault(r => r.Id == id);
            if (recette is null) return;
            restaurant.SupprimerRecette(recette);
            db.Recettes.Remove(recette);
            db.SaveChanges();
            Rafraichir();
        }
        catch (DbUpdateException)
        {
            // Restrict : un plat utilise cette recette
            Theme.Erreur("Suppression impossible : un plat utilise cette recette.");
        }
    }

    // Recette.AjouterIngredient
    private void btnAjouterLigne_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvRecettes) is not int idRecette)
        {
            Theme.Info("Sélectionnez d'abord une recette dans le tableau du haut.");
            return;
        }
        if (cmbIngredient.SelectedItem is not Choix choix)
        {
            Theme.Info("Aucun ingrédient disponible : créez-en d'abord (menu Chef cuisinier).");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var recette = db.Recettes.Include(r => r.Lignes).ThenInclude(l => l.Ingredient)
                .First(r => r.Id == idRecette);
            var ingredient = db.Ingredients.Find(choix.Id)!;
            recette.AjouterIngredient(ingredient, (double)nudQuantite.Value);
            db.SaveChanges();
            Rafraichir(idRecette);
        }
        catch (Exception ex) when (ex is ArgumentException or DbUpdateException)
        {
            Theme.Erreur("Échec de l'ajout : " + ex.Message);
        }
    }

    // Recette.SupprimerIngredient
    private void btnRetirerLigne_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvRecettes) is not int idRecette || Theme.IdSelectionne(dgvLignes) is not int idLigne)
        {
            Theme.Info("Sélectionnez une recette, puis l'ingrédient à retirer dans le tableau du bas.");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var recette = db.Recettes.Include(r => r.Lignes).ThenInclude(l => l.Ingredient)
                .First(r => r.Id == idRecette);
            var ligne = recette.Lignes.FirstOrDefault(l => l.Id == idLigne);
            if (ligne is null) return;
            recette.SupprimerIngredient(ligne.Ingredient);
            db.LignesRecette.Remove(ligne);
            db.SaveChanges();
            Rafraichir(idRecette);
        }
        catch (DbUpdateException ex)
        {
            Theme.Erreur("Échec de la suppression : " + ex.Message);
        }
    }

    private void btnFermer_Click(object? sender, EventArgs e) => Close();
}
