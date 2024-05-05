namespace GREEN_GOOD
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewProduits = new System.Windows.Forms.DataGridView();
            this.comboBoxFournisseur = new System.Windows.Forms.ComboBox();
            this.txbQuantite = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbCategorie = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbArticle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_fournisseur = new System.Windows.Forms.Label();
            this.lbl_quantite = new System.Windows.Forms.Label();
            this.lbl_categorie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.linkLbProduits = new System.Windows.Forms.LinkLabel();
            this.linkLbHistorique = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLbFournisseurs = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_modifier = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLbDeconnexion = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduits)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProduits
            // 
            this.dataGridViewProduits.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProduits.Location = new System.Drawing.Point(251, 417);
            this.dataGridViewProduits.Name = "dataGridViewProduits";
            this.dataGridViewProduits.RowHeadersWidth = 51;
            this.dataGridViewProduits.RowTemplate.Height = 24;
            this.dataGridViewProduits.Size = new System.Drawing.Size(1069, 287);
            this.dataGridViewProduits.TabIndex = 37;
            this.dataGridViewProduits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduits_CellClick);
            this.dataGridViewProduits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduits_CellContentClick);
            // 
            // comboBoxFournisseur
            // 
            this.comboBoxFournisseur.FormattingEnabled = true;
            this.comboBoxFournisseur.Location = new System.Drawing.Point(1131, 191);
            this.comboBoxFournisseur.Name = "comboBoxFournisseur";
            this.comboBoxFournisseur.Size = new System.Drawing.Size(160, 24);
            this.comboBoxFournisseur.TabIndex = 36;
            this.comboBoxFournisseur.SelectedIndexChanged += new System.EventHandler(this.comboBoxFournisseur_SelectedIndexChanged);
            // 
            // txbQuantite
            // 
            this.txbQuantite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.txbQuantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbQuantite.DefaultText = "";
            this.txbQuantite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbQuantite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbQuantite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbQuantite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbQuantite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbQuantite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbQuantite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbQuantite.Location = new System.Drawing.Point(831, 183);
            this.txbQuantite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbQuantite.Name = "txbQuantite";
            this.txbQuantite.PasswordChar = '\0';
            this.txbQuantite.PlaceholderText = "";
            this.txbQuantite.SelectedText = "";
            this.txbQuantite.Size = new System.Drawing.Size(195, 32);
            this.txbQuantite.TabIndex = 35;
            this.txbQuantite.TextChanged += new System.EventHandler(this.txbQuantite_TextChanged);
            // 
            // txbCategorie
            // 
            this.txbCategorie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.txbCategorie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCategorie.DefaultText = "";
            this.txbCategorie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCategorie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCategorie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCategorie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCategorie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCategorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbCategorie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCategorie.Location = new System.Drawing.Point(554, 183);
            this.txbCategorie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCategorie.Name = "txbCategorie";
            this.txbCategorie.PasswordChar = '\0';
            this.txbCategorie.PlaceholderText = "";
            this.txbCategorie.SelectedText = "";
            this.txbCategorie.Size = new System.Drawing.Size(195, 32);
            this.txbCategorie.TabIndex = 34;
            this.txbCategorie.TextChanged += new System.EventHandler(this.txbCategorie_TextChanged);
            // 
            // txbArticle
            // 
            this.txbArticle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.txbArticle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbArticle.DefaultText = "";
            this.txbArticle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbArticle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbArticle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbArticle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbArticle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbArticle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbArticle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbArticle.Location = new System.Drawing.Point(297, 183);
            this.txbArticle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbArticle.Name = "txbArticle";
            this.txbArticle.PasswordChar = '\0';
            this.txbArticle.PlaceholderText = "";
            this.txbArticle.SelectedText = "";
            this.txbArticle.Size = new System.Drawing.Size(195, 32);
            this.txbArticle.TabIndex = 33;
            this.txbArticle.TextChanged += new System.EventHandler(this.txbArticle_TextChanged);
            // 
            // lbl_fournisseur
            // 
            this.lbl_fournisseur.AutoSize = true;
            this.lbl_fournisseur.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fournisseur.ForeColor = System.Drawing.Color.Black;
            this.lbl_fournisseur.Location = new System.Drawing.Point(1144, 149);
            this.lbl_fournisseur.Name = "lbl_fournisseur";
            this.lbl_fournisseur.Size = new System.Drawing.Size(94, 23);
            this.lbl_fournisseur.TabIndex = 32;
            this.lbl_fournisseur.Text = "Fournisseur";
            this.lbl_fournisseur.Click += new System.EventHandler(this.lbl_fournisseur_Click);
            // 
            // lbl_quantite
            // 
            this.lbl_quantite.AutoSize = true;
            this.lbl_quantite.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantite.ForeColor = System.Drawing.Color.Black;
            this.lbl_quantite.Location = new System.Drawing.Point(839, 149);
            this.lbl_quantite.Name = "lbl_quantite";
            this.lbl_quantite.Size = new System.Drawing.Size(74, 23);
            this.lbl_quantite.TabIndex = 31;
            this.lbl_quantite.Text = "Quantité";
            this.lbl_quantite.Click += new System.EventHandler(this.lbl_quantite_Click);
            // 
            // lbl_categorie
            // 
            this.lbl_categorie.AutoSize = true;
            this.lbl_categorie.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categorie.ForeColor = System.Drawing.Color.Black;
            this.lbl_categorie.Location = new System.Drawing.Point(573, 149);
            this.lbl_categorie.Name = "lbl_categorie";
            this.lbl_categorie.Size = new System.Drawing.Size(80, 23);
            this.lbl_categorie.TabIndex = 30;
            this.lbl_categorie.Text = "Catégorie";
            this.lbl_categorie.Click += new System.EventHandler(this.lbl_categorie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(293, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nom de l\'article";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_supprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_supprimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_supprimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Location = new System.Drawing.Point(1025, 326);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(180, 45);
            this.btn_supprimer.TabIndex = 28;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ajouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ajouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_ajouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(340, 326);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(180, 45);
            this.btn_ajouter.TabIndex = 26;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // linkLbProduits
            // 
            this.linkLbProduits.AutoSize = true;
            this.linkLbProduits.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbProduits.LinkColor = System.Drawing.Color.White;
            this.linkLbProduits.Location = new System.Drawing.Point(48, 261);
            this.linkLbProduits.Name = "linkLbProduits";
            this.linkLbProduits.Size = new System.Drawing.Size(84, 27);
            this.linkLbProduits.TabIndex = 24;
            this.linkLbProduits.TabStop = true;
            this.linkLbProduits.Text = "Produits";
            // 
            // linkLbHistorique
            // 
            this.linkLbHistorique.AutoSize = true;
            this.linkLbHistorique.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbHistorique.LinkColor = System.Drawing.Color.White;
            this.linkLbHistorique.Location = new System.Drawing.Point(48, 156);
            this.linkLbHistorique.Name = "linkLbHistorique";
            this.linkLbHistorique.Size = new System.Drawing.Size(100, 27);
            this.linkLbHistorique.TabIndex = 23;
            this.linkLbHistorique.TabStop = true;
            this.linkLbHistorique.Text = "Historique";
            this.linkLbHistorique.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbHistorique_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(77)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.linkLbDeconnexion);
            this.panel2.Controls.Add(this.linkLbFournisseurs);
            this.panel2.Controls.Add(this.linkLbProduits);
            this.panel2.Controls.Add(this.linkLbHistorique);
            this.panel2.Location = new System.Drawing.Point(-11, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 620);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // linkLbFournisseurs
            // 
            this.linkLbFournisseurs.AutoSize = true;
            this.linkLbFournisseurs.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbFournisseurs.LinkColor = System.Drawing.Color.White;
            this.linkLbFournisseurs.Location = new System.Drawing.Point(30, 369);
            this.linkLbFournisseurs.Name = "linkLbFournisseurs";
            this.linkLbFournisseurs.Size = new System.Drawing.Size(118, 27);
            this.linkLbFournisseurs.TabIndex = 25;
            this.linkLbFournisseurs.TabStop = true;
            this.linkLbFournisseurs.Text = "Fournisseurs";
            this.linkLbFournisseurs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbFournisseurs_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(558, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des produits";
            // 
            // btn_modifier
            // 
            this.btn_modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_modifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_modifier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_modifier.Location = new System.Drawing.Point(708, 326);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(180, 45);
            this.btn_modifier.TabIndex = 27;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(77)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 104);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLbDeconnexion
            // 
            this.linkLbDeconnexion.AutoSize = true;
            this.linkLbDeconnexion.LinkColor = System.Drawing.Color.White;
            this.linkLbDeconnexion.Location = new System.Drawing.Point(50, 562);
            this.linkLbDeconnexion.Name = "linkLbDeconnexion";
            this.linkLbDeconnexion.Size = new System.Drawing.Size(86, 16);
            this.linkLbDeconnexion.TabIndex = 26;
            this.linkLbDeconnexion.TabStop = true;
            this.linkLbDeconnexion.Text = "Déconnexion";
            this.linkLbDeconnexion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbDeconnexion_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 718);
            this.Controls.Add(this.dataGridViewProduits);
            this.Controls.Add(this.comboBoxFournisseur);
            this.Controls.Add(this.txbQuantite);
            this.Controls.Add(this.txbCategorie);
            this.Controls.Add(this.txbArticle);
            this.Controls.Add(this.lbl_fournisseur);
            this.Controls.Add(this.lbl_quantite);
            this.Controls.Add(this.lbl_categorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduits)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduits;
        private System.Windows.Forms.ComboBox comboBoxFournisseur;
        private Guna.UI2.WinForms.Guna2TextBox txbQuantite;
        private Guna.UI2.WinForms.Guna2TextBox txbCategorie;
        private Guna.UI2.WinForms.Guna2TextBox txbArticle;
        private System.Windows.Forms.Label lbl_fournisseur;
        private System.Windows.Forms.Label lbl_quantite;
        private System.Windows.Forms.Label lbl_categorie;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_supprimer;
        private Guna.UI2.WinForms.Guna2Button btn_ajouter;
        private System.Windows.Forms.LinkLabel linkLbProduits;
        private System.Windows.Forms.LinkLabel linkLbHistorique;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLbFournisseurs;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_modifier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLbDeconnexion;
    }
}