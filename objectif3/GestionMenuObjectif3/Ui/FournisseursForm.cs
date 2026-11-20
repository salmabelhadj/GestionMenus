using System.Windows.Forms;
using GestionMenusRecettes.Data;
using Microsoft.EntityFrameworkCore;

namespace GestionMenusRecettes.Ui;

/// <summary>Gérer les fournisseurs (gérant) : ajouter, modifier, supprimer, consulter.</summary>
public partial class FournisseursForm : Form
{
    public FournisseursForm()
    {
        InitializeComponent();
        Theme.Grille(dgvFournisseurs);
    }

    private void FournisseursForm_Load(object? sender, EventArgs e)
    {
        if (DesignMode) return;
        Rafraichir();
    }

    /// <summary>Consulter : relit la table Fournisseurs.</summary>
    private void Rafraichir()
    {
        using var db = new RestaurantDbContext();
        dgvFournisseurs.DataSource = db.Fournisseurs
            .OrderBy(f => f.Id)
            .Select(f => new { f.Id, f.Nom, f.Telephone, Nb_Ingredients = f.Ingredients.Count })
            .ToList();
        Vider();
    }

    private void dgvFournisseurs_SelectionChanged(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvFournisseurs) is null) return;
        var ligne = dgvFournisseurs.CurrentRow!;
        txtNom.Text = ligne.Cells["Nom"].Value?.ToString() ?? "";
        txtTelephone.Text = ligne.Cells["Telephone"].Value?.ToString() ?? "";
    }

    private void Vider()
    {
        Theme.Deselectionner(dgvFournisseurs);
        txtNom.Clear();
        txtTelephone.Clear();
        txtNom.Focus();
    }

    private void btnNouveau_Click(object? sender, EventArgs e) => Vider();

    // AJOUTER : Restaurant.AjouterFournisseur puis SaveChanges
    private void btnAjouter_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvFournisseurs) is not null)
        {
            Theme.Info("Une ligne est sélectionnée. Cliquez d'abord sur « Nouveau » pour saisir un nouveau fournisseur.");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var restaurant = db.Restaurants.Single();
            var fournisseur = restaurant.AjouterFournisseur(txtNom.Text.Trim(), txtTelephone.Text.Trim());
            db.SaveChanges();
            Rafraichir();
            Theme.Info($"Fournisseur « {fournisseur.Nom} » ajouté.");
        }
        catch (Exception ex) when (ex is ArgumentException or DbUpdateException)
        {
            Theme.Erreur("Échec de l'ajout : " + ex.Message);
        }
    }

    // MODIFIER : nom + Fournisseur.ModifierTelephone
    private void btnModifier_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvFournisseurs) is not int id)
        {
            Theme.Info("Sélectionnez d'abord un fournisseur dans le tableau.");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var fournisseur = db.Fournisseurs.Find(id);
            if (fournisseur is null) return;
            fournisseur.Nom = txtNom.Text.Trim();
            fournisseur.ModifierTelephone(txtTelephone.Text.Trim());
            db.SaveChanges();
            Rafraichir();
            Theme.Info("Fournisseur modifié.");
        }
        catch (Exception ex) when (ex is ArgumentException or DbUpdateException)
        {
            Theme.Erreur("Échec de la modification : " + ex.Message);
        }
    }

    // SUPPRIMER : Restaurant.SupprimerFournisseur
    private void btnSupprimer_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvFournisseurs) is not int id)
        {
            Theme.Info("Sélectionnez d'abord un fournisseur dans le tableau.");
            return;
        }
        if (!Theme.Confirmer("Supprimer ce fournisseur ?")) return;

        try
        {
            using var db = new RestaurantDbContext();
            var restaurant = db.Restaurants.Include(r => r.Fournisseurs).Single();
            var fournisseur = restaurant.Fournisseurs.FirstOrDefault(f => f.Id == id);
            if (fournisseur is null) return;
            restaurant.SupprimerFournisseur(fournisseur);
            db.Fournisseurs.Remove(fournisseur);
            db.SaveChanges();
            Rafraichir();
        }
        catch (DbUpdateException)
        {
            // Restrict : le fournisseur fournit encore des ingrédients
            Theme.Erreur("Suppression impossible : ce fournisseur fournit encore des ingrédients.");
        }
    }

    private void btnFermer_Click(object? sender, EventArgs e) => Close();
}
