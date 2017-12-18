using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace TP3.Models
{
    public class LivreDAO
    {
        private List<Livre> Livres = new List<Livre>();
        private MySqlConnection conn;

        public LivreDAO(MySqlConnection p_conn)
        {
            conn = p_conn;
        }

        public List<Livre> FindAllLivre()
        {
            MySqlDataReader rdr = null;

            string stm = "SELECT * FROM book";

            try
            {
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Livres.Add(new Livre(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(3), rdr.GetString(4), rdr.GetInt32(5), rdr.GetString(6), rdr.GetString(7), rdr.GetString(8)));

                }                

            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: {0}", ex.ToString());

            }

            return Livres;
        }

        public bool CreateLivre(Livre l)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO book (ISBN , AUTHOR , TITLE, NB_PAGES, EDITION, YEAR, LANGUAGE, DESCRIPTION, KEYWORDS) VALUES (@ISBN,@AUTHOR,@TITLE,@NB_PAGES,@EDITION,@YEAR,@LANGUAGE,@DESCRIPTION,@KEYWORDS)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ISBN", l.isbn);
                cmd.Parameters.AddWithValue("@AUTHOR", l.author);
                cmd.Parameters.AddWithValue("@TITLE", l.title);
                cmd.Parameters.AddWithValue("@NB_PAGES", l.nbPages);
                cmd.Parameters.AddWithValue("@EDITION", l.edition);
                cmd.Parameters.AddWithValue("@YEAR", l.year);
                cmd.Parameters.AddWithValue("@LANGUAGE", l.language);
                cmd.Parameters.AddWithValue("@DESCRIPTION", l.description);
                cmd.Parameters.AddWithValue("@KEYWORDS", l.keywords);

                return cmd.ExecuteNonQuery() > 0;

            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: {0}", ex.ToString());
            }
            return false;

        }
    }
}