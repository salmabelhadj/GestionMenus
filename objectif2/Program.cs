using System.Text;
using GestionMenusRecettes.Models;

namespace GestionMenusRecettes;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        var resto = new Restaurant("Chez Salah");

        // 1. Fournisseur et ingrédients (cas d'utilisation du Chef)
        Titre("1. Fournisseur et ingrédients");
        var f1 = resto.AjouterFournisseur(1, "Marché Central", "71 000 000");
        var pate = resto.AjouterIngredient(1, "Pâte", Unite.Kg, 2.0, 50, f1);
        var tomate = resto.AjouterIngredient(2, "Tomate", Unite.Kg, 3.0, 30, f1);
        var mozza = resto.AjouterIngredient(3, "Mozzarella", Unite.Kg, 18.0, 20, f1);
        var huile = resto.AjouterIngredient(4, "Huile d'olive", Unite.L, 12.0, 10, f1);

        Console.WriteLine($"Fournisseur : {f1}");
        foreach (Ingredient ing in resto.Ingredients)
            Console.WriteLine($"  - {ing}");

        // 2. Recettes
        Titre("2. Recettes");
        var rPizza = resto.CreerRecette(1, "Pizza Margherita", 1);
        rPizza.AjouterIngredient(pate, 0.25);
        rPizza.AjouterIngredient(tomate, 0.10);
        rPizza.AjouterIngredient(mozza, 0.15);

        var rSalade = resto.CreerRecette(2, "Salade de tomates", 1);
        rSalade.AjouterIngredient(tomate, 0.20);
        rSalade.AjouterIngredient(huile, 0.02);

        foreach (Recette r in resto.Recettes)
            Console.WriteLine($"{r.Nom} : coût total {r.CalculerCoutTotal():F2} DT, " +
                              $"coût par portion {r.CalculerCoutParPortion():F2} DT");

        // 3. Plats et menu (cas d'utilisation du Gérant)
        Titre("3. Plats, menu et rapport des marges");
        var pizza = resto.AjouterPlat(1, "Pizza Margherita", Categorie.PlatPrincipal, 12.0, rPizza);
        var salade = resto.AjouterPlat(2, "Salade de tomates", Categorie.Entree, 6.0, rSalade);

        var menu = resto.CreerMenu("Menu du jour");
        menu.AjouterPlat(pizza);
        menu.AjouterPlat(salade);
        menu.AfficherRapport();
        Console.WriteLine($"{pizza.Nom} est de catégorie : {pizza.Categorie}");
        Console.WriteLine($"{salade.Nom} est de catégorie : {salade.Categorie}");

        // 4. Modifications
        Titre("4. Modifications");
        tomate.ModifierPrix(4.0);
        Console.WriteLine("Le prix de la tomate passe à 4,00 DT/Kg. Le rapport est recalculé :");
        menu.AfficherRapport();

        pizza.ModifierPrixVente(14.0);
        Console.WriteLine("\nLe prix de la pizza passe à 14,00 DT :");
        menu.AfficherRapport();

        f1.ModifierTelephone("71 111 111");
        Console.WriteLine($"\nNouveau téléphone : {f1}");

        tomate.Consommer(5);
        tomate.Reapprovisionner(20);
        Console.WriteLine($"Stock de tomate après consommation et réapprovisionnement : {tomate.Stock}");

        // 5. Règles de suppression (on ne supprime pas ce qui est utilisé)
        Titre("5. Règles de suppression");
        Tester("Supprimer la tomate", () => resto.SupprimerIngredient(tomate));
        Tester("Supprimer la recette pizza", () => resto.SupprimerRecette(rPizza));
        Tester("Supprimer le plat pizza", () => resto.SupprimerPlat(pizza));
        Tester("Supprimer le fournisseur", () => resto.SupprimerFournisseur(f1));

        menu.RetirerPlat(pizza);
        resto.SupprimerPlat(pizza);
        resto.SupprimerRecette(rPizza);
        Console.WriteLine($"\nPizza retirée du menu puis supprimée. Il reste {resto.Plats.Count} plat(s) et {resto.Recettes.Count} recette(s).");
        menu.AfficherRapport();

        // 6. Validations
        Titre("6. Validations");
        Tester("Prix négatif", () => tomate.ModifierPrix(-5));
        Tester("Stock insuffisant", () => tomate.Consommer(1000));
        Tester("Ingrédient en double dans une recette", () => rSalade.AjouterIngredient(tomate, 0.5));
        Tester("Recette avec 0 portion", () => resto.CreerRecette(9, "Test", 0));

        Console.WriteLine("\nAppuyez sur une touche pour quitter...");
        if (!Console.IsInputRedirected)
            Console.ReadKey();
    }

    static void Titre(string texte)
    {
        Console.WriteLine();
        Console.WriteLine("########## " + texte + " ##########");
    }

    // Exécute une action et affiche le message d'erreur attendu
    static void Tester(string description, Action action)
    {
        try
        {
            action();
            Console.WriteLine($"[OK]      {description}");
        }
        catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
        {
            Console.WriteLine($"[REFUSÉ]  {description} -> {ex.Message}");
        }
    }
}
