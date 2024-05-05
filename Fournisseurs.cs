using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
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
    public partial class Fournisseurs : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=greengood; password=");
        private DataTable dataTable = new DataTable();

        public Fournisseurs()
        {
            InitializeComponent();

            dataGridViewFournisseurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //SELECTION MODE
            dataGridViewFournisseurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFournisseurs.MultiSelect = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            // Initialisation de la connexion
            mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=greengood; password=");
            mySqlConnection.Open();

            // Requête d'insertion avec l'ID du fournisseur
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fournisseurs (nomFournisseur, email, telephone, paysApprovisionement, dateAjout) VALUES (@nomFournisseur, @email, @telephone, @paysApprovisionement, @date)", mySqlConnection);

            cmd.Parameters.AddWithValue("@nomFournisseur", txbNom.Text);
            cmd.Parameters.AddWithValue("@email", txbEmail.Text);
            cmd.Parameters.AddWithValue("@telephone", (txbTelephone.Text));
            cmd.Parameters.AddWithValue("@paysApprovisionement", txbPays.Text);
            cmd.Parameters.AddWithValue("@dateAjout", txbDate.Text);


            cmd.ExecuteNonQuery();

            mySqlConnection.Close();

            MessageBox.Show("Produit ajouté avec succès");

            // Mettre à jour les noms de colonnes dans le DataGridView après avoir ajouté le fournisseur
            BindData();

        }

        void BindData()
        {
            MySqlCommand command = new MySqlCommand("select idFournisseur, nomFournisseur, email, telephone, paysApprovisionement from fournisseurs ", mySqlConnection);
            MySqlDataAdapter sd = new MySqlDataAdapter(command);
            DataTable database = new DataTable();
            sd.Fill(database);
            // La source de données du DataGridView
            dataGridViewFournisseurs.DataSource = database;

            // Masquer la colonne idFournisseur si nécessaire
            dataGridViewFournisseurs.Columns["idFournisseur"].Visible = false;

            // Définir les noms de colonnes dns le DataGridView
            dataGridViewFournisseurs.Columns[1].HeaderText = "idFournisseur";
            dataGridViewFournisseurs.Columns[2].HeaderText = "Nom";
            dataGridViewFournisseurs.Columns[3].HeaderText = "E-mail";
            dataGridViewFournisseurs.Columns[4].HeaderText = "Téléphone";
            //dataGridViewFournisseurs.Columns[5].HeaderText = "Pays approvisionnement";
            //dataGridViewFournisseurs.Columns[5].HeaderText = "Date";

           /* foreach (DataRow row in dataTable.Rows)
            {
                if (!row.IsNull("dateAjout"))
                {
                    DateTime dateAjout;
                    if (DateTime.TryParse(row["dateAjout"].ToString(), out dateAjout))
                    {
                        row["dateAjout"] = dateAjout.ToString("yyyy-MM-dd");
                    }
                }
            }*/
        }


/*
public void AjouterDate(DataGridView dataGridViewFournisseurs, DataTable dataTable)
    {
        // Ajouter la date actuelle dans la colonne "Date" du DataGridView
        dataGridViewFournisseurs.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
        dataGridViewFournisseurs.Rows[dataGridViewFournisseurs.Rows.Count - 1].Cells["Date"].Value = DateTime.Now.ToString("yyyy-MM-dd");

        // Ajouter la date actuelle dans la colonne "dateAjout" de la DataTable
        foreach (DataRow row in dataTable.Rows)
        {
            if (row.IsNull("dateAjout"))
            {
                row["dateAjout"] = new MySqlDateTime(DateTime.Now);

                }
            }

        // Mettre à jour la source de données du DataGridView si nécessaire
        dataGridViewFournisseurs.DataSource = null; // Définir la source de données sur null pour actualiser
        dataGridViewFournisseurs.DataSource = dataTable; // Réaffecter la source de données pour refléter les modifications
    }
        */

    private void linkLbProduits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 nouvelleForme = new Form2();
            this.Hide();
            nouvelleForme.Show();
        }

        private void linkLbFournisseurs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Fournisseurs nouvelleForme = new Fournisseurs();
            this.Hide();
            nouvelleForme.Show();
        }

        private void Fournisseurs_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (dataGridViewFournisseurs.SelectedRows.Count > 0)
            {

               // mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=greengood; password=");
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Fournisseurs SET nomFournisseur = @nom, email = @email, telephone = @telephone, paysApprovisionement = @pays  WHERE idFournisseur = @idFournisseur", mySqlConnection);

                DataGridViewRow selectedRow = dataGridViewFournisseurs.SelectedRows[0];
                int rowindex = selectedRow.Index;

                int idFournisseur = Convert.ToInt32(selectedRow.Cells["idFournisseur"].Value);

                cmd.Parameters.AddWithValue("@nom", txbNom.Text);
                cmd.Parameters.AddWithValue("@email", txbEmail.Text);
                cmd.Parameters.AddWithValue("@telephone", txbTelephone.Text);
                cmd.Parameters.AddWithValue("@pays", txbPays.Text);
               // cmd.Parameters.AddWithValue("@date", txbDate.Text);
                cmd.Parameters.AddWithValue("@idFournisseur", idFournisseur);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Fournisseur modifié avec succès");
                mySqlConnection.Close();

                 //Mettre à jour la ligne sélectionnée dans la DataGridView avec les nouvelles valeurs
                dataGridViewFournisseurs.SelectedRows[0].Cells["nomFournisseur"].Value = txbNom.Text;
                dataGridViewFournisseurs.SelectedRows[0].Cells["email"].Value = txbEmail.Text;
                dataGridViewFournisseurs.SelectedRows[0].Cells["telephone"].Value = txbTelephone.Text;
                dataGridViewFournisseurs.SelectedRows[0].Cells["paysApprovisionement"].Value = txbPays.Text;
               // dataGridViewFournisseurs.SelectedRows[0].Cells["dateAjout"].Value = txbDate.Text;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.");
            }

        }

        private int idFournisseur;
        private void dataGridViewFournisseurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string nom = dataGridViewFournisseurs.SelectedRows[0].Cells["nomFournisseur"].Value.ToString();
            string email = dataGridViewFournisseurs.SelectedRows[0].Cells["email"].Value.ToString();
            string telephone = dataGridViewFournisseurs.SelectedRows[0].Cells["telephone"].Value.ToString();
            string pays = dataGridViewFournisseurs.SelectedRows[0].Cells["paysApprovisionement"].Value.ToString();
       //     string date = dataGridViewFournisseurs.SelectedRows[0].Cells["dateAjout"].Value.ToString();


            txbNom.Text = nom;
            txbEmail.Text = email;
            txbTelephone.Text = telephone;
            txbPays.Text = pays;
            //txbDate.Text = date;


        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewFournisseurs.SelectedRows.Count > 0)
            {
                // Récupérer le nom du fournisseur à partir de la ligne sélectionnée
                string nomFournisseur = dataGridViewFournisseurs.SelectedRows[0].Cells["nomFournisseur"].Value.ToString();

                // Ouvrir la connexion à la base de données
                using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1; user=root; database=greengood; password="))
                {
                    connection.Open();

                    // Supprimer d'abord les produits associés au fournisseur
                    string deleteProduitsQuery = "DELETE FROM produits WHERE idFournisseur IN (SELECT idFournisseur FROM fournisseurs WHERE nomFournisseur = @nomFournisseur)";
                    MySqlCommand deleteProduitsCmd = new MySqlCommand(deleteProduitsQuery, connection);
                    deleteProduitsCmd.Parameters.AddWithValue("@nomFournisseur", nomFournisseur);
                    deleteProduitsCmd.ExecuteNonQuery();

                    // Ensuite, supprimer le fournisseur
                    string deleteFournisseurQuery = "DELETE FROM fournisseurs WHERE nomFournisseur = @nomFournisseur";
                    MySqlCommand deleteFournisseurCmd = new MySqlCommand(deleteFournisseurQuery, connection);
                    deleteFournisseurCmd.Parameters.AddWithValue("@nomFournisseur", nomFournisseur);
                    deleteFournisseurCmd.ExecuteNonQuery();

                    // Fermer la connexion à la base de données
                    connection.Close();

                    // Supprimer la ligne sélectionnée du DataGridView
                    dataGridViewFournisseurs.Rows.RemoveAt(dataGridViewFournisseurs.SelectedRows[0].Index);

                    MessageBox.Show("Fournisseur supprimé avec succès.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
            }
            BindData();


        }
    }
}
