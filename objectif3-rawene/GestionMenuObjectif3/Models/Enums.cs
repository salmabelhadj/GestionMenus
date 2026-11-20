namespace GestionMenusRecettes.Models;

/// <summary>Unité de mesure d'un ingrédient (énumération « unité » du diagramme de classes).</summary>
public enum Unite
{
    Kg,
    G,
    L,
    Ml,
    Piece
}

/// <summary>Catégorie d'un plat (énumération « categorie » du diagramme de classes).</summary>
public enum Categorie
{
    Entree,
    PlatPrincipal,
    Dessert,
    Boisson
}

/// <summary>Textes affichés à l'écran pour les énumérations.</summary>
public static class EnumsExtensions
{
    public static string Symbole(this Unite unite) => unite switch
    {
        Unite.Kg => "kg",
        Unite.G => "g",
        Unite.L => "L",
        Unite.Ml => "mL",
        Unite.Piece => "pièce",
        _ => unite.ToString()
    };

    public static string Libelle(this Categorie c) => c switch
    {
        Categorie.Entree => "Entrée",
        Categorie.PlatPrincipal => "Plat principal",
        Categorie.Dessert => "Dessert",
        Categorie.Boisson => "Boisson",
        _ => c.ToString()
    };
}
