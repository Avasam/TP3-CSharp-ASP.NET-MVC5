using System;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace TP3.Models
{
    public class BddContext : DbContext {
        private UserDAO userDao;
        private LivreDAO livreDao;

        public BddContext() : base() {
            UserDao = new UserDAO(connection);
            LivreDao = new LivreDAO(connection);
        }

        public UserDAO UserDao {
            get {
                return userDao;
            }

            set {
                userDao = value;
            }

        }

        public LivreDAO LivreDao {
            get {
                return livreDao;
            }

            set {
                livreDao = value;
            }
        }
    }
}