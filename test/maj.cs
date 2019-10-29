using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using MySql.Data.Common;

namespace test
{
    public partial class maj : Form
    {
        public maj()
        {
            InitializeComponent();
        }

        private void Maj_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            /*string connexion = ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString;
            MySqlConnection mysqlcnx = new MySqlConnection(connexion);
            mysqlcnx.Open();
            string comboReq = "select IDCategorie from categorie";
            MySqlCommand cmd = new MySqlCommand(comboReq, mysqlcnx);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
               
            }
            dr.Close();
            mysqlcnx.Close();*/

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = true;


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string connexion = ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString;
            MySqlConnection mysqlcnx = new MySqlConnection(connexion);
            mysqlcnx.Open();
            string majReq = "delete from categorie where IDCategorie = " + Convert.ToInt32(textBox3.Text) + " ";
            MySqlCommand cmd = new MySqlCommand(majReq, mysqlcnx);
            label4.Text = "Suppression effectuée avec succès !";
            cmd.ExecuteNonQuery();
            mysqlcnx.Close();
        }


        private void Button3_Click(object sender, EventArgs e)
        {


            try
            {

                string connexion = ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString;
                MySqlConnection mysqlcnx = new MySqlConnection(connexion);
                mysqlcnx.Open();
                string majReq = "UPDATE categorie SET IDCategorie = " + Convert.ToInt32(textBox1.Text) + " , Titre='" + textBox2.Text + "' where IDCategorie = " + Convert.ToInt32(textBox3.Text) + " ";
                MySqlCommand cmd = new MySqlCommand(majReq, mysqlcnx);
                cmd.ExecuteNonQuery();
                label4.Text = "Modification effectuée avec succès !";
                mysqlcnx.Close();
            }
           
            catch (Exception)
            {
                MessageBox.Show("Modification échouée ");
            }

        }
    }
}
