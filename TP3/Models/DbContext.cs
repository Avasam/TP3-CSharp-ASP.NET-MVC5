using System;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace TP3.Models {

    public class DbContext
    {
        protected static MySqlConnection connection;
        public DbContext()
        {
            //récupère la chaîne de connection dans le fichier Web.config (ou App.config pour les tests)
            string cs = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

            try
            {
                connection = new MySqlConnection(cs);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }

        }

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }

}