namespace GestionMenusRecettes.Models;

public class Menu
{
    private string nom;
    private List<Plat> plats = new List<Plat>();

    public Menu(string nom)
    {
        if (string.IsNullOrWhiteSpace(nom))
            throw new ArgumentException("Le nom du menu est obligatoire.");
        this.nom = nom;
    }

    public string Nom => nom;
    public IReadOnlyList<Plat> Plats => plats;

    public void AjouterPlat(Plat p)
    {
        ArgumentNullException.ThrowIfNull(p);
        if (plats.Contains(p))
            throw new InvalidOperationException($"{p.Nom} est déjà dans le menu.");
        plats.Add(p);
    }

    public void RetirerPlat(Plat p) => plats.Remove(p);

    public double CalculerCoutTotal()
    {
        double total = 0;
        foreach (Plat p in plats)
            total += p.CalculerCout();
        return total;
    }

    // Marge obtenue si on vend UNE portion de chaque plat du menu
    public double CalculerMargeTotale()
    {
        double total = 0;
        foreach (Plat p in plats)
            total += p.CalculerMarge();
        return total;
    }

    public void AfficherRapport()
    {
        Console.WriteLine($"===== MENU : {nom} =====");
        if (plats.Count == 0)
        {
            Console.WriteLine("(menu vide)");
            return;
        }

        Console.WriteLine("Plat".PadRight(20) + "Coût".PadLeft(8) + "Prix".PadLeft(8) +
                          "Marge".PadLeft(8) + "T.marge%".PadLeft(10) +
                          "T.marque%".PadLeft(10) + "Coef".PadLeft(7));
        foreach (Plat p in plats)
        {
            Console.WriteLine(
                $"{p.Nom,-20}{p.CalculerCout(),8:F2}{p.PrixVente,8:F2}{p.CalculerMarge(),8:F2}" +
                $"{p.CalculerTauxMarge(),10:F1}{p.CalculerTauxMarque(),10:F1}{p.CalculerCoefficient(),7:F2}");
        }
        Console.WriteLine($"TOTAL coût : {CalculerCoutTotal():F2} DT | TOTAL marge : {CalculerMargeTotale():F2} DT");
    }
}

