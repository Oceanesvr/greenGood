namespace GREEN_GOOD
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLbFournisseurs = new System.Windows.Forms.LinkLabel();
            this.linkLbProduits = new System.Windows.Forms.LinkLabel();
            this.linkLbHistorique = new System.Windows.Forms.LinkLabel();
            this.lbl_deconnexion = new System.Windows.Forms.Label();
            this.dataGridViewFournisseurs = new System.Windows.Forms.DataGridView();
            this.txbTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_quantite = new System.Windows.Forms.Label();
            this.lbl_categorie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_categorieP = new System.Windows.Forms.Label();
            this.txbCategorie = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseurs)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(558, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des fournisseurs";
            // 
            // linkLbFournisseurs
            // 
            this.linkLbFournisseurs.AutoSize = true;
            this.linkLbFournisseurs.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbFournisseurs.LinkColor = System.Drawing.Color.White;
            this.linkLbFournisseurs.Location = new System.Drawing.Point(58, 389);
            this.linkLbFournisseurs.Name = "linkLbFournisseurs";
            this.linkLbFournisseurs.Size = new System.Drawing.Size(118, 27);
            this.linkLbFournisseurs.TabIndex = 25;
            this.linkLbFournisseurs.TabStop = true;
            this.linkLbFournisseurs.Text = "Fournisseurs";
            // 
            // linkLbProduits
            // 
            this.linkLbProduits.AutoSize = true;
            this.linkLbProduits.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbProduits.LinkColor = System.Drawing.Color.White;
            this.linkLbProduits.Location = new System.Drawing.Point(58, 266);
            this.linkLbProduits.Name = "linkLbProduits";
            this.linkLbProduits.Size = new System.Drawing.Size(84, 27);
            this.linkLbProduits.TabIndex = 24;
            this.linkLbProduits.TabStop = true;
            this.linkLbProduits.Text = "Produits";
            this.linkLbProduits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbProduits_LinkClicked);
            // 
            // linkLbHistorique
            // 
            this.linkLbHistorique.AutoSize = true;
            this.linkLbHistorique.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbHistorique.LinkColor = System.Drawing.Color.White;
            this.linkLbHistorique.Location = new System.Drawing.Point(58, 153);
            this.linkLbHistorique.Name = "linkLbHistorique";
            this.linkLbHistorique.Size = new System.Drawing.Size(100, 27);
            this.linkLbHistorique.TabIndex = 23;
            this.linkLbHistorique.TabStop = true;
            this.linkLbHistorique.Text = "Historique";
            this.linkLbHistorique.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbHistorique_LinkClicked);
            // 
            // lbl_deconnexion
            // 
            this.lbl_deconnexion.AutoSize = true;
            this.lbl_deconnexion.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deconnexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_deconnexion.Location = new System.Drawing.Point(70, 583);
            this.lbl_deconnexion.Name = "lbl_deconnexion";
            this.lbl_deconnexion.Size = new System.Drawing.Size(106, 23);
            this.lbl_deconnexion.TabIndex = 2;
            this.lbl_deconnexion.Text = "Déconnexion";
            // 
            // dataGridViewFournisseurs
            // 
            this.dataGridViewFournisseurs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewFournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFournisseurs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFournisseurs.Location = new System.Drawing.Point(241, 438);
            this.dataGridViewFournisseurs.Name = "dataGridViewFournisseurs";
            this.dataGridViewFournisseurs.RowHeadersWidth = 51;
            this.dataGridViewFournisseurs.RowTemplate.Height = 24;
            this.dataGridViewFournisseurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFournisseurs.Size = new System.Drawing.Size(1069, 287);
            this.dataGridViewFournisseurs.TabIndex = 54;
            this.dataGridViewFournisseurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFournisseurs_CellClick);
            // 
            // txbTelephone
            // 
            this.txbTelephone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.txbTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTelephone.DefaultText = "";
            this.txbTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTelephone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTelephone.Location = new System.Drawing.Point(834, 212);
            this.txbTelephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.PasswordChar = '\0';
            this.txbTelephone.PlaceholderText = "";
            this.txbTelephone.SelectedText = "";
            this.txbTelephone.Size = new System.Drawing.Size(195, 32);
            this.txbTelephone.TabIndex = 53;
            // 
            // txbEmail
            // 
            this.txbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.DefaultText = "";
            this.txbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Location = new System.Drawing.Point(557, 212);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PlaceholderText = "";
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(195, 32);
            this.txbEmail.TabIndex = 52;
            // 
            // txbNom
            // 
            this.txbNom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.txbNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNom.DefaultText = "";
            this.txbNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNom.Location = new System.Drawing.Point(300, 212);
            this.txbNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNom.Name = "txbNom";
            this.txbNom.PasswordChar = '\0';
            this.txbNom.PlaceholderText = "";
            this.txbNom.SelectedText = "";
            this.txbNom.Size = new System.Drawing.Size(195, 32);
            this.txbNom.TabIndex = 51;
            // 
            // lbl_quantite
            // 
            this.lbl_quantite.AutoSize = true;
            this.lbl_quantite.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantite.ForeColor = System.Drawing.Color.Black;
            this.lbl_quantite.Location = new System.Drawing.Point(830, 178);
            this.lbl_quantite.Name = "lbl_quantite";
            this.lbl_quantite.Size = new System.Drawing.Size(168, 23);
            this.lbl_quantite.TabIndex = 48;
            this.lbl_quantite.Text = "Numéro de téléphone";
            // 
            // lbl_categorie
            // 
            this.lbl_categorie.AutoSize = true;
            this.lbl_categorie.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categorie.ForeColor = System.Drawing.Color.Black;
            this.lbl_categorie.Location = new System.Drawing.Point(553, 178);
            this.lbl_categorie.Name = "lbl_categorie";
            this.lbl_categorie.Size = new System.Drawing.Size(51, 23);
            this.lbl_categorie.TabIndex = 47;
            this.lbl_categorie.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(296, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nom fournisseur";
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
            this.btn_supprimer.Location = new System.Drawing.Point(872, 367);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(180, 45);
            this.btn_supprimer.TabIndex = 45;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(77)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.linkLbFournisseurs);
            this.panel2.Controls.Add(this.linkLbProduits);
            this.panel2.Controls.Add(this.linkLbHistorique);
            this.panel2.Controls.Add(this.lbl_deconnexion);
            this.panel2.Location = new System.Drawing.Point(-8, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 654);
            this.panel2.TabIndex = 42;
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
            this.btn_ajouter.Location = new System.Drawing.Point(512, 367);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(180, 45);
            this.btn_ajouter.TabIndex = 43;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(77)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 117);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_categorieP
            // 
            this.lbl_categorieP.AutoSize = true;
            this.lbl_categorieP.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categorieP.ForeColor = System.Drawing.Color.Black;
            this.lbl_categorieP.Location = new System.Drawing.Point(1096, 178);
            this.lbl_categorieP.Name = "lbl_categorieP";
            this.lbl_categorieP.Size = new System.Drawing.Size(80, 23);
            this.lbl_categorieP.TabIndex = 50;
            this.lbl_categorieP.Text = "Categorie";
            this.lbl_categorieP.Click += new System.EventHandler(this.lbl_date_Click);
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
            this.txbCategorie.Location = new System.Drawing.Point(1100, 212);
            this.txbCategorie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCategorie.Name = "txbCategorie";
            this.txbCategorie.PasswordChar = '\0';
            this.txbCategorie.PlaceholderText = "";
            this.txbCategorie.SelectedText = "";
            this.txbCategorie.Size = new System.Drawing.Size(195, 32);
            this.txbCategorie.TabIndex = 56;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 776);
            this.Controls.Add(this.txbCategorie);
            this.Controls.Add(this.dataGridViewFournisseurs);
            this.Controls.Add(this.txbTelephone);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.lbl_categorieP);
            this.Controls.Add(this.lbl_quantite);
            this.Controls.Add(this.lbl_categorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseurs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLbFournisseurs;
        private System.Windows.Forms.LinkLabel linkLbProduits;
        private System.Windows.Forms.LinkLabel linkLbHistorique;
        private System.Windows.Forms.Label lbl_deconnexion;
        private System.Windows.Forms.DataGridView dataGridViewFournisseurs;
        private Guna.UI2.WinForms.Guna2TextBox txbTelephone;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private Guna.UI2.WinForms.Guna2TextBox txbNom;
        private System.Windows.Forms.Label lbl_quantite;
        private System.Windows.Forms.Label lbl_categorie;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_supprimer;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_ajouter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_categorieP;
        private Guna.UI2.WinForms.Guna2TextBox txbCategorie;
    }
}