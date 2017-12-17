using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP3.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public void createUser(string username, string password, string email)
        {
            bdd.Users.createUser(new User(username,password, email));
        }

        public User findbyemail(string email)
        {
            return bdd.Users.findbyemail(email);
        }

        public User findbyusername(string email)
        {
            return bdd.Users.findbyusername(email);
        }
        public List<Livre> findAllLivres()
        {
            return bdd.Livres.findAllLivres();
        }
        public void createLivre(string isbn, string author, string title, int nbPages, string edition, int year, string language, string description, string keywords)
        {
            bdd.Livres.createLivre(new Livre(isbn, author, title, nbPages, edition, year, language, description, keywords));
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }

}