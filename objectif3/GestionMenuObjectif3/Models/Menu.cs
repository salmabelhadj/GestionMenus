using System.Globalization;
using System.Text;

namespace GestionMenusRecettes.Models;

/// <summary>Un menu : un ensemble de plats proposés ensemble (relation « propose »).</summary>
public class Menu
{
    public int Id { get; private set; }

    private string _nom = string.Empty;
    public string Nom
    {
        get => _nom;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Le nom du menu est obligatoire.");
            _nom = value;
        }
    }

    /// <summary>Relation plusieurs-à-plusieurs avec Plat (table de jointure « MenuPlat »).</summary>
    public List<Plat> Plats { get; private set; } = new();

    private Menu() { }   // utilisé par EF Core

    public Menu(string nom) => Nom = nom;

    public void AjouterPlat(Plat plat)
    {
        if (plat is null) throw new ArgumentException("Le plat est obligatoire.");
        if (!Plats.Contains(plat)) Plats.Add(plat);
    }

    public void RetirerPlat(Plat plat) => Plats.Remove(plat);

    public double CalculerCoutTotal() => Plats.Sum(p => p.CalculerCout());

    public double CalculerPrixTotal() => Plats.Sum(p => p.PrixVente);

    public double CalculerMargeTotale() => Plats.Sum(p => p.CalculerMarge());

    /// <summary>Texte du rapport du menu : coût, prix et marge de chaque plat, puis les totaux.</summary>
    public string AfficherRapport()
    {
        var fr = CultureInfo.GetCultureInfo("fr-FR");
        var sb = new StringBuilder();
        sb.AppendLine($"=== Rapport du menu : {Nom} ===");
        sb.AppendLine(string.Format(fr, "{0,-24} {1,10} {2,10} {3,10} {4,8}", "Plat", "Coût (DT)", "Prix (DT)", "Marge (DT)", "Taux %"));
        foreach (var p in Plats)
            sb.AppendLine(string.Format(fr, "{0,-24} {1,10:0.000} {2,10:0.000} {3,10:0.000} {4,8:0.0}",
                p.Nom, p.CalculerCout(), p.PrixVente, p.CalculerMarge(), p.CalculerTauxMarge()));

        double prix = CalculerPrixTotal();
        double marge = CalculerMargeTotale();
        double taux = prix == 0 ? 0 : marge / prix * 100;
        sb.AppendLine(string.Format(fr, "{0,-24} {1,10:0.000} {2,10:0.000} {3,10:0.000} {4,8:0.0}",
            "TOTAL", CalculerCoutTotal(), prix, marge, taux));
        return sb.ToString();
    }

    public override string ToString() => $"{Nom} : {Plats.Count} plat(s), marge totale {CalculerMargeTotale():0.000} DT";
}
