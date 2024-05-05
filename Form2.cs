using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GREEN_GOOD
{
    public partial class Form2 : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=greengood; password=");
        //MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public Form2()
        {
            InitializeComponent();
            DisplayData();

            dataGridViewProduits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //SELECTION MODE
            dataGridViewProduits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduits.MultiSelect = false;
        }
        private void DisplayData()
        {
            mySqlConnection.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("SELECT p.idProduit, p.nomProduit, p.categorie, p.quantite, f.nomFournisseur AS Fournisseur FROM produits p JOIN fournisseurs f ON p.idFournisseur = f.idFournisseur", mySqlConnection);
            adapt.Fill(dt);
            dataGridViewProduits.DataSource = dt;

            dataGridViewProduits.Columns["idProduit"].Visible = false;

            dataGridViewProduits.Columns[0].HeaderText = "idProduit";
            dataGridViewProduits.Columns[1].HeaderText = "Article";
            dataGridViewProduits.Columns[2].HeaderText = "Categorie";
            dataGridViewProduits.Columns[3].HeaderText = "Quantite";
            dataGridViewProduits.Columns[4].HeaderText = "Fournisseur";

            mySqlConnection.Close();


        }

        private void ClearData()
        {
            txbArticle.Text = "";
            txbCategorie.Text = "";
            txbQuantite.Text = "";
            comboBoxFournisseur.Text = "";
        }

        private void LoadFournisseurs()
        {
            string query = "SELECT nomFournisseur FROM fournisseurs";

            try
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=greengood; password="))
                {
                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nomFournisseur = reader["nomFournisseur"].ToString();
                            comboBoxFournisseur.Items.Add(nomFournisseur);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des fournisseurs : " + ex.Message);
            }
        }


        //BOUTON AJOUTER
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            // Vérifie si le fournisseur sélectionné existe dans la base de données
            string fournisseur = comboBoxFournisseur.Text;
            string fournisseurIdQuery = "SELECT idFournisseur FROM fournisseurs WHERE nomFournisseur = @fournisseur";
            MySqlCommand fournisseurIdCmd = new MySqlCommand(fournisseurIdQuery, mySqlConnection);
            fournisseurIdCmd.Parameters.AddWithValue("@fournisseur", fournisseur);
            object fournisseurIdResult = fournisseurIdCmd.ExecuteScalar();

            if (fournisseurIdResult != null) // Si le fournisseur existe
            {
                int fournisseurId = Convert.ToInt32(fournisseurIdResult);

                // Requête d'insertion avec l'ID du fournisseur
                MySqlCommand cmd = new MySqlCommand("INSERT INTO produits (nomProduit, categorie, quantite,idFournisseur) VALUES (@nomProduit, @categorie, @quantite, @fournisseurId)", mySqlConnection);

                cmd.Parameters.AddWithValue("@nomProduit", txbArticle.Text);
                cmd.Parameters.AddWithValue("@categorie", txbCategorie.Text);
                cmd.Parameters.AddWithValue("@quantite", Convert.ToInt32(txbQuantite.Text));
                cmd.Parameters.AddWithValue("@fournisseurId", fournisseurId);
                cmd.ExecuteNonQuery();

                mySqlConnection.Close();


                MessageBox.Show("Produit ajouté avec succès");
                ClearData();
                DisplayData();
            }
        }


        private void comboBoxFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbQuantite_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCategorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbArticle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_fournisseur_Click(object sender, EventArgs e)
        {

        }

        private void lbl_quantite_Click(object sender, EventArgs e)
        {

        }

        private void lbl_categorie_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduits.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du produit à partir de la ligne sélectionnée
                int idProduit = Convert.ToInt32(dataGridViewProduits.SelectedRows[0].Cells["idProduit"].Value);

                // Ouvrir la connexion à la base de données
                using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1; user=root; database=greengood; password="))
                {
                    connection.Open();

                    // Supprimer le produit
                    string deleteProduitQuery = "DELETE FROM produits WHERE idProduit = @idProduit";
                    MySqlCommand deleteProduitCmd = new MySqlCommand(deleteProduitQuery, connection);
                    deleteProduitCmd.Parameters.AddWithValue("@idProduit", idProduit);
                    deleteProduitCmd.ExecuteNonQuery();

                    // Fermer la connexion à la base de données
                    connection.Close();



                    MessageBox.Show("Produit supprimé avec succès.");
                    ClearData();
                    DisplayData();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
            }
        }


        private void dataGridViewProduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //BOUTON MODIFIER
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            {

                if (dataGridViewProduits.SelectedRows.Count > 0)
                {
                    try
                    {// Obtenez l'ID de l'employé connecté à partir de votre classe statique
                        int employeeId = SessionManager.LoggedInUserId;


                        mySqlConnection.Open();
                        // Vérifie si le fournisseur sélectionné existe dans la base de données
                        string fournisseur = comboBoxFournisseur.Text;
                        string fournisseurIdQuery = "SELECT idFournisseur FROM fournisseurs WHERE nomFournisseur = @fournisseur";
                        MySqlCommand fournisseurIdCmd = new MySqlCommand(fournisseurIdQuery, mySqlConnection);
                        fournisseurIdCmd.Parameters.AddWithValue("@fournisseur", fournisseur);
                        object fournisseurIdResult = fournisseurIdCmd.ExecuteScalar();

                        if (fournisseurIdResult != null) // Si le fournisseur existe
                        {
                            int fournisseurId = Convert.ToInt32(fournisseurIdResult);

                            // Requête de modification avec l'ID du fournisseur et du Produit
                            string updateQuery = "UPDATE produits SET nomProduit = @nomProduit, categorie = @categorie, quantite = @quantite, idFournisseur = @fournisseurId, EmployeeID = @employeeId WHERE idProduit = @idProduit";
                            MySqlCommand cmd = new MySqlCommand(updateQuery, mySqlConnection);

                            DataGridViewRow selectedRow = dataGridViewProduits.SelectedRows[0];
                            int rowindex = selectedRow.Index;
                            int idProduit = Convert.ToInt32(selectedRow.Cells["idProduit"].Value);

                            cmd.Parameters.AddWithValue("@nomProduit", txbArticle.Text);
                            cmd.Parameters.AddWithValue("@categorie", txbCategorie.Text);
                            cmd.Parameters.AddWithValue("@quantite", Convert.ToInt32(txbQuantite.Text));
                            cmd.Parameters.AddWithValue("@fournisseurId", fournisseurId);
                            cmd.Parameters.AddWithValue("@idProduit", idProduit);
                            cmd.Parameters.AddWithValue("@employeeId", employeeId); // Utilisez l'ID de l'employé connecté


                            cmd.ExecuteNonQuery();
                            mySqlConnection.Close();

                            MessageBox.Show("Produit modifié avec succès");
                            ClearData();
                            DisplayData();
                        }

                        else
                        {
                            MessageBox.Show("Le fournisseur sélectionné n'existe pas dans la base de données.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur s'est produite lors de la modification du produit : " + ex.Message);
                    }

                }
            }

        }
    

        private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void Form2_Load_1(object sender, EventArgs e)
            {
                DisplayData();
                LoadFournisseurs();
            }

        private void dataGridViewProduits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Récupére le nom du fournisseur de la ligne sélectionnée dans la DataGridView
                string fournisseur = dataGridViewProduits.SelectedRows[0].Cells["fournisseur"].Value.ToString();

                // Récupére l'ID du fournisseur à partir du nom
                int idFournisseur = GetFournisseurId(fournisseur);

                // Affiche le nom du fournisseur dans la ComboBox
                comboBoxFournisseur.Text = fournisseur;

                // Récupére les autres valeurs de la ligne sélectionnée
                string article = dataGridViewProduits.SelectedRows[0].Cells["nomProduit"].Value.ToString();
                string categorie = dataGridViewProduits.SelectedRows[0].Cells["categorie"].Value.ToString();
                string quantite = dataGridViewProduits.SelectedRows[0].Cells["quantite"].Value.ToString();

                // Affiche les valeurs dans les contrôles appropriés
                txbArticle.Text = article;
                txbCategorie.Text = categorie;
                txbQuantite.Text = quantite;
            }

           
        }



        // Méthode pour obtenir l'ID du fournisseur à partir du nom du fournisseur
        private int GetFournisseurId(string nomFournisseur)
        {
            int idFournisseur = 0;
            string fournisseurIdQuery = "SELECT idFournisseur FROM fournisseurs WHERE nomFournisseur = @nomFournisseur";

            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1; user=root; database=greengood; password="))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(fournisseurIdQuery, connection);
                command.Parameters.AddWithValue("@nomFournisseur", nomFournisseur);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    idFournisseur = Convert.ToInt32(result);
                }
            }

            return idFournisseur;
        }

        private void linkLbFournisseurs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 nouvelleForme = new Form3();
            this.Hide();
            nouvelleForme.Show();

            //Fournisseurs nouvelleForme = new Fournisseurs();
            //this.Hide();
            //nouvelleForme.Show();
        }

        private void linkLbHistorique_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int userID = SessionManager.LoggedInUserId;

            // Vérifier si l'identifiant de l'employé est égal à 1
            if (userID == 1)
            {
                // Rediriger l'utilisateur vers la page historique
                Historique historiqueForm = new Historique();
                historiqueForm.Show();
            }
            else
            {
                // Afficher un message d'erreur
                MessageBox.Show("Vous n'avez pas accès à l'historique.");
            }
        }

        private void lbl_deconnexion_Click(object sender, EventArgs e)
        {

        }

        private void linkLbDeconnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           SessionManager.ClearSession();


            foreach (Form form in Application.OpenForms)
            {
                if (form != this) // Vérifiez si la fenêtre actuelle n'est pas celle sur laquelle l'événement est déclenché
                {
                    form.Close(); // Fermez la fenêtre
                }
            }
            /*
            ConnexionGg connexionGgForm = new ConnexionGgForm();
            connexionGgForm.Show();
            this.Hide(); */
/*
            Connexion connexionForm = new Connexion(); 
            connexionForm.Show();
            this.Hide();*/
        }
    }
}


