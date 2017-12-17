using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP3.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.listeLivre = new List<Livre>(); //ObtenirListeLivre();
            return View();
        }

        public ActionResult AjouterLivre() {
            return View();
        }

        // Services
        //public List<Livre> ObtenirListeLivre() {
        //    List<Livre> ListeLivre = dao.findAll();
        //    return ListeLivre;
        //}

        //public bool AjouterLivre(string isbn, string author, string title, int nbPages, string edition, int year, string language, string description, string keywords) {
        //    Livre livre = new Livre(isbn, author, title, nbPages, edition, year, language, description, keywords);

        //    return dao.create(livre);
        //}

    }
}