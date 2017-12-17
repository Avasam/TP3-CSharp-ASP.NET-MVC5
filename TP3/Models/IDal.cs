using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Models
{
    interface IDal : IDisposable
    {
        void createUser(string username,string password,string email);
        User findbyemail(string email);
        User findbyusername(string username);
        List<Livre> findAllLivres();
        void createLivre(string isbn,string author, string title, int nbPages, string edition, int year, string language, string description, string keywords);
    }
}