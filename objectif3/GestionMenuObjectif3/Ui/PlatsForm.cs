using System.Windows.Forms;
using GestionMenusRecettes.Data;
using GestionMenusRecettes.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionMenusRecettes.Ui;

/// <summary>Gérer les plats (gérant) : ajouter, modifier, supprimer, consulter coût et marge.</summary>
public partial class PlatsForm : Form
{
    private sealed record ChoixCategorie(Categorie Valeur, string Texte);
    private sealed record ChoixRecette(int Id, string Texte, bool Libre);

    private List<ChoixRecette> _recettes = new();

    public PlatsForm()
    {
        InitializeComponent();
        Theme.Grille(dgvPlats);

        cmbCategorie.DisplayMember = nameof(ChoixCategorie.Texte);
        cmbCategorie.DataSource = Enum.GetValues<Categorie>().Select(c => new ChoixCategorie(c, c.Libelle())).ToList();
        cmbRecette.DisplayMember = nameof(ChoixRecette.Texte);
    }

    private void PlatsForm_Load(object? sender, EventArgs e)
    {
        if (DesignMode) return;
        Rafraichir();
    }

    /// <summary>Consulter : plats avec coût, marge, taux de marge et coefficient.</summary>
    private void Rafraichir(int? selectionId = null)
    {
        using var db = new RestaurantDbContext();

        var recettesUtilisees = db.Plats.Select(p => p.RecetteId).ToList();
        _recettes = db.Recettes.OrderBy(r => r.Nom).ToList()
            .Select(r => recettesUtilisees.Contains(r.Id)
                ? new ChoixRecette(r.Id, r.Nom + " (déjà utilisée)", false)
                : new ChoixRecette(r.Id, r.Nom, true))
            .ToList();
        cmbRecette.DataSource = _recettes;

        dgvPlats.DataSource = db.Plats
            .Include(p => p.Recette).ThenInclude(r => r.Lignes).ThenInclude(l => l.Ingredient)
            .OrderBy(p => p.Id)
            .ToList()
            .Select(p => new
            {
                p.Id,
                p.Nom,
                Categorie = p.Categorie.Libelle(),
                Recette = p.Recette.Nom,
                Prix_DT = p.PrixVente,
                Cout_DT = p.CalculerCout(),
                Marge_DT = p.CalculerMarge(),
                Taux_Marge_Pct = p.CalculerTauxMarge(),
                Coefficient = p.CalculerCoefficient(),
                p.RecetteId,
                CategorieCode = p.Categorie
            })
            .ToList();

        if (dgvPlats.Columns.Contains("CategorieCode")) dgvPlats.Columns["CategorieCode"].Visible = false;

        Vider();
        if (selectionId is int id) Theme.Selectionner(dgvPlats, id, "Nom");
    }

    private void dgvPlats_SelectionChanged(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvPlats) is null) return;
        var l = dgvPlats.CurrentRow!;

        txtNom.Text = l.Cells["Nom"].Value?.ToString() ?? "";
        nudPrix.Value = l.Cells["Prix_DT"].Value is double d ? (decimal)Math.Min(d, 100000) : 0m;

        if (l.Cells["CategorieCode"].Value is Categorie c)
            cmbCategorie.SelectedIndex = (int)c;

        int rid = l.Cells["RecetteId"].Value is int v ? v : 0;
        int index = _recettes.FindIndex(r => r.Id == rid);
        if (index >= 0) cmbRecette.SelectedIndex = index;

        cmbRecette.Enabled = false;   // la recette d'un plat ne change pas
    }

    private void Vider()
    {
        Theme.Deselectionner(dgvPlats);
        txtNom.Clear();
        nudPrix.Value = 0;
        cmbRecette.Enabled = true;
        if (cmbCategorie.Items.Count > 0) cmbCategorie.SelectedIndex = 0;
        if (cmbRecette.Items.Count > 0) cmbRecette.SelectedIndex = 0;
        txtNom.Focus();
    }

    private void btnNouveau_Click(object? sender, EventArgs e) => Vider();

    // AJOUTER : Restaurant.AjouterPlat
    private void btnAjouter_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvPlats) is not null)
        {
            Theme.Info("Une ligne est sélectionnée. Cliquez d'abord sur « Nouveau » pour saisir un nouveau plat.");
            return;
        }
        if (cmbRecette.SelectedItem is not ChoixRecette choix)
        {
            Theme.Info("Créez d'abord une recette (menu Chef cuisinier, Gérer les recettes).");
            return;
        }
        if (!choix.Libre)
        {
            Theme.Info("Cette recette est déjà utilisée par un autre plat. Choisissez-en une autre.");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var restaurant = db.Restaurants.Single();
            var recette = db.Recettes.Find(choix.Id)!;
            var categorie = ((ChoixCategorie)cmbCategorie.SelectedItem!).Valeur;

            var plat = restaurant.AjouterPlat(txtNom.Text.Trim(), categorie, (double)nudPrix.Value, recette);
            db.SaveChanges();
            Rafraichir(plat.Id);
            Theme.Info($"Plat « {plat.Nom} » ajouté.");
        }
        catch (Exception ex) when (ex is ArgumentException or DbUpdateException)
        {
            Theme.Erreur("Échec de l'ajout : " + ex.Message);
        }
    }

    // MODIFIER : nom, catégorie et Plat.ModifierPrixVente
    private void btnModifier_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvPlats) is not int id)
        {
            Theme.Info("Sélectionnez d'abord un plat dans le tableau.");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var plat = db.Plats.Find(id);
            if (plat is null) return;
            plat.Nom = txtNom.Text.Trim();
            plat.Categorie = ((ChoixCategorie)cmbCategorie.SelectedItem!).Valeur;
            plat.ModifierPrixVente((double)nudPrix.Value);
            db.SaveChanges();
            Rafraichir(id);
            Theme.Info("Plat modifié.");
        }
        catch (Exception ex) when (ex is ArgumentException or DbUpdateException)
        {
            Theme.Erreur("Échec de la modification : " + ex.Message);
        }
    }

    // SUPPRIMER : Restaurant.SupprimerPlat
    private void btnSupprimer_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvPlats) is not int id)
        {
            Theme.Info("Sélectionnez d'abord un plat dans le tableau.");
            return;
        }
        if (!Theme.Confirmer("Supprimer ce plat (il sera aussi retiré des menus) ?")) return;

        try
        {
            using var db = new RestaurantDbContext();
            var restaurant = db.Restaurants.Include(r => r.Plats).Single();
            var plat = restaurant.Plats.FirstOrDefault(p => p.Id == id);
            if (plat is null) return;
            restaurant.SupprimerPlat(plat);
            db.Plats.Remove(plat);
            db.SaveChanges();
            Rafraichir();
        }
        catch (DbUpdateException ex)
        {
            Theme.Erreur("Suppression impossible : " + ex.Message);
        }
    }

    private void btnFermer_Click(object? sender, EventArgs e) => Close();
}
