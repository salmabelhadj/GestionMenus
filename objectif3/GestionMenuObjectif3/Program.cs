using GestionMenusRecettes.Data;
using GestionMenusRecettes.Ui;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace GestionMenusRecettes;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        try
        {
            using var db = new RestaurantDbContext();

            // 1) Applique les migrations : crée gestion_menus.db et les tables si besoin
            if (!db.Database.GetMigrations().Any())
            {
                MessageBox.Show(
                    "Aucune migration trouvée.\n\nDans la Console du gestionnaire de package, exécutez :\n" +
                    "Add-Migration InitialCreate\nUpdate-Database\n\npuis relancez l'application.",
                    "Base de données", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            db.Database.Migrate();

            // 2) Premier lancement : données de démonstration
            DonneesInitiales.Remplir(db);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur d'accès à la base de données :\n" + ex.Message,
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Application.Run(new MainForm());
    }
}
