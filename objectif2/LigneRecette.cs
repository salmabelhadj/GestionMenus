namespace GestionMenusRecettes.Models;

// Une ligne = un ingrédient + la quantité utilisée (dans l'unité de l'ingrédient)
public class LigneRecette
{
    private Ingredient ingredient;
    private double quantite;

    public LigneRecette(Ingredient ingredient, double quantite)
    {
        ArgumentNullException.ThrowIfNull(ingredient);
        if (quantite <= 0)
            throw new ArgumentException("La quantité doit être positive.");

        this.ingredient = ingredient;
        this.quantite = quantite;
    }

    public Ingredient Ingredient => ingredient;
    public double Quantite => quantite;

    public double CalculerCout() => quantite * ingredient.PrixUnitaire;
}
