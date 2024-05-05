namespace GREEN_GOOD
{
    partial class Historique
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_deconnexion = new System.Windows.Forms.Label();
            this.linkLbHistorique = new System.Windows.Forms.LinkLabel();
            this.linkLbProduits = new System.Windows.Forms.LinkLabel();
            this.linkLbFournisseurs = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewHistoriques = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoriques)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(614, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historiques des stocks";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(77)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-54, -17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 117);
            this.panel1.TabIndex = 57;
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
            // linkLbHistorique
            // 
            this.linkLbHistorique.AutoSize = true;
            this.linkLbHistorique.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbHistorique.LinkColor = System.Drawing.Color.White;
            this.linkLbHistorique.Location = new System.Drawing.Point(76, 137);
            this.linkLbHistorique.Name = "linkLbHistorique";
            this.linkLbHistorique.Size = new System.Drawing.Size(100, 27);
            this.linkLbHistorique.TabIndex = 23;
            this.linkLbHistorique.TabStop = true;
            this.linkLbHistorique.Text = "Historique";
            this.linkLbHistorique.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbHistorique_LinkClicked);
            // 
            // linkLbProduits
            // 
            this.linkLbProduits.AutoSize = true;
            this.linkLbProduits.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbProduits.LinkColor = System.Drawing.Color.White;
            this.linkLbProduits.Location = new System.Drawing.Point(76, 256);
            this.linkLbProduits.Name = "linkLbProduits";
            this.linkLbProduits.Size = new System.Drawing.Size(84, 27);
            this.linkLbProduits.TabIndex = 24;
            this.linkLbProduits.TabStop = true;
            this.linkLbProduits.Text = "Produits";
            this.linkLbProduits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbProduits_LinkClicked);
            // 
            // linkLbFournisseurs
            // 
            this.linkLbFournisseurs.AutoSize = true;
            this.linkLbFournisseurs.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbFournisseurs.LinkColor = System.Drawing.Color.White;
            this.linkLbFournisseurs.Location = new System.Drawing.Point(66, 379);
            this.linkLbFournisseurs.Name = "linkLbFournisseurs";
            this.linkLbFournisseurs.Size = new System.Drawing.Size(118, 27);
            this.linkLbFournisseurs.TabIndex = 25;
            this.linkLbFournisseurs.TabStop = true;
            this.linkLbFournisseurs.Text = "Fournisseurs";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(77)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.linkLbFournisseurs);
            this.panel2.Controls.Add(this.linkLbProduits);
            this.panel2.Controls.Add(this.linkLbHistorique);
            this.panel2.Controls.Add(this.lbl_deconnexion);
            this.panel2.Location = new System.Drawing.Point(-54, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 654);
            this.panel2.TabIndex = 58;
            // 
            // dataGridViewHistoriques
            // 
            this.dataGridViewHistoriques.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewHistoriques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoriques.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewHistoriques.Location = new System.Drawing.Point(172, 201);
            this.dataGridViewHistoriques.Name = "dataGridViewHistoriques";
            this.dataGridViewHistoriques.RowHeadersWidth = 51;
            this.dataGridViewHistoriques.RowTemplate.Height = 24;
            this.dataGridViewHistoriques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistoriques.Size = new System.Drawing.Size(1069, 426);
            this.dataGridViewHistoriques.TabIndex = 68;
            // 
            // Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 734);
            this.Controls.Add(this.dataGridViewHistoriques);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Historique";
            this.Text = "Historique";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoriques)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_deconnexion;
        private System.Windows.Forms.LinkLabel linkLbHistorique;
        private System.Windows.Forms.LinkLabel linkLbProduits;
        private System.Windows.Forms.LinkLabel linkLbFournisseurs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewHistoriques;
    }
}