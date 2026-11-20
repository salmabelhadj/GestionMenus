namespace GestionMenusRecettes.Models;

/// <summary>Un ingrédient et sa quantité dans une recette (relation « utilise »).</summary>
public class LigneRecette
{
    public int Id { get; private set; }

    public int RecetteId { get; private set; }
    public Recette Recette { get; private set; } = null!;

    public int IngredientId { get; private set; }
    public Ingredient Ingredient { get; private set; } = null!;

    private double _quantite;
    public double Quantite
    {
        get => _quantite;
        set
        {
            if (value <= 0) throw new ArgumentException("La quantité doit être strictement positive.");
            _quantite = value;
        }
    }

    private LigneRecette() { }   // utilisé par EF Core

    public LigneRecette(Ingredient ingredient, double quantite)
    {
        if (ingredient is null) throw new ArgumentException("L'ingrédient est obligatoire.");
        Ingredient = ingredient;
        Quantite = quantite;
    }

    public double CalculerCout() => Quantite * Ingredient.PrixUnitaire;
}
