namespace GestionMenusRecettes.Models;

/// <summary>Un plat vendu : catégorie, prix de vente et recette (relation « prépare selon »).</summary>
public class Plat
{
    public int Id { get; private set; }

    private string _nom = string.Empty;
    public string Nom
    {
        get => _nom;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Le nom du plat est obligatoire.");
            _nom = value;
        }
    }

    public Categorie Categorie { get; set; }
    public double PrixVente { get; private set; }

    public int RecetteId { get; private set; }
    public Recette Recette { get; private set; } = null!;

    /// <summary>Menus qui proposent ce plat (relation « propose », côté inverse).</summary>
    public List<Menu> Menus { get; private set; } = new();

    private Plat() { }   // utilisé par EF Core

    public Plat(string nom, Categorie categorie, double prixVente, Recette recette)
    {
        if (recette is null) throw new ArgumentException("La recette est obligatoire.");
        if (prixVente < 0) throw new ArgumentException("Le prix de vente ne peut pas être négatif.");
        Nom = nom;
        Categorie = categorie;
        PrixVente = prixVente;
        Recette = recette;
    }

    public void ModifierPrixVente(double nouveauPrix)
    {
        if (nouveauPrix < 0) throw new ArgumentException("Le prix de vente ne peut pas être négatif.");
        PrixVente = nouveauPrix;
    }

    /// <summary>Coût d'un plat = coût d'une portion de sa recette.</summary>
    public double CalculerCout() => Recette.CalculerCoutParPortion();

    public double CalculerMarge() => PrixVente - CalculerCout();

    public double CalculerTauxMarge() => PrixVente == 0 ? 0 : CalculerMarge() / PrixVente * 100;

    /// <summary>Coefficient multiplicateur = prix de vente / coût.</summary>
    public double CalculerCoefficient()
    {
        double cout = CalculerCout();
        return cout == 0 ? 0 : PrixVente / cout;
    }

    public override string ToString() =>
        $"{Nom} [{Categorie.Libelle()}] prix {PrixVente:0.000} DT, coût {CalculerCout():0.000} DT, marge {CalculerMarge():0.000} DT";
}
