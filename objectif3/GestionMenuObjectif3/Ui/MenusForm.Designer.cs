namespace GestionMenusRecettes.Ui
{
    partial class MenusForm
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
            this.panelPlatsMenu = new System.Windows.Forms.Panel();
            this.dgvPlatsMenu = new System.Windows.Forms.DataGridView();
            this.panelChampsPlats = new System.Windows.Forms.Panel();
            this.lblPlat = new System.Windows.Forms.Label();
            this.cmbPlat = new System.Windows.Forms.ComboBox();
            this.btnAjouterPlat = new System.Windows.Forms.Button();
            this.btnRetirerPlat = new System.Windows.Forms.Button();
            this.lblPlatsMenu = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.dgvMenus = new System.Windows.Forms.DataGridView();
            this.panelChampsMenu = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panelEntete = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).BeginInit();
            this.panelPlatsMenu.SuspendLayout();
            this.panelChampsPlats.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelChampsMenu.SuspendLayout();
            this.panelEntete.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlatsMenu
            // 
            this.panelPlatsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlatsMenu.Size = new System.Drawing.Size(100, 100);
            this.panelPlatsMenu.Name = "panelPlatsMenu";
            this.panelPlatsMenu.Controls.Add(this.dgvPlatsMenu);
            this.panelPlatsMenu.Controls.Add(this.panelChampsPlats);
            this.panelPlatsMenu.Controls.Add(this.lblPlatsMenu);
            // 
            // dgvPlatsMenu
            // 
            this.dgvPlatsMenu.AllowUserToAddRows = false;
            this.dgvPlatsMenu.AllowUserToDeleteRows = false;
            this.dgvPlatsMenu.AllowUserToResizeRows = false;
            this.dgvPlatsMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlatsMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlatsMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlatsMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlatsMenu.MultiSelect = false;
            this.dgvPlatsMenu.ReadOnly = true;
            this.dgvPlatsMenu.RowHeadersVisible = false;
            this.dgvPlatsMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlatsMenu.Name = "dgvPlatsMenu";
            // 
            // panelChampsPlats
            // 
            this.panelChampsPlats.BackColor = System.Drawing.Color.White;
            this.panelChampsPlats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChampsPlats.Size = new System.Drawing.Size(100, 70);
            this.panelChampsPlats.Name = "panelChampsPlats";
            this.panelChampsPlats.Controls.Add(this.lblPlat);
            this.panelChampsPlats.Controls.Add(this.cmbPlat);
            this.panelChampsPlats.Controls.Add(this.btnAjouterPlat);
            this.panelChampsPlats.Controls.Add(this.btnRetirerPlat);
            // 
            // lblPlat
            // 
            this.lblPlat.AutoSize = true;
            this.lblPlat.Location = new System.Drawing.Point(20, 26);
            this.lblPlat.Text = "Plat";
            this.lblPlat.Name = "lblPlat";
            // 
            // cmbPlat
            // 
            this.cmbPlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlat.FormattingEnabled = true;
            this.cmbPlat.Location = new System.Drawing.Point(70, 22);
            this.cmbPlat.Size = new System.Drawing.Size(300, 23);
            this.cmbPlat.Name = "cmbPlat";
            // 
            // btnAjouterPlat
            // 
            this.btnAjouterPlat.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
            this.btnAjouterPlat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterPlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterPlat.FlatAppearance.BorderSize = 0;
            this.btnAjouterPlat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPlat.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPlat.Location = new System.Drawing.Point(390, 18);
            this.btnAjouterPlat.Size = new System.Drawing.Size(220, 36);
            this.btnAjouterPlat.Text = "Ajouter le plat au menu";
            this.btnAjouterPlat.UseVisualStyleBackColor = false;
            this.btnAjouterPlat.Name = "btnAjouterPlat";
            this.btnAjouterPlat.Click += new System.EventHandler(this.btnAjouterPlat_Click);
            // 
            // btnRetirerPlat
            // 
            this.btnRetirerPlat.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnRetirerPlat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirerPlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirerPlat.FlatAppearance.BorderSize = 0;
            this.btnRetirerPlat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirerPlat.ForeColor = System.Drawing.Color.White;
            this.btnRetirerPlat.Location = new System.Drawing.Point(620, 18);
            this.btnRetirerPlat.Size = new System.Drawing.Size(220, 36);
            this.btnRetirerPlat.Text = "Retirer le plat du menu";
            this.btnRetirerPlat.UseVisualStyleBackColor = false;
            this.btnRetirerPlat.Name = "btnRetirerPlat";
            this.btnRetirerPlat.Click += new System.EventHandler(this.btnRetirerPlat_Click);
            // 
            // lblPlatsMenu
            // 
            this.lblPlatsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPlatsMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatsMenu.Size = new System.Drawing.Size(100, 30);
            this.lblPlatsMenu.Text = "  Plats du menu sélectionné";
            this.lblPlatsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlatsMenu.Name = "lblPlatsMenu";
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Size = new System.Drawing.Size(100, 330);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Controls.Add(this.dgvMenus);
            this.panelMenu.Controls.Add(this.panelChampsMenu);
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
            this.dgvMenus.SelectionChanged += new System.EventHandler(this.dgvMenus_SelectionChanged);
            // 
            // panelChampsMenu
            // 
            this.panelChampsMenu.BackColor = System.Drawing.Color.White;
            this.panelChampsMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChampsMenu.Size = new System.Drawing.Size(100, 80);
            this.panelChampsMenu.Name = "panelChampsMenu";
            this.panelChampsMenu.Controls.Add(this.lblNom);
            this.panelChampsMenu.Controls.Add(this.txtNom);
            this.panelChampsMenu.Controls.Add(this.btnAjouter);
            this.panelChampsMenu.Controls.Add(this.btnModifier);
            this.panelChampsMenu.Controls.Add(this.btnSupprimer);
            this.panelChampsMenu.Controls.Add(this.btnNouveau);
            this.panelChampsMenu.Controls.Add(this.btnFermer);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 30);
            this.lblNom.Text = "Nom du menu";
            this.lblNom.Name = "lblNom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(115, 26);
            this.txtNom.Size = new System.Drawing.Size(230, 23);
            this.txtNom.Name = "txtNom";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(370, 22);
            this.btnAjouter.Size = new System.Drawing.Size(105, 36);
            this.btnAjouter.Text = "Créer";
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
            this.btnModifier.Location = new System.Drawing.Point(485, 22);
            this.btnModifier.Size = new System.Drawing.Size(105, 36);
            this.btnModifier.Text = "Renommer";
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
            this.btnSupprimer.Location = new System.Drawing.Point(600, 22);
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
            this.btnNouveau.Location = new System.Drawing.Point(715, 22);
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
            this.lblTitre.Text = "Gérer les menus (gérant)";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitre.Name = "lblTitre";
            // 
            // MenusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1000, 760);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menus";
            this.Controls.Add(this.panelPlatsMenu);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelEntete);
            this.Name = "MenusForm";
            this.Load += new System.EventHandler(this.MenusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).EndInit();
            this.panelPlatsMenu.ResumeLayout(false);
            this.panelPlatsMenu.PerformLayout();
            this.panelChampsPlats.ResumeLayout(false);
            this.panelChampsPlats.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelChampsMenu.ResumeLayout(false);
            this.panelChampsMenu.PerformLayout();
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPlatsMenu;
        private System.Windows.Forms.DataGridView dgvPlatsMenu;
        private System.Windows.Forms.Panel panelChampsPlats;
        private System.Windows.Forms.Label lblPlat;
        private System.Windows.Forms.ComboBox cmbPlat;
        private System.Windows.Forms.Button btnAjouterPlat;
        private System.Windows.Forms.Button btnRetirerPlat;
        private System.Windows.Forms.Label lblPlatsMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.DataGridView dgvMenus;
        private System.Windows.Forms.Panel panelChampsMenu;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Label lblTitre;
    }
}
