namespace GestionMenusRecettes.Ui
{
    partial class IngredientsForm
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
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.panelBas = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblUnite = new System.Windows.Forms.Label();
            this.cmbUnite = new System.Windows.Forms.ComboBox();
            this.lblFournisseur = new System.Windows.Forms.Label();
            this.cmbFournisseur = new System.Windows.Forms.ComboBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.btnConsommer = new System.Windows.Forms.Button();
            this.btnReapprovisionner = new System.Windows.Forms.Button();
            this.panelEntete = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.panelBas.SuspendLayout();
            this.panelEntete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            this.dgvIngredients.AllowUserToDeleteRows = false;
            this.dgvIngredients.AllowUserToResizeRows = false;
            this.dgvIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredients.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngredients.MultiSelect = false;
            this.dgvIngredients.ReadOnly = true;
            this.dgvIngredients.RowHeadersVisible = false;
            this.dgvIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.SelectionChanged += new System.EventHandler(this.dgvIngredients_SelectionChanged);
            // 
            // panelBas
            // 
            this.panelBas.BackColor = System.Drawing.Color.White;
            this.panelBas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBas.Size = new System.Drawing.Size(100, 210);
            this.panelBas.Name = "panelBas";
            this.panelBas.Controls.Add(this.lblNom);
            this.panelBas.Controls.Add(this.txtNom);
            this.panelBas.Controls.Add(this.lblUnite);
            this.panelBas.Controls.Add(this.cmbUnite);
            this.panelBas.Controls.Add(this.lblFournisseur);
            this.panelBas.Controls.Add(this.cmbFournisseur);
            this.panelBas.Controls.Add(this.lblPrix);
            this.panelBas.Controls.Add(this.nudPrix);
            this.panelBas.Controls.Add(this.lblStock);
            this.panelBas.Controls.Add(this.nudStock);
            this.panelBas.Controls.Add(this.btnAjouter);
            this.panelBas.Controls.Add(this.btnModifier);
            this.panelBas.Controls.Add(this.btnSupprimer);
            this.panelBas.Controls.Add(this.btnNouveau);
            this.panelBas.Controls.Add(this.btnFermer);
            this.panelBas.Controls.Add(this.lblQuantite);
            this.panelBas.Controls.Add(this.nudQuantite);
            this.panelBas.Controls.Add(this.btnConsommer);
            this.panelBas.Controls.Add(this.btnReapprovisionner);
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
            this.txtNom.Size = new System.Drawing.Size(190, 23);
            this.txtNom.Name = "txtNom";
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Location = new System.Drawing.Point(310, 22);
            this.lblUnite.Text = "Unité";
            this.lblUnite.Name = "lblUnite";
            // 
            // cmbUnite
            // 
            this.cmbUnite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnite.FormattingEnabled = true;
            this.cmbUnite.Location = new System.Drawing.Point(360, 18);
            this.cmbUnite.Size = new System.Drawing.Size(90, 23);
            this.cmbUnite.Name = "cmbUnite";
            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.Location = new System.Drawing.Point(470, 22);
            this.lblFournisseur.Text = "Fournisseur";
            this.lblFournisseur.Name = "lblFournisseur";
            // 
            // cmbFournisseur
            // 
            this.cmbFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFournisseur.FormattingEnabled = true;
            this.cmbFournisseur.Location = new System.Drawing.Point(555, 18);
            this.cmbFournisseur.Size = new System.Drawing.Size(220, 23);
            this.cmbFournisseur.Name = "cmbFournisseur";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(20, 62);
            this.lblPrix.Text = "Prix unitaire (DT)";
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
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(260, 62);
            this.lblStock.Text = "Stock initial";
            this.lblStock.Name = "lblStock";
            // 
            // nudStock
            // 
            this.nudStock.DecimalPlaces = 3;
            this.nudStock.Increment = new decimal(new int[] { 1, 0, 0, 65536});
            this.nudStock.Location = new System.Drawing.Point(345, 58);
            this.nudStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0});
            this.nudStock.Size = new System.Drawing.Size(100, 23);
            this.nudStock.Name = "nudStock";
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
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(20, 164);
            this.lblQuantite.Text = "Quantité";
            this.lblQuantite.Name = "lblQuantite";
            // 
            // nudQuantite
            // 
            this.nudQuantite.DecimalPlaces = 3;
            this.nudQuantite.Increment = new decimal(new int[] { 1, 0, 0, 65536});
            this.nudQuantite.Location = new System.Drawing.Point(85, 160);
            this.nudQuantite.Maximum = new decimal(new int[] { 100000, 0, 0, 0});
            this.nudQuantite.Size = new System.Drawing.Size(100, 23);
            this.nudQuantite.Name = "nudQuantite";
            // 
            // btnConsommer
            // 
            this.btnConsommer.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnConsommer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsommer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsommer.FlatAppearance.BorderSize = 0;
            this.btnConsommer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsommer.ForeColor = System.Drawing.Color.White;
            this.btnConsommer.Location = new System.Drawing.Point(205, 156);
            this.btnConsommer.Size = new System.Drawing.Size(150, 36);
            this.btnConsommer.Text = "Consommer (-)";
            this.btnConsommer.UseVisualStyleBackColor = false;
            this.btnConsommer.Name = "btnConsommer";
            this.btnConsommer.Click += new System.EventHandler(this.btnConsommer_Click);
            // 
            // btnReapprovisionner
            // 
            this.btnReapprovisionner.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
            this.btnReapprovisionner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReapprovisionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReapprovisionner.FlatAppearance.BorderSize = 0;
            this.btnReapprovisionner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReapprovisionner.ForeColor = System.Drawing.Color.White;
            this.btnReapprovisionner.Location = new System.Drawing.Point(365, 156);
            this.btnReapprovisionner.Size = new System.Drawing.Size(190, 36);
            this.btnReapprovisionner.Text = "Réapprovisionner (+)";
            this.btnReapprovisionner.UseVisualStyleBackColor = false;
            this.btnReapprovisionner.Name = "btnReapprovisionner";
            this.btnReapprovisionner.Click += new System.EventHandler(this.btnReapprovisionner_Click);
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
            this.lblTitre.Text = "Gérer les ingrédients (chef cuisinier)";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitre.Name = "lblTitre";
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrédients";
            this.Controls.Add(this.dgvIngredients);
            this.Controls.Add(this.panelBas);
            this.Controls.Add(this.panelEntete);
            this.Name = "IngredientsForm";
            this.Load += new System.EventHandler(this.IngredientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.panelBas.ResumeLayout(false);
            this.panelBas.PerformLayout();
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.Panel panelBas;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblUnite;
        private System.Windows.Forms.ComboBox cmbUnite;
        private System.Windows.Forms.Label lblFournisseur;
        private System.Windows.Forms.ComboBox cmbFournisseur;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.NumericUpDown nudPrix;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.Button btnConsommer;
        private System.Windows.Forms.Button btnReapprovisionner;
        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Label lblTitre;
    }
}
