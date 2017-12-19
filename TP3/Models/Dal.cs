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

        public bool CreateUser(string username, string password, string email, string role="user")
        {
            return bdd.UserDao.CreateUser(new User(username, password, email));
        }

        public User FindUserByEmail(string email)
        {
            return bdd.UserDao.FindUserByEmail(email);
        }

        public User FindUserByUsername(string email)
        {
            return bdd.UserDao.FindUserByUsername(email);
        }
        public List<Livre> FindAllLivre()
        {
            return bdd.LivreDao.FindAllLivre();
        }
        public bool CreateLivre(string isbn, string author, string title, int nbPages, string edition, int year, string language, string description, string keywords)
        {
            return bdd.LivreDao.CreateLivre(new Livre(isbn, author, title, nbPages, edition, year, language, description, keywords));
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public bool DeleteLivre(string isbn) {
            return bdd.LivreDao.DeleteLivre(isbn);
        }

        public bool UpdateLivre(string isbn, string author, string title, int nbPages, string edition, int year, string language, string description, string keywords) {
            return bdd.LivreDao.UpdateLivre(new Livre(isbn, author, title, nbPages, edition, year, language, description, keywords));
        }
    }

}