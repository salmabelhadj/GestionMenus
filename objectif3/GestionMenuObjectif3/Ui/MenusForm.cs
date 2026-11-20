using System.Windows.Forms;
using GestionMenusRecettes.Data;
using GestionMenusRecettes.Models;
using Microsoft.EntityFrameworkCore;

// « Menu » existe aussi dans System.Windows.Forms : on précise qu'il s'agit de notre classe
using Menu = GestionMenusRecettes.Models.Menu;

namespace GestionMenusRecettes.Ui;

/// <summary>Gérer les menus (gérant) : créer, renommer, supprimer, ajouter/retirer des plats.</summary>
public partial class MenusForm : Form
{
    public MenusForm()
    {
        InitializeComponent();
        Theme.Grille(dgvMenus);
        Theme.Grille(dgvPlatsMenu);
        cmbPlat.DisplayMember = nameof(Choix.Texte);
    }

    private void MenusForm_Load(object? sender, EventArgs e)
    {
        if (DesignMode) return;
        Rafraichir();
    }

    // Charge un menu avec tout ce qu'il faut pour calculer coûts et marges
    private static IQueryable<Menu> MenusComplets(RestaurantDbContext db) =>
        db.Menus.Include(m => m.Plats).ThenInclude(p => p.Recette).ThenInclude(r => r.Lignes).ThenInclude(l => l.Ingredient);

    /// <summary>Consulter : menus avec coût total, prix total et marge totale.</summary>
    private void Rafraichir(int? selectionId = null)
    {
        using var db = new RestaurantDbContext();

        cmbPlat.DataSource = db.Plats.OrderBy(p => p.Nom).ToList().Select(p => new Choix(p.Id, p.Nom)).ToList();

        dgvMenus.DataSource = MenusComplets(db)
            .OrderBy(m => m.Id)
            .ToList()
            .Select(m => new
            {
                m.Id,
                m.Nom,
                Nb_Plats = m.Plats.Count,
                Cout_Total_DT = m.CalculerCoutTotal(),
                Prix_Total_DT = m.CalculerPrixTotal(),
                Marge_Totale_DT = m.CalculerMargeTotale()
            })
            .ToList();

        Vider();
        if (selectionId is int id) Theme.Selectionner(dgvMenus, id, "Nom");
    }

    private void RafraichirPlats()
    {
        if (Theme.IdSelectionne(dgvMenus) is not int idMenu)
        {
            dgvPlatsMenu.DataSource = null;
            return;
        }

        using var db = new RestaurantDbContext();
        var menu = MenusComplets(db).FirstOrDefault(m => m.Id == idMenu);
        dgvPlatsMenu.DataSource = menu?.Plats
            .Select(p => new
            {
                p.Id,
                p.Nom,
                Categorie = p.Categorie.Libelle(),
                Prix_DT = p.PrixVente,
                Cout_DT = p.CalculerCout(),
                Marge_DT = p.CalculerMarge()
            })
            .ToList();
    }

    private void dgvMenus_SelectionChanged(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvMenus) is null)
        {
            dgvPlatsMenu.DataSource = null;
            return;
        }
        txtNom.Text = dgvMenus.CurrentRow!.Cells["Nom"].Value?.ToString() ?? "";
        RafraichirPlats();
    }

    private void Vider()
    {
        Theme.Deselectionner(dgvMenus);
        dgvPlatsMenu.DataSource = null;
        txtNom.Clear();
        txtNom.Focus();
    }

    private void btnNouveau_Click(object? sender, EventArgs e) => Vider();

    // CRÉER : Restaurant.CreerMenu
    private void btnAjouter_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvMenus) is not null)
        {
            Theme.Info("Une ligne est sélectionnée. Cliquez d'abord sur « Nouveau » pour créer un nouveau menu.");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var restaurant = db.Restaurants.Single();
            var menu = restaurant.CreerMenu(txtNom.Text.Trim());
            db.SaveChanges();
            Rafraichir(menu.Id);
            Theme.Info("Menu créé. Ajoutez maintenant ses plats en bas de la fenêtre.");
        }
        catch (Exception ex) when (ex is ArgumentException or DbUpdateException)
        {
            Theme.Erreur("Échec de la création : " + ex.Message);
        }
    }

    // RENOMMER
    private void btnModifier_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvMenus) is not int id)
        {
            Theme.Info("Sélectionnez d'abord un menu dans le tableau.");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var menu = db.Menus.Find(id);
            if (menu is null) return;
            menu.Nom = txtNom.Text.Trim();
            db.SaveChanges();
            Rafraichir(id);
        }
        catch (Exception ex) when (ex is ArgumentException or DbUpdateException)
        {
            Theme.Erreur("Échec de la modification : " + ex.Message);
        }
    }

    // SUPPRIMER : Restaurant.SupprimerMenu
    private void btnSupprimer_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvMenus) is not int id)
        {
            Theme.Info("Sélectionnez d'abord un menu dans le tableau.");
            return;
        }
        if (!Theme.Confirmer("Supprimer ce menu ? (les plats ne sont pas supprimés)")) return;

        try
        {
            using var db = new RestaurantDbContext();
            var restaurant = db.Restaurants.Include(r => r.Menus).Single();
            var menu = restaurant.Menus.FirstOrDefault(m => m.Id == id);
            if (menu is null) return;
            restaurant.SupprimerMenu(menu);
            db.Menus.Remove(menu);
            db.SaveChanges();
            Rafraichir();
        }
        catch (DbUpdateException ex)
        {
            Theme.Erreur("Suppression impossible : " + ex.Message);
        }
    }

    // Menu.AjouterPlat
    private void btnAjouterPlat_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvMenus) is not int idMenu)
        {
            Theme.Info("Sélectionnez d'abord un menu dans le tableau du haut.");
            return;
        }
        if (cmbPlat.SelectedItem is not Choix choix)
        {
            Theme.Info("Aucun plat disponible : créez-en d'abord (menu Gérant, Gérer les plats).");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var menu = db.Menus.Include(m => m.Plats).First(m => m.Id == idMenu);
            var plat = db.Plats.Find(choix.Id)!;
            menu.AjouterPlat(plat);
            db.SaveChanges();
            Rafraichir(idMenu);
        }
        catch (Exception ex) when (ex is ArgumentException or DbUpdateException)
        {
            Theme.Erreur("Échec de l'ajout : " + ex.Message);
        }
    }

    // Menu.RetirerPlat
    private void btnRetirerPlat_Click(object? sender, EventArgs e)
    {
        if (Theme.IdSelectionne(dgvMenus) is not int idMenu || Theme.IdSelectionne(dgvPlatsMenu) is not int idPlat)
        {
            Theme.Info("Sélectionnez un menu, puis le plat à retirer dans le tableau du bas.");
            return;
        }

        try
        {
            using var db = new RestaurantDbContext();
            var menu = db.Menus.Include(m => m.Plats).First(m => m.Id == idMenu);
            var plat = menu.Plats.FirstOrDefault(p => p.Id == idPlat);
            if (plat is null) return;
            menu.RetirerPlat(plat);
            db.SaveChanges();
            Rafraichir(idMenu);
        }
        catch (DbUpdateException ex)
        {
            Theme.Erreur("Échec : " + ex.Message);
        }
    }

    private void btnFermer_Click(object? sender, EventArgs e) => Close();
}
