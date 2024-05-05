using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GREEN_GOOD
{
    public partial class Historique : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=greengood; password=");
        MySqlDataAdapter adapt;
        public Historique()
        {
            InitializeComponent();
             DisplayData();

             dataGridViewHistoriques.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

             //SELECTION MODE
             dataGridViewHistoriques.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
             dataGridViewHistoriques.MultiSelect = false;
         }
         private void DisplayData()
         {

             try
             {
                 mySqlConnection.Open();
                 DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("SELECT hs.idHistorique, hs.dateModif, hs.quantiteOld, hs.quantiteNow, p.nomProduit AS Article, e.prenomEmploye AS Employe FROM historiquestock hs INNER JOIN produits p ON hs.idProduit = p.idProduit INNER JOIN employes e ON hs.idEmploye = e.idEmploye", mySqlConnection);

                adapt = new MySqlDataAdapter(cmd); 
                 adapt.Fill(dt); // Remplissage de la DataTable avec les données de la base de données

                 dataGridViewHistoriques.DataSource = dt; // Définir la source de données de votre DataGridView sur la DataTable remplie

                 // Cache la colonne id s'il existe
                 if (dataGridViewHistoriques.Columns.Contains("idHistorique") && dataGridViewHistoriques.Columns["idHistorique"] != null)
                 {
                     dataGridViewHistoriques.Columns["idHistorique"].Visible = false;
                 }

                 // Définir les noms de colonnes dans le DataGridView
                 dataGridViewHistoriques.Columns[0].HeaderText = "idHistorique";
                dataGridViewHistoriques.Columns[1].HeaderText = "Date";
                dataGridViewHistoriques.Columns[2].HeaderText = "Ancienne quantité";
                dataGridViewHistoriques.Columns[3].HeaderText = "Nouvelle quantité";
                dataGridViewHistoriques.Columns[4].HeaderText = "Article";
                dataGridViewHistoriques.Columns[5].HeaderText = "idEmploye";
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Erreur lors de l'affichage de l'historique : " + ex.Message);
             }
             finally
             {
                 mySqlConnection.Close();
             }



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

         private void linkLbProduits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             Form2 nouvelleForme = new Form2();
             this.Hide();
             nouvelleForme.Show();
         }

        }

    }
