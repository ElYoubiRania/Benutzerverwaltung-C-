using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }


        public String statut;


        private void Authentification_Load(object sender, EventArgs e)
        {

        }
          
        private void SeConnecter()
        {
            try
            {
                string connexion = ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString;
                MySqlConnection mysqlcnx = new MySqlConnection(connexion);
                string sqlquery = " select * from users where username like '" + textBox1.Text + "' and password like '" + textBox2.Text + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlquery, mysqlcnx);
                mysqlcnx.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    Form1 F = new Form1(dt.Rows[0][3].ToString());
                    F.Show();
                    statut = dt.Rows[0][3].ToString();
                    label3.Text = "Vous êtes : " + statut;
                    this.Hide();
                   

                }
                else
                {
                    MessageBox.Show("Login ou mot de passe incorrect");
                }

               
                mysqlcnx.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Erreur de connexion");
            }

        }

        public string GetStatut()
        {
            return statut;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SeConnecter();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /*public String role()
        {

            string connexion = ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString;
            MySqlConnection mysqlcnx = new MySqlConnection(connexion);
            string sqlquery = " select * from users where username like '" + textBox1.Text + "' and password like '" + textBox2.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sqlquery, mysqlcnx);
            mysqlcnx.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);

            String statut;

            if (dt.Rows.Count == 1)
            {
                statut = dt.Rows[0][3].ToString();
                return statut;
            }
            else
                return "rien";

        }*/






    }
}
