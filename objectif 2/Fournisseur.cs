namespace GestionMenusRecettes.Models;

public class Fournisseur
{
    private int id;
    private string nom;
    private string telephone;

    public Fournisseur(int id, string nom, string telephone)
    {
        if (string.IsNullOrWhiteSpace(nom))
            throw new ArgumentException("Le nom du fournisseur est obligatoire.");
        if (string.IsNullOrWhiteSpace(telephone))
            throw new ArgumentException("Le téléphone est obligatoire.");

        this.id = id;
        this.nom = nom;
        this.telephone = telephone;
    }

    public int Id => id;
    public string Nom => nom;
    public string Telephone => telephone;

    public void ModifierTelephone(string nouveauTelephone)
    {
        if (string.IsNullOrWhiteSpace(nouveauTelephone))
            throw new ArgumentException("Le téléphone est obligatoire.");
        telephone = nouveauTelephone;
    }

    public override string ToString() => $"{nom} ({telephone})";
}
