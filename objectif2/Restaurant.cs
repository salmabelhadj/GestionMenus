namespace GestionMenusRecettes.Models;

// Classe de gestion : possède et gère tout le catalogue (composition)
public class Restaurant
{
    private string nom;
    private List<Fournisseur> fournisseurs = new List<Fournisseur>();
    private List<Ingredient> ingredients = new List<Ingredient>();
    private List<Recette> recettes = new List<Recette>();
    private List<Plat> plats = new List<Plat>();
    private List<Menu> menus = new List<Menu>();

    public Restaurant(string nom)
    {
        if (string.IsNullOrWhiteSpace(nom))
            throw new ArgumentException("Le nom du restaurant est obligatoire.");
        this.nom = nom;
    }

    public string Nom => nom;
    public IReadOnlyList<Fournisseur> Fournisseurs => fournisseurs;
    public IReadOnlyList<Ingredient> Ingredients => ingredients;
    public IReadOnlyList<Recette> Recettes => recettes;
    public IReadOnlyList<Plat> Plats => plats;
    public IReadOnlyList<Menu> Menus => menus;

    // ---------- Fournisseurs ----------
    public Fournisseur AjouterFournisseur(int id, string nom, string telephone)
    {
        if (fournisseurs.Any(x => x.Id == id))
            throw new InvalidOperationException($"Le fournisseur {id} existe déjà.");

        var nouveau = new Fournisseur(id, nom, telephone);
        fournisseurs.Add(nouveau);
        return nouveau;
    }

    public void SupprimerFournisseur(Fournisseur f)
    {
        ArgumentNullException.ThrowIfNull(f);
        if (ingredients.Any(i => i.Fournisseur.Id == f.Id))
            throw new InvalidOperationException($"{f.Nom} fournit encore des ingrédients.");
        fournisseurs.Remove(f);
    }

    // ---------- Ingrédients ----------
    public Ingredient AjouterIngredient(int id, string nom, Unite unite,
                                        double prix, double stock, Fournisseur fournisseur)
    {
        ArgumentNullException.ThrowIfNull(fournisseur);
        if (!fournisseurs.Contains(fournisseur))
            throw new InvalidOperationException("Ce fournisseur n'appartient pas au restaurant.");
        if (ingredients.Any(x => x.Id == id))
            throw new InvalidOperationException($"L'ingrédient {id} existe déjà.");

        var nouveau = new Ingredient(id, nom, unite, prix, stock, fournisseur);
        ingredients.Add(nouveau);
        return nouveau;
    }

    public void SupprimerIngredient(Ingredient i)
    {
        ArgumentNullException.ThrowIfNull(i);
        if (recettes.Any(r => r.Lignes.Any(l => l.Ingredient.Id == i.Id)))
            throw new InvalidOperationException($"{i.Nom} est utilisé dans une recette.");
        ingredients.Remove(i);
    }

    // ---------- Recettes ----------
    public Recette CreerRecette(int id, string nom, int nbPortions)
    {
        if (recettes.Any(x => x.Id == id))
            throw new InvalidOperationException($"La recette {id} existe déjà.");

        var nouvelle = new Recette(id, nom, nbPortions);
        recettes.Add(nouvelle);
        return nouvelle;
    }

    public void SupprimerRecette(Recette r)
    {
        ArgumentNullException.ThrowIfNull(r);
        if (plats.Any(p => p.Recette.Id == r.Id))
            throw new InvalidOperationException($"{r.Nom} est utilisée par un plat.");
        recettes.Remove(r);
    }

    // ---------- Plats ----------
    public Plat AjouterPlat(int id, string nom, Categorie categorie,
                            double prixVente, Recette recette)
    {
        ArgumentNullException.ThrowIfNull(recette);
        if (!recettes.Contains(recette))
            throw new InvalidOperationException("Cette recette n'appartient pas au restaurant.");
        if (plats.Any(x => x.Id == id))
            throw new InvalidOperationException($"Le plat {id} existe déjà.");

        var nouveau = new Plat(id, nom, categorie, prixVente, recette);
        plats.Add(nouveau);
        return nouveau;
    }

    public void SupprimerPlat(Plat p)
    {
        ArgumentNullException.ThrowIfNull(p);
        if (menus.Any(m => m.Plats.Contains(p)))
            throw new InvalidOperationException($"{p.Nom} figure dans un menu. Retirez-le d'abord.");
        plats.Remove(p);
    }

    // ---------- Menus ----------
    public Menu CreerMenu(string nom)
    {
        if (menus.Any(x => x.Nom.Equals(nom, StringComparison.OrdinalIgnoreCase)))
            throw new InvalidOperationException($"Le menu « {nom} » existe déjà.");

        var nouveau = new Menu(nom);
        menus.Add(nouveau);
        return nouveau;
    }

    public void SupprimerMenu(Menu m)
    {
        ArgumentNullException.ThrowIfNull(m);
        menus.Remove(m);
    }
}

