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

        public bool CreateUser(User u)
        {
            try {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO USER(USERNAME, PASSWORD, EMAIL) VALUES(@USERNAME, @PASSWORD, @EMAIL)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@USERNAME", u.Username);
                cmd.Parameters.AddWithValue("@PASSWORD", u.Password);
                cmd.Parameters.AddWithValue("@EMAIL", u.Email);

                return cmd.ExecuteNonQuery() > 0;

            }
            catch (MySqlException ex) {
                System.Diagnostics.Debug.WriteLine("Error: {0}", ex.ToString());

            }
            return false;
        }

        public User FindUserByEmail(String email)
        {
            MySqlDataReader rdr = null;

            string stm = "SELECT * FROM USER WHERE EMAIL = @email";

            try
            {
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@email", email);
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    user = new User(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2));
             
                }

            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: {0}", ex.ToString());
            }

            return user;
        }

        public User FindUserByUsername(String username)
        {
            MySqlDataReader rdr = null;

            string stm = "SELECT * FROM USER WHERE EMAIL = @username";

            try
            {
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@username", username);
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    user = new User(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2));

                }

            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: {0}", ex.ToString());
            }

            return user;
        }

    }

}
