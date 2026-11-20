namespace GestionMenusRecettes.Models;

/// <summary>Un fournisseur d'ingrédients.</summary>
public class Fournisseur
{
    public int Id { get; private set; }

    private string _nom = string.Empty;
    public string Nom
    {
        get => _nom;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Le nom du fournisseur est obligatoire.");
            _nom = value;
        }
    }

    public string? Telephone { get; private set; }

    /// <summary>Ingrédients fournis par ce fournisseur (relation « est fourni par »).</summary>
    public List<Ingredient> Ingredients { get; private set; } = new();

    private Fournisseur() { }   // utilisé par EF Core

    public Fournisseur(string nom, string? telephone)
    {
        Nom = nom;
        Telephone = telephone;
    }

    public void ModifierTelephone(string? nouveauTelephone) => Telephone = nouveauTelephone;

    public override string ToString() => $"{Nom} ({Telephone})";
}
