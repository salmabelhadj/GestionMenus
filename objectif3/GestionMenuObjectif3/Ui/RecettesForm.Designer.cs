namespace GestionMenusRecettes.Ui
{
    partial class RecettesForm
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
            this.panelLignes = new System.Windows.Forms.Panel();
            this.dgvLignes = new System.Windows.Forms.DataGridView();
            this.panelChampsLignes = new System.Windows.Forms.Panel();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.cmbIngredient = new System.Windows.Forms.ComboBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.btnAjouterLigne = new System.Windows.Forms.Button();
            this.btnRetirerLigne = new System.Windows.Forms.Button();
            this.lblLignes = new System.Windows.Forms.Label();
            this.panelRecette = new System.Windows.Forms.Panel();
            this.dgvRecettes = new System.Windows.Forms.DataGridView();
            this.panelChampsRecette = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPortions = new System.Windows.Forms.Label();
            this.nudPortions = new System.Windows.Forms.NumericUpDown();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panelEntete = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecettes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortions)).BeginInit();
            this.panelLignes.SuspendLayout();
            this.panelChampsLignes.SuspendLayout();
            this.panelRecette.SuspendLayout();
            this.panelChampsRecette.SuspendLayout();
            this.panelEntete.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLignes
            // 
            this.panelLignes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLignes.Size = new System.Drawing.Size(100, 100);
            this.panelLignes.Name = "panelLignes";
            this.panelLignes.Controls.Add(this.dgvLignes);
            this.panelLignes.Controls.Add(this.panelChampsLignes);
            this.panelLignes.Controls.Add(this.lblLignes);
            // 
            // dgvLignes
            // 
            this.dgvLignes.AllowUserToAddRows = false;
            this.dgvLignes.AllowUserToDeleteRows = false;
            this.dgvLignes.AllowUserToResizeRows = false;
            this.dgvLignes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLignes.BackgroundColor = System.Drawing.Color.White;
            this.dgvLignes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLignes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLignes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLignes.MultiSelect = false;
            this.dgvLignes.ReadOnly = true;
            this.dgvLignes.RowHeadersVisible = false;
            this.dgvLignes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLignes.Name = "dgvLignes";
            // 
            // panelChampsLignes
            // 
            this.panelChampsLignes.BackColor = System.Drawing.Color.White;
            this.panelChampsLignes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChampsLignes.Size = new System.Drawing.Size(100, 70);
            this.panelChampsLignes.Name = "panelChampsLignes";
            this.panelChampsLignes.Controls.Add(this.lblIngredient);
            this.panelChampsLignes.Controls.Add(this.cmbIngredient);
            this.panelChampsLignes.Controls.Add(this.lblQuantite);
            this.panelChampsLignes.Controls.Add(this.nudQuantite);
            this.panelChampsLignes.Controls.Add(this.btnAjouterLigne);
            this.panelChampsLignes.Controls.Add(this.btnRetirerLigne);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(20, 26);
            this.lblIngredient.Text = "Ingrédient";
            this.lblIngredient.Name = "lblIngredient";
            // 
            // cmbIngredient
            // 
            this.cmbIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngredient.FormattingEnabled = true;
            this.cmbIngredient.Location = new System.Drawing.Point(100, 22);
            this.cmbIngredient.Size = new System.Drawing.Size(230, 23);
            this.cmbIngredient.Name = "cmbIngredient";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(350, 26);
            this.lblQuantite.Text = "Quantité";
            this.lblQuantite.Name = "lblQuantite";
            // 
            // nudQuantite
            // 
            this.nudQuantite.DecimalPlaces = 3;
            this.nudQuantite.Increment = new decimal(new int[] { 1, 0, 0, 65536});
            this.nudQuantite.Location = new System.Drawing.Point(420, 22);
            this.nudQuantite.Maximum = new decimal(new int[] { 100000, 0, 0, 0});
            this.nudQuantite.Size = new System.Drawing.Size(100, 23);
            this.nudQuantite.Name = "nudQuantite";
            // 
            // btnAjouterLigne
            // 
            this.btnAjouterLigne.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
            this.btnAjouterLigne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterLigne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterLigne.FlatAppearance.BorderSize = 0;
            this.btnAjouterLigne.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterLigne.ForeColor = System.Drawing.Color.White;
            this.btnAjouterLigne.Location = new System.Drawing.Point(540, 18);
            this.btnAjouterLigne.Size = new System.Drawing.Size(200, 36);
            this.btnAjouterLigne.Text = "Ajouter à la recette";
            this.btnAjouterLigne.UseVisualStyleBackColor = false;
            this.btnAjouterLigne.Name = "btnAjouterLigne";
            this.btnAjouterLigne.Click += new System.EventHandler(this.btnAjouterLigne_Click);
            // 
            // btnRetirerLigne
            // 
            this.btnRetirerLigne.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnRetirerLigne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirerLigne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirerLigne.FlatAppearance.BorderSize = 0;
            this.btnRetirerLigne.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirerLigne.ForeColor = System.Drawing.Color.White;
            this.btnRetirerLigne.Location = new System.Drawing.Point(750, 18);
            this.btnRetirerLigne.Size = new System.Drawing.Size(200, 36);
            this.btnRetirerLigne.Text = "Retirer de la recette";
            this.btnRetirerLigne.UseVisualStyleBackColor = false;
            this.btnRetirerLigne.Name = "btnRetirerLigne";
            this.btnRetirerLigne.Click += new System.EventHandler(this.btnRetirerLigne_Click);
            // 
            // lblLignes
            // 
            this.lblLignes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLignes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLignes.Size = new System.Drawing.Size(100, 30);
            this.lblLignes.Text = "  Ingrédients de la recette sélectionnée";
            this.lblLignes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLignes.Name = "lblLignes";
            // 
            // panelRecette
            // 
            this.panelRecette.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecette.Size = new System.Drawing.Size(100, 330);
            this.panelRecette.Name = "panelRecette";
            this.panelRecette.Controls.Add(this.dgvRecettes);
            this.panelRecette.Controls.Add(this.panelChampsRecette);
            // 
            // dgvRecettes
            // 
            this.dgvRecettes.AllowUserToAddRows = false;
            this.dgvRecettes.AllowUserToDeleteRows = false;
            this.dgvRecettes.AllowUserToResizeRows = false;
            this.dgvRecettes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecettes.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecettes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecettes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecettes.MultiSelect = false;
            this.dgvRecettes.ReadOnly = true;
            this.dgvRecettes.RowHeadersVisible = false;
            this.dgvRecettes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecettes.Name = "dgvRecettes";
            this.dgvRecettes.SelectionChanged += new System.EventHandler(this.dgvRecettes_SelectionChanged);
            // 
            // panelChampsRecette
            // 
            this.panelChampsRecette.BackColor = System.Drawing.Color.White;
            this.panelChampsRecette.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChampsRecette.Size = new System.Drawing.Size(100, 80);
            this.panelChampsRecette.Name = "panelChampsRecette";
            this.panelChampsRecette.Controls.Add(this.lblNom);
            this.panelChampsRecette.Controls.Add(this.txtNom);
            this.panelChampsRecette.Controls.Add(this.lblPortions);
            this.panelChampsRecette.Controls.Add(this.nudPortions);
            this.panelChampsRecette.Controls.Add(this.btnAjouter);
            this.panelChampsRecette.Controls.Add(this.btnModifier);
            this.panelChampsRecette.Controls.Add(this.btnSupprimer);
            this.panelChampsRecette.Controls.Add(this.btnNouveau);
            this.panelChampsRecette.Controls.Add(this.btnFermer);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 30);
            this.lblNom.Text = "Nom";
            this.lblNom.Name = "lblNom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(70, 26);
            this.txtNom.Size = new System.Drawing.Size(180, 23);
            this.txtNom.Name = "txtNom";
            // 
            // lblPortions
            // 
            this.lblPortions.AutoSize = true;
            this.lblPortions.Location = new System.Drawing.Point(265, 30);
            this.lblPortions.Text = "Portions";
            this.lblPortions.Name = "lblPortions";
            // 
            // nudPortions
            // 
            this.nudPortions.Location = new System.Drawing.Point(330, 26);
            this.nudPortions.Maximum = new decimal(new int[] { 1000, 0, 0, 0});
            this.nudPortions.Minimum = new decimal(new int[] { 1, 0, 0, 0});
            this.nudPortions.Size = new System.Drawing.Size(60, 23);
            this.nudPortions.Value = new decimal(new int[] { 1, 0, 0, 0});
            this.nudPortions.Name = "nudPortions";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(410, 22);
            this.btnAjouter.Size = new System.Drawing.Size(105, 36);
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(525, 22);
            this.btnModifier.Size = new System.Drawing.Size(105, 36);
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(640, 22);
            this.btnSupprimer.Size = new System.Drawing.Size(105, 36);
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveau.FlatAppearance.BorderSize = 0;
            this.btnNouveau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.ForeColor = System.Drawing.Color.White;
            this.btnNouveau.Location = new System.Drawing.Point(755, 22);
            this.btnNouveau.Size = new System.Drawing.Size(105, 36);
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(870, 22);
            this.btnFermer.Size = new System.Drawing.Size(110, 36);
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
            this.lblTitre.Text = "Gérer les recettes (chef cuisinier)";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitre.Name = "lblTitre";
            // 
            // RecettesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1000, 760);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recettes";
            this.Controls.Add(this.panelLignes);
            this.Controls.Add(this.panelRecette);
            this.Controls.Add(this.panelEntete);
            this.Name = "RecettesForm";
            this.Load += new System.EventHandler(this.RecettesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecettes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortions)).EndInit();
            this.panelLignes.ResumeLayout(false);
            this.panelLignes.PerformLayout();
            this.panelChampsLignes.ResumeLayout(false);
            this.panelChampsLignes.PerformLayout();
            this.panelRecette.ResumeLayout(false);
            this.panelRecette.PerformLayout();
            this.panelChampsRecette.ResumeLayout(false);
            this.panelChampsRecette.PerformLayout();
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLignes;
        private System.Windows.Forms.DataGridView dgvLignes;
        private System.Windows.Forms.Panel panelChampsLignes;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.ComboBox cmbIngredient;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.Button btnAjouterLigne;
        private System.Windows.Forms.Button btnRetirerLigne;
        private System.Windows.Forms.Label lblLignes;
        private System.Windows.Forms.Panel panelRecette;
        private System.Windows.Forms.DataGridView dgvRecettes;
        private System.Windows.Forms.Panel panelChampsRecette;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPortions;
        private System.Windows.Forms.NumericUpDown nudPortions;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Label lblTitre;
    }
}
