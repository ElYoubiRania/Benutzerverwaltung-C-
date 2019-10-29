using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test
{
    static class Program
    {


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]






        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lecture du fichier app.conf avant la cnx à la BD

            GetConnectionStringByName("MaConnexion");
           // GetConnectionStringByProvider("MySql.Data.MySqlClient");
            //GetConnectionStringBycnx("server=127.0.0.1;user id=root;password=Root123!;database=db");
            //CheckConnection("MaConnexion", "MySql.Data.MySqlClientt", "server=127.0.0.1;user id=root;database=db");

            //CheckConnection("MaConnexion", "MySql.Data.MySqlClient", "server=127.0.0.1;user id=root;password=Root123!;database=db2");
            //GetConnectionStrings();
            //GetConnection();
        }



        //  1-- Lecture du ficher "app.config"

        //Extraction de la chaîne de connexion par nom


        static string GetConnectionStringByName(string name)
        {

            string returnValue = null;

            // Recherchez le nom dans la se/*ction connectionStrings.

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["MaConnexion"];        

            //Si trouvé, retourne la chaîne de connexion et lance la forme.

            if (settings != null)
            {
                returnValue = settings.ConnectionString;
                Application.Run(new Authentification());
            }
            //Sinon retourne un Message d'erreur

            else
            {
                MessageBox.Show("veuillez créer un fichier de configuration");
            }

            return returnValue;
        }








        //Extraction de la chaìne de connexion par provider

        /*static string GetConnectionStringByProvider(string providerName)
        {
            // Return null on failure.
            string returnValue = null;

            // Get the collection of connection strings.
            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

            // Walk through the collection and return the first 
            // connection string matching the providerName.
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    if (cs.ProviderName == providerName)
                        returnValue = cs.ConnectionString;
                    break;
                }
            }
            else
            {
                MessageBox.Show("veuillez créer un fichier de configuration");
            }
            return returnValue;
        }






        //Extraction de la chaîne par connectionstring

        private static string GetConnectionStringBycnx(string cnx)
        {

            string returnValue = null;

          
            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    if (cs.ConnectionString==cnx)

                        returnValue = cs.ConnectionString;
                    break;
                }
            }
            else
            {
                MessageBox.Show("veuillez créer un fichier de configuration");
            }
            return returnValue;
        }


        //  2--Obtenir la connexion du fichier App.config
        //Si erreur lors de la connextion > erreur "Impossible de se connecter à la base de données, veuillez controler la configuration"



        public static OdbcConnection GetConnection()
        {
            OdbcConnection con = new OdbcConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString;
            if (con == null)
            {
                MessageBox.Show("Erreur : Impossible de se connecter à la base de données, veuillez contrôler votre configuration");
            }
            return con;
        }







        //  3-- Lecture des parametres "app.config" 

        /*  static void GetConnectionStrings()
      {
          ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;


          if (settings != null)
          {
              foreach (ConnectionStringSettings cs in settings)
              {
                  MessageBox.Show("Nom de la base de données :  " + cs.Name + " \n" + "Le fournisseur est :    " + cs.ProviderName + "\n" + "les paramétres de connexion sont :   " +
                      cs.ConnectionString);                  
              }
          }

          else
              MessageBox.Show("veuillez creer le fichier de configuration");

      }*/












        // test avec tous les parametres du fichier

        /*static void CheckConnection(string name, string provider, string stringCnx)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    if (cs.ProviderName == provider && cs.Name == name && cs.ConnectionString == stringCnx)
                    {
                        MessageBox.Show("la connexion a réussi");
                        Application.Run(new Form1(role));
                    }

                }
            }
            else
            {
                MessageBox.Show("Veuillez creer le fichier de configuration");
            }
        }*/




















        //ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString; 


        /* static mySqlConnection databaseConnection = null;

         public static mySqlConnection getDBConnection()
         {
             if (databaseConnection == null)
             {
                 string connectionString = ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString;
                 databaseConnection = new mySqlConnection(connectionString);
             }
             return databaseConnection;

         }*/


    }
}
