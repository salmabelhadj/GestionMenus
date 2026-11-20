using System.Windows.Forms;

namespace GestionMenusRecettes.Ui;

/// <summary>
/// Fenêtre principale : un bouton par cas d'utilisation du diagramme
/// (chef cuisinier : ingrédients et recettes ; gérant : fournisseurs, plats, menus, rapport).
/// </summary>
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();   // créé par le concepteur (MainForm.Designer.cs)
    }

    private void Ouvrir(Form fenetre)
    {
        using (fenetre) fenetre.ShowDialog(this);
    }

    private void btnIngredients_Click(object? sender, EventArgs e) => Ouvrir(new IngredientsForm());
    private void btnRecettes_Click(object? sender, EventArgs e) => Ouvrir(new RecettesForm());
    private void btnFournisseurs_Click(object? sender, EventArgs e) => Ouvrir(new FournisseursForm());
    private void btnPlats_Click(object? sender, EventArgs e) => Ouvrir(new PlatsForm());
    private void btnMenus_Click(object? sender, EventArgs e) => Ouvrir(new MenusForm());
    private void btnRapport_Click(object? sender, EventArgs e) => Ouvrir(new RapportForm());
    private void btnQuitter_Click(object? sender, EventArgs e) => Close();
}
