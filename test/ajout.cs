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
    public partial class ajout : Form
    {
        public ajout()
        {
            InitializeComponent();
        }

        private void Ajouter(object sender, EventArgs e)
        {
            try
            {
                string connexion = ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString;
                MySqlConnection mysqlcnx = new MySqlConnection(connexion);
                mysqlcnx.Open();
                string queryInsert = " insert into categorie(IDCategorie,Titre) values (" + Convert.ToInt32(textBox1.Text) + ",'" + textBox2.Text + "' )";
                MySqlCommand cmd = new MySqlCommand(queryInsert, mysqlcnx);
                cmd.ExecuteNonQuery();
                label3.Text = "Insertion effectuée avec succès !";
                mysqlcnx.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Erreur : Element inséré non compatible");
            }
        }

        private void Fermer(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajout_Load(object sender, EventArgs e)
        {
            Authentification a = new Authentification();
            a.Hide();
        }
    }
}
