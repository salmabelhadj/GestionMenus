using System.Drawing;
using System.Windows.Forms;

namespace GestionMenusRecettes.Ui;

/// <summary>Élément d'une liste déroulante : un identifiant et le texte affiché.</summary>
public sealed record Choix(int Id, string Texte);

/// <summary>Style commun des tableaux, fenêtres de message et petites aides pour les formulaires.</summary>
public static class Theme
{
    public static readonly Color Primaire = Color.FromArgb(31, 78, 121);
    public static readonly Color Accent = Color.FromArgb(46, 117, 182);

    /// <summary>
    /// Donne le même look à tous les tableaux (DataGridView) : en-tête bleu, lignes alternées,
    /// colonne « Id » masquée, nombres à 3 décimales. Appelée dans le constructeur de chaque formulaire.
    /// </summary>
    public static void Grille(DataGridView g)
    {
        g.Font = new Font("Segoe UI", 10f);
        g.RowTemplate.Height = 28;

        g.EnableHeadersVisualStyles = false;
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        g.ColumnHeadersHeight = 36;
        g.ColumnHeadersDefaultCellStyle.BackColor = Primaire;
        g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
        g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 250);
        g.DefaultCellStyle.SelectionBackColor = Accent;
        g.DefaultCellStyle.SelectionForeColor = Color.White;

        g.DataBindingComplete += (s, e) =>
        {
            foreach (DataGridViewColumn c in g.Columns)
            {
                if (c.Name.EndsWith("Id")) c.Visible = false;   // Id, FournisseurId, RecetteId...
                if (c.ValueType == typeof(double))
                {
                    c.DefaultCellStyle.Format = "N3";
                    c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        };
    }

    /// <summary>Id de la ligne sélectionnée (colonne « Id » masquée) ou null.</summary>
    public static int? IdSelectionne(DataGridView g) =>
        g.CurrentRow is not null && g.CurrentRow.Cells["Id"].Value is int id ? id : null;

    /// <summary>Resélectionne la ligne portant cet Id (après un rafraîchissement).</summary>
    public static void Selectionner(DataGridView g, int id, string colonneVisible)
    {
        foreach (DataGridViewRow ligne in g.Rows)
        {
            if (ligne.Cells["Id"].Value is int v && v == id)
            {
                g.CurrentCell = ligne.Cells[colonneVisible];
                ligne.Selected = true;
                return;
            }
        }
    }

    public static void Deselectionner(DataGridView g)
    {
        g.ClearSelection();
        g.CurrentCell = null;
    }

    public static void Info(string message) =>
        MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

    public static void Erreur(string message) =>
        MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

    public static bool Confirmer(string message) =>
        MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
}
