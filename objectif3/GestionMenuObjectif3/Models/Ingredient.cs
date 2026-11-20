namespace GestionMenusRecettes.Models;

/// <summary>Un ingrédient : prix unitaire, stock et fournisseur.</summary>
public class Ingredient
{
    public int Id { get; private set; }

    private string _nom = string.Empty;
    public string Nom
    {
        get => _nom;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Le nom de l'ingrédient est obligatoire.");
            _nom = value;
        }
    }

    public Unite Unite { get; private set; }
    public double PrixUnitaire { get; private set; }
    public double Stock { get; private set; }

    // Relation « est fourni par » : un ingrédient a un fournisseur
    public int FournisseurId { get; private set; }
    public Fournisseur Fournisseur { get; set; } = null!;

    private Ingredient() { }   // utilisé par EF Core

    public Ingredient(string nom, Unite unite, double prixUnitaire, double stock, Fournisseur fournisseur)
    {
        if (prixUnitaire < 0 || stock < 0)
            throw new ArgumentException("Le prix et le stock ne peuvent pas être négatifs.");
        if (fournisseur is null)
            throw new ArgumentException("Le fournisseur est obligatoire.");

        Nom = nom;
        Unite = unite;
        PrixUnitaire = prixUnitaire;
        Stock = stock;
        Fournisseur = fournisseur;
    }

    public void ModifierPrix(double nouveauPrix)
    {
        if (nouveauPrix < 0) throw new ArgumentException("Le prix ne peut pas être négatif.");
        PrixUnitaire = nouveauPrix;
    }

    /// <summary>Retire une quantité du stock (utilisation en cuisine).</summary>
    public void Consommer(double quantite)
    {
        if (quantite <= 0) throw new ArgumentException("La quantité doit être positive.");
        if (quantite > Stock)
            throw new InvalidOperationException($"Stock insuffisant pour {Nom} (disponible : {Stock:0.###} {Unite.Symbole()}).");
        Stock -= quantite;
    }

    /// <summary>Ajoute une quantité au stock (livraison).</summary>
    public void Reapprovisionner(double quantite)
    {
        if (quantite <= 0) throw new ArgumentException("La quantité doit être positive.");
        Stock += quantite;
    }

    public override string ToString() => $"{Nom} : {PrixUnitaire:0.000} DT/{Unite.Symbole()}, stock {Stock:0.##} {Unite.Symbole()}";
}
