using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GREEN_GOOD
{
    public partial class icon_user : Form
    {

        public icon_user()
        {
            InitializeComponent();
            string mysqlCon = "server= 127.0.0.1; user=root; database=greengood; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connexion réussi");

            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
         
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_motDePasse_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=greengood; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            string loginEmploye = txb_identifiant.Text.Trim();
            string mdp = txb_mdp.Text.Trim();

            if (String.IsNullOrEmpty(loginEmploye) || String.IsNullOrEmpty(mdp))
            {
                MessageBox.Show("Erreur du mot de passe ou de l'identifiant");
            }
            else
            {
                try
                {
                    mySqlConnection.Open();
                    // MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM employes WHERE loginEmploye = @login AND mdp = @mdp", mySqlConnection);
                     MySqlCommand mySqlCommand = new MySqlCommand("SELECT idEmploye FROM employes WHERE loginEmploye = @login AND mdp = @mdp", mySqlConnection);

                    mySqlCommand.Parameters.AddWithValue("@login", loginEmploye);
                    mySqlCommand.Parameters.AddWithValue("@mdp", mdp);

                    object result = mySqlCommand.ExecuteScalar();
                    if (result != null)
                    {
                        int userId = Convert.ToInt32(result);
                        SessionManager.SetLoggedInUserId(userId);




                        //MySqlDataReader reader = mySqlCommand.ExecuteReader();

                        //if (reader.Read())
                        // {

                        //  int employeeID = Convert.ToInt32(reader["idEmploye"]);//Id de la bdd
                        //SessionManager.EmployeeID = employeeID;

                        // Autres actions après l'authentification réussie


                        //Produits nouvelleForme = new Produits(); 
                        //this.Hide();
                        //nouvelleForme.Show();


                        // object idEmploye = mySqlCommand.ExecuteScalar(); // Exécutez une requête pour obtenir l'identifiant de l'employé

                        //if (idEmploye != null)
                        //{
                        //int employeeID = Convert.ToInt32(idEmploye);
                        // Vous avez maintenant l'identifiant de l'employé, vous pouvez l'utiliser pour effectuer des opérations ultérieure


                        Form2 nouvelleForme = new Form2();
                        this.Hide();
                        nouvelleForme.Show();

                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe invalide");
                    }

                   // reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion : " + ex.Message);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }



                private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txb_identifiant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
