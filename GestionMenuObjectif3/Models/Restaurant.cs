namespace GestionMenusRecettes.Models;

/// <summary>
/// Classe centrale (comme dans le diagramme de classes) : le restaurant possède ses fournisseurs,
/// ingrédients, recettes, plats et menus (relations 1 - *).
/// </summary>
public class Restaurant
{
    public int Id { get; private set; }

    private string _nom = string.Empty;
    public string Nom
    {
        get => _nom;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Le nom du restaurant est obligatoire.");
            _nom = value;
        }
    }

    public List<Fournisseur> Fournisseurs { get; private set; } = new();
    public List<Ingredient> Ingredients { get; private set; } = new();
    public List<Recette> Recettes { get; private set; } = new();
    public List<Plat> Plats { get; private set; } = new();
    public List<Menu> Menus { get; private set; } = new();

    private Restaurant() { }   // utilisé par EF Core

    public Restaurant(string nom) => Nom = nom;

    public Fournisseur AjouterFournisseur(string nom, string? telephone)
    {
        var f = new Fournisseur(nom, telephone);
        Fournisseurs.Add(f);
        return f;
    }

    public void SupprimerFournisseur(Fournisseur f) => Fournisseurs.Remove(f);

    public Ingredient AjouterIngredient(string nom, Unite unite, double prixUnitaire, double stock, Fournisseur fournisseur)
    {
        var i = new Ingredient(nom, unite, prixUnitaire, stock, fournisseur);
        Ingredients.Add(i);
        return i;
    }

    public void SupprimerIngredient(Ingredient i) => Ingredients.Remove(i);

    public Recette CreerRecette(string nom, int nbPortions)
    {
        var r = new Recette(nom, nbPortions);
        Recettes.Add(r);
        return r;
    }

    public void SupprimerRecette(Recette r) => Recettes.Remove(r);

    public Plat AjouterPlat(string nom, Categorie categorie, double prixVente, Recette recette)
    {
        var p = new Plat(nom, categorie, prixVente, recette);
        Plats.Add(p);
        return p;
    }

    public void SupprimerPlat(Plat p) => Plats.Remove(p);

    public Menu CreerMenu(string nom)
    {
        var m = new Menu(nom);
        Menus.Add(m);
        return m;
    }

    public void SupprimerMenu(Menu m) => Menus.Remove(m);
}
