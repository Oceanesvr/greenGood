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
    public partial class Form3 : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=greengood; password=");
        MySqlDataAdapter adapt;
        public Form3()
        {
            InitializeComponent();
            DisplayData();

            dataGridViewFournisseurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //SELECTION MODE
            dataGridViewFournisseurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFournisseurs.MultiSelect = false;
        }

        private void DisplayData()
        {
            
                try
                {
                    mySqlConnection.Open();
                    DataTable dt = new DataTable();
                    MySqlCommand cmd = new MySqlCommand("select idFournisseur, nomFournisseur, email, telephone, categorie, dateAjout from fournisseurs ", mySqlConnection);
                    adapt = new MySqlDataAdapter(cmd); // adaptateur de données et associer à la commande
                    adapt.Fill(dt); // Remplissage de la DataTable avec les données de la base de données

                    dataGridViewFournisseurs.DataSource = dt; // Définir la source de données de votre DataGridView sur la DataTable remplie

                    // Cache la colonne idFournisseur s'il existe
                    if (dataGridViewFournisseurs.Columns.Contains("idFournisseur") && dataGridViewFournisseurs.Columns["idFournisseur"] != null)
                    {
                        dataGridViewFournisseurs.Columns["idFournisseur"].Visible = false;
                    }

                    // Définir les noms de colonnes dans le DataGridView
                    dataGridViewFournisseurs.Columns[0].HeaderText = "idFournisseur";
                    dataGridViewFournisseurs.Columns[1].HeaderText = "Nom";
                    dataGridViewFournisseurs.Columns[2].HeaderText = "E-mail";
                    dataGridViewFournisseurs.Columns[3].HeaderText = "Téléphone";
                    dataGridViewFournisseurs.Columns[4].HeaderText = "Catégorie";
                 dataGridViewFournisseurs.Columns[5].HeaderText = "Date";
            }
            catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'affichage des fournisseurs : " + ex.Message);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            


        }
        
        private void ClearData()
        {
            txbNom.Text = "";
            txbEmail.Text = "";
            txbTelephone.Text = "";
            txbCategorie.Text = "";
        }
        private void lbl_date_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        //BOUTON AJOUTER
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            try
            {

                mySqlConnection.Open();


                // Requête d'insertion avec l'ID du fournisseur
                MySqlCommand cmd = new MySqlCommand("INSERT INTO fournisseurs (nomFournisseur, email, telephone, categorie) VALUES (@nomFournisseur, @email, @telephone,@categorie)", mySqlConnection);

                cmd.Parameters.AddWithValue("@nomFournisseur", txbNom.Text);
                cmd.Parameters.AddWithValue("@email", txbEmail.Text);
                cmd.Parameters.AddWithValue("@telephone", txbTelephone.Text);
                cmd.Parameters.AddWithValue("@categorie", txbCategorie.Text);


                cmd.ExecuteNonQuery();

                mySqlConnection.Close();


                MessageBox.Show("Fournisseur ajouté avec succès");
                ClearData();
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du fournisseur : " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close(); 
            }
        }

        private void dataGridViewFournisseurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                // Récupére les autres valeurs de la ligne sélectionnée
                string fournisseur = dataGridViewFournisseurs.SelectedRows[0].Cells["nomFournisseur"].Value.ToString();
                string email = dataGridViewFournisseurs.SelectedRows[0].Cells["email"].Value.ToString();
                string telephone = dataGridViewFournisseurs.SelectedRows[0].Cells["telephone"].Value.ToString();
            string categorie = dataGridViewFournisseurs.SelectedRows[0].Cells["categorie"].Value.ToString();


            // Affiche les valeurs dans les contrôles appropriés
            txbNom.Text = fournisseur;
            txbEmail.Text = email;
            txbTelephone.Text = telephone;
            txbCategorie.Text = categorie;
        }

       //Methode suppression produit lier au fournisseur + fournisseur
        private void SupprimerFournisseur(int idFournisseur)
        {
            try
            {
                mySqlConnection.Open();

                // Supprimer les produits associés au fournisseur
                MySqlCommand deleteProductsCmd = new MySqlCommand("DELETE FROM produits WHERE idFournisseur = @idFournisseur", mySqlConnection);
                deleteProductsCmd.Parameters.AddWithValue("@idFournisseur", idFournisseur);
                deleteProductsCmd.ExecuteNonQuery();

                // Supprimer le fournisseur
                MySqlCommand deleteFournisseurCmd = new MySqlCommand("DELETE FROM fournisseurs WHERE idFournisseur = @idFournisseur", mySqlConnection);
                deleteFournisseurCmd.Parameters.AddWithValue("@idFournisseur", idFournisseur);
                deleteFournisseurCmd.ExecuteNonQuery();

                MessageBox.Show("Fournisseur supprimé avec succès.");

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du fournisseur : " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridViewFournisseurs.SelectedRows.Count > 0)
            {
                // Obtenir l'ID du fournisseur sélectionné dans le DataGridView
                int idFournisseur = Convert.ToInt32(dataGridViewFournisseurs.SelectedRows[0].Cells["idFournisseur"].Value);

                // Appeler la méthode pour supprimer le fournisseur
                SupprimerFournisseur(idFournisseur);

                // Rafraîchir les données dans le DataGridView après la suppression
                DisplayData();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur à supprimer.");
            }
        }

        private void linkLbProduits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 nouvelleForme = new Form2();
            this.Hide();
            nouvelleForme.Show();
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
    }
    
}
