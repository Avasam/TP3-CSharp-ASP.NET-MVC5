using System;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace TP3.Models
{
    public class BddContext : DbContext
    {
        private UserDAO users;
        private LivreDAO livres;

        public BddContext() : base()
        {
            Users = new UserDAO(connection);
            Livres = new LivreDAO(connection);
        }

        public UserDAO Users
        {
            get
            {
                return users;
            }

            set
            {
                users = value;
            }

        }

        public LivreDAO Livres
        {
            get
            {
                return livres;
            }

            set
            {
                livres = value;
            }
        }
    }
}