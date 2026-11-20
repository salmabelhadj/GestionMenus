namespace GestionMenusRecettes.Ui
{
    partial class PlatsForm
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
            this.dgvPlats = new System.Windows.Forms.DataGridView();
            this.panelBas = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.lblRecette = new System.Windows.Forms.Label();
            this.cmbRecette = new System.Windows.Forms.ComboBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panelEntete = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            this.panelBas.SuspendLayout();
            this.panelEntete.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvPlats.SelectionChanged += new System.EventHandler(this.dgvPlats_SelectionChanged);
            // 
            // panelBas
            // 
            this.panelBas.BackColor = System.Drawing.Color.White;
            this.panelBas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBas.Size = new System.Drawing.Size(100, 160);
            this.panelBas.Name = "panelBas";
            this.panelBas.Controls.Add(this.lblNom);
            this.panelBas.Controls.Add(this.txtNom);
            this.panelBas.Controls.Add(this.lblCategorie);
            this.panelBas.Controls.Add(this.cmbCategorie);
            this.panelBas.Controls.Add(this.lblRecette);
            this.panelBas.Controls.Add(this.cmbRecette);
            this.panelBas.Controls.Add(this.lblPrix);
            this.panelBas.Controls.Add(this.nudPrix);
            this.panelBas.Controls.Add(this.btnAjouter);
            this.panelBas.Controls.Add(this.btnModifier);
            this.panelBas.Controls.Add(this.btnSupprimer);
            this.panelBas.Controls.Add(this.btnNouveau);
            this.panelBas.Controls.Add(this.btnFermer);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 22);
            this.lblNom.Text = "Nom";
            this.lblNom.Name = "lblNom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(100, 18);
            this.txtNom.Size = new System.Drawing.Size(220, 23);
            this.txtNom.Name = "txtNom";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(340, 22);
            this.lblCategorie.Text = "Catégorie";
            this.lblCategorie.Name = "lblCategorie";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(415, 18);
            this.cmbCategorie.Size = new System.Drawing.Size(150, 23);
            this.cmbCategorie.Name = "cmbCategorie";
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.Location = new System.Drawing.Point(585, 22);
            this.lblRecette.Text = "Recette";
            this.lblRecette.Name = "lblRecette";
            // 
            // cmbRecette
            // 
            this.cmbRecette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecette.FormattingEnabled = true;
            this.cmbRecette.Location = new System.Drawing.Point(645, 18);
            this.cmbRecette.Size = new System.Drawing.Size(330, 23);
            this.cmbRecette.Name = "cmbRecette";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(20, 62);
            this.lblPrix.Text = "Prix de vente (DT)";
            this.lblPrix.Name = "lblPrix";
            // 
            // nudPrix
            // 
            this.nudPrix.DecimalPlaces = 3;
            this.nudPrix.Increment = new decimal(new int[] { 1, 0, 0, 65536});
            this.nudPrix.Location = new System.Drawing.Point(140, 58);
            this.nudPrix.Maximum = new decimal(new int[] { 100000, 0, 0, 0});
            this.nudPrix.Size = new System.Drawing.Size(100, 23);
            this.nudPrix.Name = "nudPrix";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(20, 105);
            this.btnAjouter.Size = new System.Drawing.Size(130, 36);
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
            this.btnModifier.Location = new System.Drawing.Point(160, 105);
            this.btnModifier.Size = new System.Drawing.Size(130, 36);
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
            this.btnSupprimer.Location = new System.Drawing.Point(300, 105);
            this.btnSupprimer.Size = new System.Drawing.Size(130, 36);
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
            this.btnNouveau.Location = new System.Drawing.Point(440, 105);
            this.btnNouveau.Size = new System.Drawing.Size(130, 36);
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
            this.btnFermer.Location = new System.Drawing.Point(850, 105);
            this.btnFermer.Size = new System.Drawing.Size(130, 36);
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
            this.lblTitre.Text = "Gérer les plats (gérant)";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitre.Name = "lblTitre";
            // 
            // PlatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plats";
            this.Controls.Add(this.dgvPlats);
            this.Controls.Add(this.panelBas);
            this.Controls.Add(this.panelEntete);
            this.Name = "PlatsForm";
            this.Load += new System.EventHandler(this.PlatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            this.panelBas.ResumeLayout(false);
            this.panelBas.PerformLayout();
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlats;
        private System.Windows.Forms.Panel panelBas;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Label lblRecette;
        private System.Windows.Forms.ComboBox cmbRecette;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.NumericUpDown nudPrix;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Label lblTitre;
    }
}
