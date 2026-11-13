namespace GestionMenusRecettes.Models;

public class Recette
{
    private int id;
    private string nom;
    private int nbPortions;
    private List<LigneRecette> lignes = new List<LigneRecette>();

    public Recette(int id, string nom, int nbPortions)
    {
        if (string.IsNullOrWhiteSpace(nom))
            throw new ArgumentException("Le nom de la recette est obligatoire.");
        if (nbPortions <= 0)
            throw new ArgumentException("Le nombre de portions doit être positif.");

        this.id = id;
        this.nom = nom;
        this.nbPortions = nbPortions;
    }

    public int Id => id;
    public string Nom => nom;
    public int NbPortions => nbPortions;
    public IReadOnlyList<LigneRecette> Lignes => lignes;

    public void AjouterIngredient(Ingredient ing, double qte)
    {
        ArgumentNullException.ThrowIfNull(ing);
        if (lignes.Any(l => l.Ingredient.Id == ing.Id))
            throw new InvalidOperationException($"{ing.Nom} est déjà dans la recette.");

        lignes.Add(new LigneRecette(ing, qte));   // la recette crée ses lignes (composition)
    }

    public void SupprimerIngredient(Ingredient ing)
    {
        ArgumentNullException.ThrowIfNull(ing);
        lignes.RemoveAll(l => l.Ingredient.Id == ing.Id);
    }

    public double CalculerCoutTotal()
    {
        double total = 0;
        foreach (LigneRecette l in lignes)
            total += l.CalculerCout();
        return total;
    }

    public double CalculerCoutParPortion() => CalculerCoutTotal() / nbPortions;
}

