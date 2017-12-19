using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3.Models;

namespace TP3.Controllers {
    [Authorize]
    public class HomeController : Controller {

        public ActionResult Index() {
            Dal dal = new Dal();
            ViewBag.listeLivre = dal.FindAllLivre();
            return View();

        }

        [Authorize(Users = "admin")]
        public ActionResult AjouterLivre() {
            return View();
        }

        [Authorize(Users = "admin")]
        public ActionResult AjouterLivreAction(string isbn=null, string author=null, string title=null, int nbPages=0, string edition=null, int year=0, string language=null, string description=null, string keywords=null) {
            Dal dal = new Dal();

            if (dal.CreateLivre(isbn, author, title, nbPages, edition, year, language, description, keywords)) {
                // Si le livre est ajouté avec succès
                return RedirectToAction("Index", "Home");
            }
            // Si l'ajout du livre échoue
            return RedirectToAction("AjouterLivre", "Home");
        }

        [Authorize(Users = "admin")]
        public ActionResult SupprimerLivreAction(string isbn = null) {
            Dal dal = new Dal();
            dal.DeleteLivre(isbn);
            return RedirectToAction("Index", "Home");
        }

        [Authorize(Users = "admin")]
        public ActionResult ModifierLivreAction(string isbn = null, string author = null, string title = null, int nbPages = 0, string edition = null, int year = 0, string language = null, string description = null, string keywords = null) {
            System.Diagnostics.Debug.WriteLine(isbn+","+ author+","+ title+","+ nbPages+","+ edition+","+ year+","+ language+","+ description+","+ keywords);

            Dal dal = new Dal();
            dal.UpdateLivre(isbn, author, title, nbPages, edition, year, language, description, keywords);
            return RedirectToAction("Index", "Home");

        }
    }
}