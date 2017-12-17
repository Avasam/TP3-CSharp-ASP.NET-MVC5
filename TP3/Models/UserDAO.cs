using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace TP3.Models
{
    public class UserDAO
    {
        private User user;
        private MySqlConnection conn;

        public UserDAO(MySqlConnection p_conn)
        {
            conn = p_conn;
        }

        public void createUser(User u)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO USER(USERNAME, PASSWORD, EMAIL) VALUES(@USERNAME, @PASSWORD, @EMAIL)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@USERNAME", u.username);
                cmd.Parameters.AddWithValue("@PASSWORD", u.password);
                cmd.Parameters.AddWithValue("@EMAIL", u.password);

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }

        public User findbyemail(String email)
        {
            MySqlDataReader rdr = null;

            string stm = "SELECT * FROM USER WHERE EMAIL =" + email;

            try
            {
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    user = new User(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2));
             
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }

            return user;
        }
        public User findbyusername(String username)
        {
            MySqlDataReader rdr = null;

            string stm = "SELECT * FROM USER WHERE EMAIL =" + username;

            try
            {
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    user = new User(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2));

                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }

            return user;
        }

    }


}