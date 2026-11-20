namespace GestionMenusRecettes.Ui
{
    partial class FournisseursForm
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
            this.dgvFournisseurs = new System.Windows.Forms.DataGridView();
            this.panelBas = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panelEntete = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseurs)).BeginInit();
            this.panelBas.SuspendLayout();
            this.panelEntete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFournisseurs
            // 
            this.dgvFournisseurs.AllowUserToAddRows = false;
            this.dgvFournisseurs.AllowUserToDeleteRows = false;
            this.dgvFournisseurs.AllowUserToResizeRows = false;
            this.dgvFournisseurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFournisseurs.BackgroundColor = System.Drawing.Color.White;
            this.dgvFournisseurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFournisseurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFournisseurs.MultiSelect = false;
            this.dgvFournisseurs.ReadOnly = true;
            this.dgvFournisseurs.RowHeadersVisible = false;
            this.dgvFournisseurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFournisseurs.Name = "dgvFournisseurs";
            this.dgvFournisseurs.SelectionChanged += new System.EventHandler(this.dgvFournisseurs_SelectionChanged);
            // 
            // panelBas
            // 
            this.panelBas.BackColor = System.Drawing.Color.White;
            this.panelBas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBas.Size = new System.Drawing.Size(100, 130);
            this.panelBas.Name = "panelBas";
            this.panelBas.Controls.Add(this.lblNom);
            this.panelBas.Controls.Add(this.txtNom);
            this.panelBas.Controls.Add(this.lblTelephone);
            this.panelBas.Controls.Add(this.txtTelephone);
            this.panelBas.Controls.Add(this.btnAjouter);
            this.panelBas.Controls.Add(this.btnModifier);
            this.panelBas.Controls.Add(this.btnSupprimer);
            this.panelBas.Controls.Add(this.btnNouveau);
            this.panelBas.Controls.Add(this.btnFermer);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 24);
            this.lblNom.Text = "Nom";
            this.lblNom.Name = "lblNom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(100, 20);
            this.txtNom.Size = new System.Drawing.Size(240, 23);
            this.txtNom.Name = "txtNom";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(365, 24);
            this.lblTelephone.Text = "Téléphone";
            this.lblTelephone.Name = "lblTelephone";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(450, 20);
            this.txtTelephone.Size = new System.Drawing.Size(200, 23);
            this.txtTelephone.Name = "txtTelephone";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(20, 75);
            this.btnAjouter.Size = new System.Drawing.Size(130, 38);
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
            this.btnModifier.Location = new System.Drawing.Point(160, 75);
            this.btnModifier.Size = new System.Drawing.Size(130, 38);
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
            this.btnSupprimer.Location = new System.Drawing.Point(300, 75);
            this.btnSupprimer.Size = new System.Drawing.Size(130, 38);
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
            this.btnNouveau.Location = new System.Drawing.Point(440, 75);
            this.btnNouveau.Size = new System.Drawing.Size(130, 38);
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
            this.btnFermer.Location = new System.Drawing.Point(750, 75);
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
            this.lblTitre.Text = "Gérer les fournisseurs";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitre.Name = "lblTitre";
            // 
            // FournisseursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fournisseurs";
            this.Controls.Add(this.dgvFournisseurs);
            this.Controls.Add(this.panelBas);
            this.Controls.Add(this.panelEntete);
            this.Name = "FournisseursForm";
            this.Load += new System.EventHandler(this.FournisseursForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseurs)).EndInit();
            this.panelBas.ResumeLayout(false);
            this.panelBas.PerformLayout();
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFournisseurs;
        private System.Windows.Forms.Panel panelBas;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Label lblTitre;
    }
}
