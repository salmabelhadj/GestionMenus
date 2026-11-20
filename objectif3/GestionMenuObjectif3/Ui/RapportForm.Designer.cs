namespace GestionMenusRecettes.Ui
{
    partial class RapportForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPlats = new System.Windows.Forms.TabPage();
            this.dgvPlats = new System.Windows.Forms.DataGridView();
            this.tabMenus = new System.Windows.Forms.TabPage();
            this.dgvMenus = new System.Windows.Forms.DataGridView();
            this.tabRapport = new System.Windows.Forms.TabPage();
            this.txtRapport = new System.Windows.Forms.TextBox();
            this.panelBas = new System.Windows.Forms.Panel();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panelEntete = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPlats.SuspendLayout();
            this.tabMenus.SuspendLayout();
            this.tabRapport.SuspendLayout();
            this.panelBas.SuspendLayout();
            this.panelEntete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 56);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 520);
            this.tabControl.Name = "tabControl";
            this.tabControl.Controls.Add(this.tabPlats);
            this.tabControl.Controls.Add(this.tabMenus);
            this.tabControl.Controls.Add(this.tabRapport);
            // 
            // tabPlats
            // 
            this.tabPlats.Location = new System.Drawing.Point(4, 24);
            this.tabPlats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlats.Size = new System.Drawing.Size(992, 540);
            this.tabPlats.Text = "Coût et marge des plats";
            this.tabPlats.UseVisualStyleBackColor = true;
            this.tabPlats.Name = "tabPlats";
            this.tabPlats.Controls.Add(this.dgvPlats);
            // 
            // dgvPlats
            // 
            this.dgvPlats.AllowUserToAddRows = false;
            this.dgvPlats.AllowUserToDeleteRows = false;
            this.dgvPlats.AllowUserToResizeRows = false;
            this.dgvPlats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlats.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlats.MultiSelect = false;
            this.dgvPlats.ReadOnly = true;
            this.dgvPlats.RowHeadersVisible = false;
            this.dgvPlats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlats.Name = "dgvPlats";
            // 
            // tabMenus
            // 
            this.tabMenus.Location = new System.Drawing.Point(4, 24);
            this.tabMenus.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenus.Size = new System.Drawing.Size(992, 540);
            this.tabMenus.Text = "Marge des menus";
            this.tabMenus.UseVisualStyleBackColor = true;
            this.tabMenus.Name = "tabMenus";
            this.tabMenus.Controls.Add(this.dgvMenus);
            // 
            // dgvMenus
            // 
            this.dgvMenus.AllowUserToAddRows = false;
            this.dgvMenus.AllowUserToDeleteRows = false;
            this.dgvMenus.AllowUserToResizeRows = false;
            this.dgvMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenus.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenus.MultiSelect = false;
            this.dgvMenus.ReadOnly = true;
            this.dgvMenus.RowHeadersVisible = false;
            this.dgvMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenus.Name = "dgvMenus";
            // 
            // tabRapport
            // 
            this.tabRapport.Location = new System.Drawing.Point(4, 24);
            this.tabRapport.Padding = new System.Windows.Forms.Padding(3);
            this.tabRapport.Size = new System.Drawing.Size(992, 540);
            this.tabRapport.Text = "Rapport";
            this.tabRapport.UseVisualStyleBackColor = true;
            this.tabRapport.Name = "tabRapport";
            this.tabRapport.Controls.Add(this.txtRapport);
            // 
            // txtRapport
            // 
            this.txtRapport.BackColor = System.Drawing.Color.White;
            this.txtRapport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRapport.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRapport.Multiline = true;
            this.txtRapport.ReadOnly = true;
            this.txtRapport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRapport.Name = "txtRapport";
            // 
            // panelBas
            // 
            this.panelBas.BackColor = System.Drawing.Color.White;
            this.panelBas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBas.Size = new System.Drawing.Size(100, 56);
            this.panelBas.Name = "panelBas";
            this.panelBas.Controls.Add(this.btnActualiser);
            this.panelBas.Controls.Add(this.btnFermer);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnActualiser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.FlatAppearance.BorderSize = 0;
            this.btnActualiser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.ForeColor = System.Drawing.Color.White;
            this.btnActualiser.Location = new System.Drawing.Point(20, 9);
            this.btnActualiser.Size = new System.Drawing.Size(130, 38);
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(850, 9);
            this.btnFermer.Size = new System.Drawing.Size(130, 38);
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // panelEntete
            // 
            this.panelEntete.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.panelEntete.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEntete.Size = new System.Drawing.Size(100, 56);
            this.panelEntete.Name = "panelEntete";
            this.panelEntete.Controls.Add(this.lblTitre);
            // 
            // lblTitre
            // 
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitre.Text = "Consulter le rapport (gérant)";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitre.Name = "lblTitre";
            // 
            // RapportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapport";
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelBas);
            this.Controls.Add(this.panelEntete);
            this.Name = "RapportForm";
            this.Load += new System.EventHandler(this.RapportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPlats.ResumeLayout(false);
            this.tabMenus.ResumeLayout(false);
            this.tabRapport.ResumeLayout(false);
            this.panelBas.ResumeLayout(false);
            this.panelBas.PerformLayout();
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPlats;
        private System.Windows.Forms.DataGridView dgvPlats;
        private System.Windows.Forms.TabPage tabMenus;
        private System.Windows.Forms.DataGridView dgvMenus;
        private System.Windows.Forms.TabPage tabRapport;
        private System.Windows.Forms.TextBox txtRapport;
        private System.Windows.Forms.Panel panelBas;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Label lblTitre;
    }
}
