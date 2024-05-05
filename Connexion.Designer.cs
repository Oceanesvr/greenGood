namespace GREEN_GOOD
{
    partial class icon_user
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(icon_user));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_identifiant = new System.Windows.Forms.Label();
            this.lb_motDePasse = new System.Windows.Forms.Label();
            this.txb_identifiant = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_mdp = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_seConnecter = new Guna.UI2.WinForms.Guna2Button();
            this.titre_page_gestionGG = new System.Windows.Forms.Label();
            this.icon_mdp = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_mdp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 609);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_identifiant
            // 
            this.lb_identifiant.AutoSize = true;
            this.lb_identifiant.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_identifiant.Location = new System.Drawing.Point(815, 176);
            this.lb_identifiant.Name = "lb_identifiant";
            this.lb_identifiant.Size = new System.Drawing.Size(98, 27);
            this.lb_identifiant.TabIndex = 1;
            this.lb_identifiant.Text = "Identifiant";
            this.lb_identifiant.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_motDePasse
            // 
            this.lb_motDePasse.AutoSize = true;
            this.lb_motDePasse.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_motDePasse.Location = new System.Drawing.Point(815, 320);
            this.lb_motDePasse.Name = "lb_motDePasse";
            this.lb_motDePasse.Size = new System.Drawing.Size(120, 27);
            this.lb_motDePasse.TabIndex = 2;
            this.lb_motDePasse.Text = "Mot de passe";
            this.lb_motDePasse.Click += new System.EventHandler(this.lb_motDePasse_Click);
            // 
            // txb_identifiant
            // 
            this.txb_identifiant.BackColor = System.Drawing.Color.White;
            this.txb_identifiant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.txb_identifiant.BorderRadius = 5;
            this.txb_identifiant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_identifiant.DefaultText = "";
            this.txb_identifiant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_identifiant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_identifiant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_identifiant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_identifiant.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txb_identifiant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_identifiant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_identifiant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_identifiant.Location = new System.Drawing.Point(820, 207);
            this.txb_identifiant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_identifiant.Name = "txb_identifiant";
            this.txb_identifiant.PasswordChar = '\0';
            this.txb_identifiant.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txb_identifiant.PlaceholderText = "";
            this.txb_identifiant.SelectedText = "";
            this.txb_identifiant.Size = new System.Drawing.Size(308, 64);
            this.txb_identifiant.TabIndex = 3;
            this.txb_identifiant.TextChanged += new System.EventHandler(this.txb_identifiant_TextChanged);
            // 
            // txb_mdp
            // 
            this.txb_mdp.BorderColor = System.Drawing.Color.Plum;
            this.txb_mdp.BorderRadius = 5;
            this.txb_mdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_mdp.DefaultText = "";
            this.txb_mdp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_mdp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_mdp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_mdp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_mdp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txb_mdp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_mdp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_mdp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_mdp.Location = new System.Drawing.Point(820, 351);
            this.txb_mdp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_mdp.Name = "txb_mdp";
            this.txb_mdp.PasswordChar = '\0';
            this.txb_mdp.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txb_mdp.PlaceholderText = "";
            this.txb_mdp.SelectedText = "";
            this.txb_mdp.Size = new System.Drawing.Size(302, 61);
            this.txb_mdp.TabIndex = 4;
            this.txb_mdp.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // btn_seConnecter
            // 
            this.btn_seConnecter.BorderRadius = 20;
            this.btn_seConnecter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_seConnecter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_seConnecter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_seConnecter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_seConnecter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(77)))), ((int)(((byte)(50)))));
            this.btn_seConnecter.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seConnecter.ForeColor = System.Drawing.Color.White;
            this.btn_seConnecter.Location = new System.Drawing.Point(839, 441);
            this.btn_seConnecter.Name = "btn_seConnecter";
            this.btn_seConnecter.Size = new System.Drawing.Size(270, 60);
            this.btn_seConnecter.TabIndex = 5;
            this.btn_seConnecter.Text = "Se connecter";
            this.btn_seConnecter.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // titre_page_gestionGG
            // 
            this.titre_page_gestionGG.AutoSize = true;
            this.titre_page_gestionGG.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_page_gestionGG.Location = new System.Drawing.Point(732, 9);
            this.titre_page_gestionGG.Name = "titre_page_gestionGG";
            this.titre_page_gestionGG.Size = new System.Drawing.Size(468, 42);
            this.titre_page_gestionGG.TabIndex = 6;
            this.titre_page_gestionGG.Text = "Gestion de stock GREEN GOOD";
            this.titre_page_gestionGG.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // icon_mdp
            // 
            this.icon_mdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icon_mdp.Image = ((System.Drawing.Image)(resources.GetObject("icon_mdp.Image")));
            this.icon_mdp.Location = new System.Drawing.Point(783, 368);
            this.icon_mdp.Name = "icon_mdp";
            this.icon_mdp.Size = new System.Drawing.Size(31, 29);
            this.icon_mdp.TabIndex = 7;
            this.icon_mdp.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(783, 223);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 29);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // icon_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1381, 724);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.icon_mdp);
            this.Controls.Add(this.titre_page_gestionGG);
            this.Controls.Add(this.btn_seConnecter);
            this.Controls.Add(this.txb_mdp);
            this.Controls.Add(this.txb_identifiant);
            this.Controls.Add(this.lb_motDePasse);
            this.Controls.Add(this.lb_identifiant);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "icon_user";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_mdp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_identifiant;
        private System.Windows.Forms.Label lb_motDePasse;
        private Guna.UI2.WinForms.Guna2TextBox txb_identifiant;
        private Guna.UI2.WinForms.Guna2TextBox txb_mdp;
        private Guna.UI2.WinForms.Guna2Button btn_seConnecter;
        private System.Windows.Forms.Label titre_page_gestionGG;
        private System.Windows.Forms.PictureBox icon_mdp;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

