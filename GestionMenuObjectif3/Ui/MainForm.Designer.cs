namespace GestionMenusRecettes.Ui
{
    partial class MainForm
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
            this.panelEntete = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.lblChef = new System.Windows.Forms.Label();
            this.btnIngredients = new System.Windows.Forms.Button();
            this.btnRecettes = new System.Windows.Forms.Button();
            this.lblGerant = new System.Windows.Forms.Label();
            this.btnFournisseurs = new System.Windows.Forms.Button();
            this.btnPlats = new System.Windows.Forms.Button();
            this.btnMenus = new System.Windows.Forms.Button();
            this.btnRapport = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panelEntete.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEntete
            // 
            this.panelEntete.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.panelEntete.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEntete.Size = new System.Drawing.Size(900, 90);
            this.panelEntete.Name = "panelEntete";
            this.panelEntete.Controls.Add(this.lblTitre);
            this.panelEntete.Controls.Add(this.lblSousTitre);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(20, 12);
            this.lblTitre.Text = "Gestion des menus et recettes";
            this.lblTitre.Name = "lblTitre";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.ForeColor = System.Drawing.Color.White;
            this.lblSousTitre.Location = new System.Drawing.Point(22, 56);
            this.lblSousTitre.Text = "Restaurant : ingrédients, recettes, plats, menus et marges";
            this.lblSousTitre.Name = "lblSousTitre";
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChef.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblChef.Location = new System.Drawing.Point(60, 110);
            this.lblChef.Text = "Chef cuisinier";
            this.lblChef.Name = "lblChef";
            // 
            // btnIngredients
            // 
            this.btnIngredients.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnIngredients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngredients.FlatAppearance.BorderSize = 0;
            this.btnIngredients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredients.ForeColor = System.Drawing.Color.White;
            this.btnIngredients.Location = new System.Drawing.Point(60, 145);
            this.btnIngredients.Size = new System.Drawing.Size(360, 70);
            this.btnIngredients.Text = "Gérer les ingrédients";
            this.btnIngredients.UseVisualStyleBackColor = false;
            this.btnIngredients.Name = "btnIngredients";
            this.btnIngredients.Click += new System.EventHandler(this.btnIngredients_Click);
            // 
            // btnRecettes
            // 
            this.btnRecettes.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnRecettes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecettes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecettes.FlatAppearance.BorderSize = 0;
            this.btnRecettes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecettes.ForeColor = System.Drawing.Color.White;
            this.btnRecettes.Location = new System.Drawing.Point(60, 230);
            this.btnRecettes.Size = new System.Drawing.Size(360, 70);
            this.btnRecettes.Text = "Gérer les recettes";
            this.btnRecettes.UseVisualStyleBackColor = false;
            this.btnRecettes.Name = "btnRecettes";
            this.btnRecettes.Click += new System.EventHandler(this.btnRecettes_Click);
            // 
            // lblGerant
            // 
            this.lblGerant.AutoSize = true;
            this.lblGerant.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerant.ForeColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.lblGerant.Location = new System.Drawing.Point(480, 110);
            this.lblGerant.Text = "Gérant";
            this.lblGerant.Name = "lblGerant";
            // 
            // btnFournisseurs
            // 
            this.btnFournisseurs.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnFournisseurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFournisseurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFournisseurs.FlatAppearance.BorderSize = 0;
            this.btnFournisseurs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFournisseurs.ForeColor = System.Drawing.Color.White;
            this.btnFournisseurs.Location = new System.Drawing.Point(480, 145);
            this.btnFournisseurs.Size = new System.Drawing.Size(360, 70);
            this.btnFournisseurs.Text = "Gérer les fournisseurs";
            this.btnFournisseurs.UseVisualStyleBackColor = false;
            this.btnFournisseurs.Name = "btnFournisseurs";
            this.btnFournisseurs.Click += new System.EventHandler(this.btnFournisseurs_Click);
            // 
            // btnPlats
            // 
            this.btnPlats.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnPlats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlats.FlatAppearance.BorderSize = 0;
            this.btnPlats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlats.ForeColor = System.Drawing.Color.White;
            this.btnPlats.Location = new System.Drawing.Point(480, 230);
            this.btnPlats.Size = new System.Drawing.Size(360, 70);
            this.btnPlats.Text = "Gérer les plats";
            this.btnPlats.UseVisualStyleBackColor = false;
            this.btnPlats.Name = "btnPlats";
            this.btnPlats.Click += new System.EventHandler(this.btnPlats_Click);
            // 
            // btnMenus
            // 
            this.btnMenus.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnMenus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenus.FlatAppearance.BorderSize = 0;
            this.btnMenus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenus.ForeColor = System.Drawing.Color.White;
            this.btnMenus.Location = new System.Drawing.Point(480, 315);
            this.btnMenus.Size = new System.Drawing.Size(360, 70);
            this.btnMenus.Text = "Gérer les menus";
            this.btnMenus.UseVisualStyleBackColor = false;
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Click += new System.EventHandler(this.btnMenus_Click);
            // 
            // btnRapport
            // 
            this.btnRapport.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
            this.btnRapport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRapport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapport.FlatAppearance.BorderSize = 0;
            this.btnRapport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapport.ForeColor = System.Drawing.Color.White;
            this.btnRapport.Location = new System.Drawing.Point(480, 400);
            this.btnRapport.Size = new System.Drawing.Size(360, 70);
            this.btnRapport.Text = "Consulter le rapport";
            this.btnRapport.UseVisualStyleBackColor = false;
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(60, 400);
            this.btnQuitter.Size = new System.Drawing.Size(360, 70);
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des menus et recettes";
            this.Controls.Add(this.panelEntete);
            this.Controls.Add(this.lblChef);
            this.Controls.Add(this.btnIngredients);
            this.Controls.Add(this.btnRecettes);
            this.Controls.Add(this.lblGerant);
            this.Controls.Add(this.btnFournisseurs);
            this.Controls.Add(this.btnPlats);
            this.Controls.Add(this.btnMenus);
            this.Controls.Add(this.btnRapport);
            this.Controls.Add(this.btnQuitter);
            this.Name = "MainForm";
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.Button btnIngredients;
        private System.Windows.Forms.Button btnRecettes;
        private System.Windows.Forms.Label lblGerant;
        private System.Windows.Forms.Button btnFournisseurs;
        private System.Windows.Forms.Button btnPlats;
        private System.Windows.Forms.Button btnMenus;
        private System.Windows.Forms.Button btnRapport;
        private System.Windows.Forms.Button btnQuitter;
    }
}
