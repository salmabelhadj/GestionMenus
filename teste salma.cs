using System;

public class Class1
{
	public Class1()
	{
	}
}
using System;

public class Etudiant
{
    // Attributs
    public int Numero { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public float Moyenne { get; set; }

    // Constructeur
    public Etudiant(int numero, string nom, string prenom, float moyenne)
    {
        Numero = numero;
        Nom = nom;
        Prenom = prenom;
        Moyenne = moyenne;
    }

    // Méthode pour afficher les informations
    public void Afficher()
    {
        Console.WriteLine("Numero : " + Numero);
        Console.WriteLine("Nom : " + Nom);
        Console.WriteLine("Prenom : " + Prenom);
        Console.WriteLine("Moyenne : " + Moyenne);
    }

    // Méthode pour vérifier la réussite
    public bool EstAdmis()
    {
        return Moyenne >= 10;
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bonjour le oooooo !");
        Console.WriteLine("Bienvenue sur Visual Studio.");

        Console.Write("Quel est votre nom ? : ");
        string nom = Console.ReadLine();

        Console.WriteLine("Bonjour " + nom + " !");

        Console.ReadLine();
    } console.writeline
}
