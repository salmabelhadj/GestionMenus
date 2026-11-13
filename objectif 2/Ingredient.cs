namespace GestionMenusRecettes.Models;

public class Ingredient
{
    private int id;
    private string nom;
    private Unite unite;
    private double prixUnitaire;   // prix par unité (ex : DT par Kg)
    private double stock;
    private Fournisseur fournisseur;

    public Ingredient(int id, string nom, Unite unite, double prixUnitaire,
                      double stock, Fournisseur fournisseur)
    {
        if (string.IsNullOrWhiteSpace(nom))
            throw new ArgumentException("Le nom de l'ingrédient est obligatoire.");
        if (prixUnitaire < 0)
            throw new ArgumentException("Le prix ne peut pas être négatif.");
        if (stock < 0)
            throw new ArgumentException("Le stock ne peut pas être négatif.");
        ArgumentNullException.ThrowIfNull(fournisseur);

        this.id = id;
        this.nom = nom;
        this.unite = unite;
        this.prixUnitaire = prixUnitaire;
        this.stock = stock;
        this.fournisseur = fournisseur;
    }

    public int Id => id;
    public string Nom => nom;
    public Unite Unite => unite;
    public double PrixUnitaire => prixUnitaire;
    public double Stock => stock;
    public Fournisseur Fournisseur => fournisseur;

    public void ModifierPrix(double nouveauPrix)
    {
        if (nouveauPrix < 0)
            throw new ArgumentException("Le prix ne peut pas être négatif.");
        prixUnitaire = nouveauPrix;
    }

    public void Consommer(double quantite)
    {
        if (quantite <= 0)
            throw new ArgumentException("La quantité doit être positive.");
        if (quantite > stock)
            throw new InvalidOperationException($"Stock insuffisant pour {nom}.");
        stock -= quantite;
    }

    public void Reapprovisionner(double quantite)
    {
        if (quantite <= 0)
            throw new ArgumentException("La quantité doit être positive.");
        stock += quantite;
    }

    public override string ToString() => $"{nom} ({prixUnitaire:F2} DT/{unite}, stock : {stock})";
}
