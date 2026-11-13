namespace GestionMenusRecettes.Models;

public class Plat
{
    private int id;
    private string nom;
    private Categorie categorie;
    private double prixVente;   // prix de vente HT
    private Recette recette;

    public Plat(int id, string nom, Categorie categorie, double prixVente, Recette recette)
    {
        if (string.IsNullOrWhiteSpace(nom))
            throw new ArgumentException("Le nom du plat est obligatoire.");
        if (prixVente < 0)
            throw new ArgumentException("Le prix de vente ne peut pas être négatif.");
        ArgumentNullException.ThrowIfNull(recette);

        this.id = id;
        this.nom = nom;
        this.categorie = categorie;
        this.prixVente = prixVente;
        this.recette = recette;
    }

    public int Id => id;
    public string Nom => nom;
    public Categorie Categorie => categorie;
    public double PrixVente => prixVente;
    public Recette Recette => recette;

    public void ModifierPrixVente(double nouveauPrix)
    {
        if (nouveauPrix < 0)
            throw new ArgumentException("Le prix de vente ne peut pas être négatif.");
        prixVente = nouveauPrix;
    }

    // Coût d'UNE portion du plat
    public double CalculerCout() => recette.CalculerCoutParPortion();

    // Marge = prix de vente - coût
    public double CalculerMarge() => prixVente - CalculerCout();

    // Taux de marge = marge / coût x 100
    public double CalculerTauxMarge()
    {
        double cout = CalculerCout();
        return cout == 0 ? 0 : CalculerMarge() / cout * 100;
    }

    // Taux de marque = marge / prix de vente x 100
    public double CalculerTauxMarque()
        => prixVente == 0 ? 0 : CalculerMarge() / prixVente * 100;

    // Coefficient multiplicateur = prix de vente / coût
    public double CalculerCoefficient()
    {
        double cout = CalculerCout();
        return cout == 0 ? 0 : prixVente / cout;
    }
}

