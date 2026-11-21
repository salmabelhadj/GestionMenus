using GestionMenusRecettes.Models;

namespace GestionMenusRecettes.Data;

/// <summary>
/// Remplit la base avec des données de démonstration au premier lancement (si la base est vide).
/// </summary>
public static class DonneesInitiales
{
    public static void Remplir(RestaurantDbContext db)
    {
        if (db.Restaurants.Any()) return;

        var resto = new Restaurant("Chez Marie");

        // --- Fournisseurs ---
        var marche = resto.AjouterFournisseur("Marché Central", "71 000 000");
        var grossiste = resto.AjouterFournisseur("Grossiste Épicerie", "71 111 111");

        // --- Ingrédients ---
        var farine = resto.AjouterIngredient("Farine", Unite.Kg, 1.200, 10, grossiste);
        var tomate = resto.AjouterIngredient("Tomate", Unite.Kg, 2.500, 5, marche);
        var mozzarella = resto.AjouterIngredient("Mozzarella", Unite.Kg, 18.000, 0.8, grossiste);
        var huile = resto.AjouterIngredient("Huile d'olive", Unite.L, 15.000, 3, grossiste);
        var poulet = resto.AjouterIngredient("Poulet", Unite.Kg, 12.000, 4, marche);
        var creme = resto.AjouterIngredient("Crème fraîche", Unite.L, 9.000, 1, grossiste);
        var lait = resto.AjouterIngredient("Lait", Unite.L, 1.800, 6, marche);
        var oeufs = resto.AjouterIngredient("Oeufs", Unite.Piece, 0.450, 30, marche);
        var sucre = resto.AjouterIngredient("Sucre", Unite.Kg, 1.500, 5, grossiste);

        // --- Recettes ---
        var pizzaR = resto.CreerRecette("Pâte et garniture pizza", 4);
        pizzaR.AjouterIngredient(farine, 0.5);
        pizzaR.AjouterIngredient(tomate, 0.4);
        pizzaR.AjouterIngredient(mozzarella, 0.3);
        pizzaR.AjouterIngredient(huile, 0.05);

        var pouletR = resto.CreerRecette("Poulet à la crème", 2);
        pouletR.AjouterIngredient(poulet, 0.6);
        pouletR.AjouterIngredient(creme, 0.2);
        pouletR.AjouterIngredient(huile, 0.02);

        var cremeR = resto.CreerRecette("Crème caramel", 6);
        cremeR.AjouterIngredient(lait, 0.75);
        cremeR.AjouterIngredient(oeufs, 4);
        cremeR.AjouterIngredient(sucre, 0.15);

        // --- Plats ---
        resto.AjouterPlat("Pizza Margherita", Categorie.PlatPrincipal, 12.000, pizzaR);
        var pouletCreme = resto.AjouterPlat("Poulet à la crème", Categorie.PlatPrincipal, 18.000, pouletR);
        var cremeCaramel = resto.AjouterPlat("Crème caramel", Categorie.Dessert, 5.000, cremeR);

        // --- Menu ---
        var menuMidi = resto.CreerMenu("Menu du midi");
        menuMidi.AjouterPlat(pouletCreme);
        menuMidi.AjouterPlat(cremeCaramel);

        db.Restaurants.Add(resto);   // enregistre tout le graphe d'objets d'un coup
        db.SaveChanges();
    }
}
