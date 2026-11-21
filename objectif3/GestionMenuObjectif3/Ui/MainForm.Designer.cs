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
            panelEntete = new System.Windows.Forms.Panel();
            lblTitre = new System.Windows.Forms.Label();
            lblSousTitre = new System.Windows.Forms.Label();
            lblChef = new System.Windows.Forms.Label();
            btnIngredients = new System.Windows.Forms.Button();
            btnRecettes = new System.Windows.Forms.Button();
            lblGerant = new System.Windows.Forms.Label();
            btnFournisseurs = new System.Windows.Forms.Button();
            btnPlats = new System.Windows.Forms.Button();
            btnMenus = new System.Windows.Forms.Button();
            btnRapport = new System.Windows.Forms.Button();
            btnQuitter = new System.Windows.Forms.Button();
            panelEntete.SuspendLayout();
            SuspendLayout();
            // 
            // panelEntete
            // 
            panelEntete.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            panelEntete.Controls.Add(lblTitre);
            panelEntete.Controls.Add(lblSousTitre);
            panelEntete.Dock = System.Windows.Forms.DockStyle.Top;
            panelEntete.Location = new System.Drawing.Point(0, 0);
            panelEntete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelEntete.Name = "panelEntete";
            panelEntete.Size = new System.Drawing.Size(1029, 120);
            panelEntete.TabIndex = 0;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitre.ForeColor = System.Drawing.Color.White;
            lblTitre.Location = new System.Drawing.Point(23, 16);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new System.Drawing.Size(436, 41);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Gestion des menus et recettes";
            // 
            // lblSousTitre
            // 
            lblSousTitre.AutoSize = true;
            lblSousTitre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSousTitre.ForeColor = System.Drawing.Color.White;
            lblSousTitre.Location = new System.Drawing.Point(25, 75);
            lblSousTitre.Name = "lblSousTitre";
            lblSousTitre.Size = new System.Drawing.Size(446, 23);
            lblSousTitre.TabIndex = 1;
            lblSousTitre.Text = "Restaurant : ingrédients, recettes, plats, menus et marges";
            // 
            // lblChef
            // 
            lblChef.AutoSize = true;
            lblChef.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblChef.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            lblChef.Location = new System.Drawing.Point(69, 147);
            lblChef.Name = "lblChef";
            lblChef.Size = new System.Drawing.Size(152, 30);
            lblChef.TabIndex = 1;
            lblChef.Text = "Chef cuisinier";
            // 
            // btnIngredients
            // 
            btnIngredients.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            btnIngredients.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIngredients.FlatAppearance.BorderSize = 0;
            btnIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIngredients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnIngredients.ForeColor = System.Drawing.Color.White;
            btnIngredients.Location = new System.Drawing.Point(69, 193);
            btnIngredients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnIngredients.Name = "btnIngredients";
            btnIngredients.Size = new System.Drawing.Size(411, 93);
            btnIngredients.TabIndex = 2;
            btnIngredients.Text = "Gérer les ingrédients";
            btnIngredients.UseVisualStyleBackColor = false;
            btnIngredients.Click += btnIngredients_Click;
            // 
            // btnRecettes
            // 
            btnRecettes.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            btnRecettes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRecettes.FlatAppearance.BorderSize = 0;
            btnRecettes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRecettes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRecettes.ForeColor = System.Drawing.Color.White;
            btnRecettes.Location = new System.Drawing.Point(69, 307);
            btnRecettes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRecettes.Name = "btnRecettes";
            btnRecettes.Size = new System.Drawing.Size(411, 93);
            btnRecettes.TabIndex = 3;
            btnRecettes.Text = "Gérer les recettes";
            btnRecettes.UseVisualStyleBackColor = false;
            btnRecettes.Click += btnRecettes_Click;
            // 
            // lblGerant
            // 
            lblGerant.AutoSize = true;
            lblGerant.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblGerant.ForeColor = System.Drawing.Color.FromArgb(46, 117, 182);
            lblGerant.Location = new System.Drawing.Point(549, 147);
            lblGerant.Name = "lblGerant";
            lblGerant.Size = new System.Drawing.Size(84, 30);
            lblGerant.TabIndex = 4;
            lblGerant.Text = "Gérant";
            // 
            // btnFournisseurs
            // 
            btnFournisseurs.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            btnFournisseurs.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFournisseurs.FlatAppearance.BorderSize = 0;
            btnFournisseurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFournisseurs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFournisseurs.ForeColor = System.Drawing.Color.White;
            btnFournisseurs.Location = new System.Drawing.Point(549, 193);
            btnFournisseurs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnFournisseurs.Name = "btnFournisseurs";
            btnFournisseurs.Size = new System.Drawing.Size(411, 93);
            btnFournisseurs.TabIndex = 5;
            btnFournisseurs.Text = "Gérer les fournisseurs";
            btnFournisseurs.UseVisualStyleBackColor = false;
            btnFournisseurs.Click += btnFournisseurs_Click;
            // 
            // btnPlats
            // 
            btnPlats.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            btnPlats.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPlats.FlatAppearance.BorderSize = 0;
            btnPlats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPlats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPlats.ForeColor = System.Drawing.Color.White;
            btnPlats.Location = new System.Drawing.Point(549, 307);
            btnPlats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPlats.Name = "btnPlats";
            btnPlats.Size = new System.Drawing.Size(411, 93);
            btnPlats.TabIndex = 6;
            btnPlats.Text = "Gérer les plats";
            btnPlats.UseVisualStyleBackColor = false;
            btnPlats.Click += btnPlats_Click;
            // 
            // btnMenus
            // 
            btnMenus.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            btnMenus.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenus.FlatAppearance.BorderSize = 0;
            btnMenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMenus.ForeColor = System.Drawing.Color.White;
            btnMenus.Location = new System.Drawing.Point(549, 420);
            btnMenus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnMenus.Name = "btnMenus";
            btnMenus.Size = new System.Drawing.Size(411, 93);
            btnMenus.TabIndex = 7;
            btnMenus.Text = "Gérer les menus";
            btnMenus.UseVisualStyleBackColor = false;
            btnMenus.Click += btnMenus_Click;
            // 
            // btnRapport
            // 
            btnRapport.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
            btnRapport.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRapport.FlatAppearance.BorderSize = 0;
            btnRapport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRapport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRapport.ForeColor = System.Drawing.Color.White;
            btnRapport.Location = new System.Drawing.Point(549, 533);
            btnRapport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRapport.Name = "btnRapport";
            btnRapport.Size = new System.Drawing.Size(411, 93);
            btnRapport.TabIndex = 8;
            btnRapport.Text = "Consulter le rapport";
            btnRapport.UseVisualStyleBackColor = false;
            btnRapport.Click += btnRapport_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuitter.FlatAppearance.BorderSize = 0;
            btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuitter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnQuitter.ForeColor = System.Drawing.Color.White;
            btnQuitter.Location = new System.Drawing.Point(69, 533);
            btnQuitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new System.Drawing.Size(411, 93);
            btnQuitter.TabIndex = 9;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            ClientSize = new System.Drawing.Size(1029, 667);
            Controls.Add(panelEntete);
            Controls.Add(lblChef);
            Controls.Add(btnIngredients);
            Controls.Add(btnRecettes);
            Controls.Add(lblGerant);
            Controls.Add(btnFournisseurs);
            Controls.Add(btnPlats);
            Controls.Add(btnMenus);
            Controls.Add(btnRapport);
            Controls.Add(btnQuitter);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Gestion des menus et recettes";
            Load += MainForm_Load;
            panelEntete.ResumeLayout(false);
            panelEntete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
