namespace GestionMenusRecettes.Models;

/// <summary>Une recette : une liste d'ingrédients avec leurs quantités, pour un nombre de portions.</summary>
public class Recette
{
    public int Id { get; private set; }

    private string _nom = string.Empty;
    public string Nom
    {
        get => _nom;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Le nom de la recette est obligatoire.");
            _nom = value;
        }
    }

    private int _nbPortions;
    public int NbPortions
    {
        get => _nbPortions;
        set
        {
            if (value <= 0) throw new ArgumentException("Le nombre de portions doit être positif.");
            _nbPortions = value;
        }
    }

    /// <summary>Relation « contient » : lignes de la recette (composition).</summary>
    public List<LigneRecette> Lignes { get; private set; } = new();

    private Recette() { }   // utilisé par EF Core

    public Recette(string nom, int nbPortions)
    {
        Nom = nom;
        NbPortions = nbPortions;
    }

    /// <summary>Ajoute un ingrédient ; s'il est déjà présent, la quantité est cumulée.</summary>
    public void AjouterIngredient(Ingredient ingredient, double quantite)
    {
        var existante = Lignes.FirstOrDefault(l => l.Ingredient == ingredient
                                                   || (ingredient.Id != 0 && l.IngredientId == ingredient.Id));
        if (existante is not null)
        {
            existante.Quantite += quantite;
            return;
        }
        Lignes.Add(new LigneRecette(ingredient, quantite));
    }

    public void SupprimerIngredient(Ingredient ingredient) =>
        Lignes.RemoveAll(l => l.Ingredient == ingredient
                              || (ingredient.Id != 0 && l.IngredientId == ingredient.Id));

    public double CalculerCoutTotal() => Lignes.Sum(l => l.CalculerCout());

    public double CalculerCoutParPortion() => CalculerCoutTotal() / NbPortions;

    public override string ToString() => $"{Nom} ({NbPortions} portions, coût/portion {CalculerCoutParPortion():0.000} DT)";
}
