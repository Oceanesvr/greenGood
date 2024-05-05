namespace GREEN_GOOD
{
    partial class Fournisseurs
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
            this.dataGridViewFournisseurs = new System.Windows.Forms.DataGridView();
            this.txbTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_fournisseur = new System.Windows.Forms.Label();
            this.lbl_quantite = new System.Windows.Forms.Label();
            this.lbl_categorie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_modifier = new Guna.UI2.WinForms.Guna2Button();
            this.linkLbFournisseurs = new System.Windows.Forms.LinkLabel();
            this.linkLbProduits = new System.Windows.Forms.LinkLabel();
            this.linkLbHistorique = new System.Windows.Forms.LinkLabel();
            this.lbl_deconnexion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbPays = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbDate = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseurs)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFournisseurs
            // 
            this.dataGridViewFournisseurs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewFournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFournisseurs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFournisseurs.Location = new System.Drawing.Point(220, 433);
            this.dataGridViewFournisseurs.Name = "dataGridViewFournisseurs";
            this.dataGridViewFournisseurs.RowHeadersWidth = 51;
            this.dataGridViewFournisseurs.RowTemplate.Height = 24;
            this.dataGridViewFournisseurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFournisseurs.Size = new System.Drawing.Size(1069, 287);
            this.dataGridViewFournisseurs.TabIndex = 36;
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
            this.txbTelephone.Location = new System.Drawing.Point(813, 207);
            this.txbTelephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.PasswordChar = '\0';
            this.txbTelephone.PlaceholderText = "";
            this.txbTelephone.SelectedText = "";
            this.txbTelephone.Size = new System.Drawing.Size(195, 32);
            this.txbTelephone.TabIndex = 35;
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
            this.txbEmail.Location = new System.Drawing.Point(536, 207);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PlaceholderText = "";
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(195, 32);
            this.txbEmail.TabIndex = 34;
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
            this.txbNom.Location = new System.Drawing.Point(279, 207);
            this.txbNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNom.Name = "txbNom";
            this.txbNom.PasswordChar = '\0';
            this.txbNom.PlaceholderText = "";
            this.txbNom.SelectedText = "";
            this.txbNom.Size = new System.Drawing.Size(195, 32);
            this.txbNom.TabIndex = 33;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Black;
            this.lbl_date.Location = new System.Drawing.Point(687, 271);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(44, 23);
            this.lbl_date.TabIndex = 32;
            this.lbl_date.Text = "Date";
            // 
            // lbl_fournisseur
            // 
            this.lbl_fournisseur.AutoSize = true;
            this.lbl_fournisseur.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fournisseur.ForeColor = System.Drawing.Color.Black;
            this.lbl_fournisseur.Location = new System.Drawing.Point(1126, 173);
            this.lbl_fournisseur.Name = "lbl_fournisseur";
            this.lbl_fournisseur.Size = new System.Drawing.Size(183, 23);
            this.lbl_fournisseur.TabIndex = 31;
            this.lbl_fournisseur.Text = "Pays Approvisonnement";
            // 
            // lbl_quantite
            // 
            this.lbl_quantite.AutoSize = true;
            this.lbl_quantite.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantite.ForeColor = System.Drawing.Color.Black;
            this.lbl_quantite.Location = new System.Drawing.Point(821, 173);
            this.lbl_quantite.Name = "lbl_quantite";
            this.lbl_quantite.Size = new System.Drawing.Size(168, 23);
            this.lbl_quantite.TabIndex = 30;
            this.lbl_quantite.Text = "Numéro de téléphone";
            // 
            // lbl_categorie
            // 
            this.lbl_categorie.AutoSize = true;
            this.lbl_categorie.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categorie.ForeColor = System.Drawing.Color.Black;
            this.lbl_categorie.Location = new System.Drawing.Point(555, 173);
            this.lbl_categorie.Name = "lbl_categorie";
            this.lbl_categorie.Size = new System.Drawing.Size(51, 23);
            this.lbl_categorie.TabIndex = 29;
            this.lbl_categorie.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(275, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nom fournisseur";
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
            this.btn_supprimer.Location = new System.Drawing.Point(1007, 350);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(180, 45);
            this.btn_supprimer.TabIndex = 27;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
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
            this.btn_modifier.Location = new System.Drawing.Point(690, 350);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(180, 45);
            this.btn_modifier.TabIndex = 26;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
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
            this.linkLbFournisseurs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbFournisseurs_LinkClicked);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(77)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.linkLbFournisseurs);
            this.panel2.Controls.Add(this.linkLbProduits);
            this.panel2.Controls.Add(this.linkLbHistorique);
            this.panel2.Controls.Add(this.lbl_deconnexion);
            this.panel2.Location = new System.Drawing.Point(-29, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 654);
            this.panel2.TabIndex = 24;
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
            // btn_ajouter
            // 
            this.btn_ajouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ajouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ajouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_ajouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(322, 350);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(180, 45);
            this.btn_ajouter.TabIndex = 25;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(77)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-29, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 117);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txbPays
            // 
            this.txbPays.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.txbPays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPays.DefaultText = "";
            this.txbPays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPays.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPays.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbPays.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPays.Location = new System.Drawing.Point(1114, 207);
            this.txbPays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPays.Name = "txbPays";
            this.txbPays.PasswordChar = '\0';
            this.txbPays.PlaceholderText = "";
            this.txbPays.SelectedText = "";
            this.txbPays.Size = new System.Drawing.Size(195, 32);
            this.txbPays.TabIndex = 39;
            // 
            // txbDate
            // 
            this.txbDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.txbDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDate.DefaultText = "";
            this.txbDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDate.Location = new System.Drawing.Point(691, 298);
            this.txbDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDate.Name = "txbDate";
            this.txbDate.PasswordChar = '\0';
            this.txbDate.PlaceholderText = "";
            this.txbDate.SelectedText = "";
            this.txbDate.Size = new System.Drawing.Size(195, 32);
            this.txbDate.TabIndex = 40;
            // 
            // Fournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 765);
            this.Controls.Add(this.txbDate);
            this.Controls.Add(this.txbPays);
            this.Controls.Add(this.dataGridViewFournisseurs);
            this.Controls.Add(this.txbTelephone);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_fournisseur);
            this.Controls.Add(this.lbl_quantite);
            this.Controls.Add(this.lbl_categorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fournisseurs";
            this.Text = "Fournisseurs";
            this.Load += new System.EventHandler(this.Fournisseurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseurs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewFournisseurs;
        private Guna.UI2.WinForms.Guna2TextBox txbTelephone;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private Guna.UI2.WinForms.Guna2TextBox txbNom;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_fournisseur;
        private System.Windows.Forms.Label lbl_quantite;
        private System.Windows.Forms.Label lbl_categorie;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_supprimer;
        private Guna.UI2.WinForms.Guna2Button btn_modifier;
        private System.Windows.Forms.LinkLabel linkLbFournisseurs;
        private System.Windows.Forms.LinkLabel linkLbProduits;
        private System.Windows.Forms.LinkLabel linkLbHistorique;
        private System.Windows.Forms.Label lbl_deconnexion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_ajouter;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txbPays;
        private Guna.UI2.WinForms.Guna2TextBox txbDate;
    }
}