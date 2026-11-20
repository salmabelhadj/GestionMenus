using System.Text;
using System.Windows.Forms;
using GestionMenusRecettes.Data;
using GestionMenusRecettes.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionMenusRecettes.Ui;

/// <summary>Consulter le rapport (gérant) : coût d'un plat, marge d'un plat, marge totale d'un menu.</summary>
public partial class RapportForm : Form
{
    public RapportForm()
    {
        InitializeComponent();
        Theme.Grille(dgvPlats);
        Theme.Grille(dgvMenus);
    }

    private void RapportForm_Load(object? sender, EventArgs e)
    {
        if (DesignMode) return;
        Rafraichir();
    }

    private void btnActualiser_Click(object? sender, EventArgs e) => Rafraichir();

    private void btnFermer_Click(object? sender, EventArgs e) => Close();

    private void Rafraichir()
    {
        using var db = new RestaurantDbContext();

        var plats = db.Plats
            .Include(p => p.Recette).ThenInclude(r => r.Lignes).ThenInclude(l => l.Ingredient)
            .OrderBy(p => p.Nom)
            .ToList();

        var menus = db.Menus
            .Include(m => m.Plats).ThenInclude(p => p.Recette).ThenInclude(r => r.Lignes).ThenInclude(l => l.Ingredient)
            .OrderBy(m => m.Nom)
            .ToList();

        dgvPlats.DataSource = plats.Select(p => new
        {
            p.Id,
            p.Nom,
            Categorie = p.Categorie.Libelle(),
            Prix_DT = p.PrixVente,
            Cout_DT = p.CalculerCout(),
            Marge_DT = p.CalculerMarge(),
            Taux_Marge_Pct = p.CalculerTauxMarge(),
            Coefficient = p.CalculerCoefficient()
        }).ToList();

        dgvMenus.DataSource = menus.Select(m =>
        {
            double prix = m.CalculerPrixTotal();
            double marge = m.CalculerMargeTotale();
            return new
            {
                m.Id,
                m.Nom,
                Nb_Plats = m.Plats.Count,
                Cout_Total_DT = m.CalculerCoutTotal(),
                Prix_Total_DT = prix,
                Marge_Totale_DT = marge,
                Taux_Marge_Pct = prix == 0 ? 0 : marge / prix * 100
            };
        }).ToList();

        var texte = new StringBuilder();
        foreach (var menu in menus)
        {
            texte.AppendLine(menu.AfficherRapport());
        }
        if (plats.Count > 0)
        {
            var meilleur = plats.OrderByDescending(p => p.CalculerTauxMarge()).First();
            var pire = plats.OrderBy(p => p.CalculerTauxMarge()).First();
            texte.AppendLine($"Plat le plus rentable : {meilleur.Nom} ({meilleur.CalculerTauxMarge():0.0} %)");
            texte.AppendLine($"Plat le moins rentable : {pire.Nom} ({pire.CalculerTauxMarge():0.0} %)");
        }
        txtRapport.Text = texte.ToString();
    }
}
