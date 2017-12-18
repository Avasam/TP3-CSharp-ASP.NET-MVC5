using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Models
{
    interface IDal : IDisposable
    {
        bool CreateUser(string username,string password,string email);
        User FindUserByEmail(string email);
        User FindUserByUsername(string username);
        List<Livre> FindAllLivre();
        bool CreateLivre(string isbn,string author, string title, int nbPages, string edition, int year, string language, string description, string keywords);
    }
}