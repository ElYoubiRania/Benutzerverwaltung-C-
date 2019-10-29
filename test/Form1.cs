using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using MySql.Data.Common;

namespace test
{
    public partial class Form1 : Form
    {



        //Constructeur | gestion des droits d'accès en fonction du statut de l'utilisateur 

        public Form1() {
           

        }
        public Form1( string role)
        {
            InitializeComponent();

            label1.Text = role;
            if (role == "Apprentie")
            {
               
                toolTip1.SetToolTip(button1, "vous n'avez pas le droit de faire des insertions ni de modifications");
                ajouter.Enabled = false;
                modifier.Enabled = false;
            }

            if (role == "IT Consultant")
            {
                modifier.Enabled = false;
                toolTip1.SetToolTip(ajouter, "vous n'avez pas le droit de faire des modifications");

            }

            else
            {
               
                modifier.Enabled = true;
                supprimer.Enabled = true;
                ajouter.Enabled = true; 
            }
             

                    

        }
            

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            ajout aj = new ajout();
            aj.Show(); 
        }


        //Bouton Fermer
        private void Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            maj m = new maj();
            m.Show(); 
            
            
            

        }     

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connexion = ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString;
                MySqlConnection mysqlcnx = new MySqlConnection(connexion);
                string sqlquery = " select * from categorie";
                MySqlCommand cmd = new MySqlCommand(sqlquery, mysqlcnx);
                mysqlcnx.Open();
                MySqlDataAdapter sdr = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;
                mysqlcnx.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Problème d'affichage des catégories");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            maj m = new maj();
            m.Show();
        }


        //Bouton Modifier
        /*private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                string connexion = ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString;
                MySqlConnection mysqlcnx = new MySqlConnection(connexion);
                mysqlcnx.Open();

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    
                }
               
                string sqlquery = " update categorie(IDCategorie, Titre) set ";
                MySqlCommand cmd = new MySqlCommand(sqlquery, mysqlcnx);
                
                MySqlDataAdapter sdr = new MySqlDataAdapter(cmd);

                mysqlcnx.Close();
             

             
            }

            catch (Exception)
            {
                MessageBox.Show("Problème d'affichage des catégories");
            }

        }

        //Bouton Supprimer
        private void supprimer_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                Int32 rowToDelete = this.dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);

                if (rowToDelete > -1)
                {
                    this.dataGridView1.Rows.RemoveAt(rowToDelete);
                }

            }
        }

        /* authentification at = new authentification();

         string role = at.getStatut();

         if (role == "Apprentie")
         {
             ajouter.Visible = false;

         }*/


        //string conStr = ConfigurationManager.ConnectionStrings["test.Properties.Settings.Einstellung"].ConnectionString;   


        //connectionString = "server=127.0.0.1;persistsecurityinfo=True;database=db" providerName = "System.Data.SqlClient"
        //MessageBox.Show("la connexion à la base de données a réussi");

        /* ConnectionStringSettings connexion = ConfigurationManager.ConnectionStrings["test.Properties.Settings.Einstellung"];

         string connectionString = connexion.ConnectionString;
         string sSQL = ConfigurationManager.ConnectionStrings["test.Properties.Settings.Einstellung"].ToString();*/



        //try

        /*con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM dbo.table_1");
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString());
            }

        dr.Close();
        */

        /* catch (Exception)
         {
             MessageBox.Show("Impossible de se connecter à la base de données, veuillez controler la configuration");
         }

         finally
         {
             con.Close();
         }*/






        /*string prenom = ConfigurationManager.AppSettings["prenom"];
        string nom = ConfigurationManager.AppSettings["nom"];
        MessageBox.Show("Bonjour  " + prenom +" "+ nom);
        MessageBox.Show("Bonjour  " + prenom +" "+ nom);*/





        /*MessageBox.Show(connexion.Name);
        MessageBox.Show(connexion.ConnectionString);
        //MessageBox.Show(connexion.ProviderName);*/

        /* foreach (ConnectionStringSettings valeur in ConfigurationManager.ConnectionStrings)
        {
             MessageBox.Show(valeur.ConnectionString);
         }*/



    }
}
