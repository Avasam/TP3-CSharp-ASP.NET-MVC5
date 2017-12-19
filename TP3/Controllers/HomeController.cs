using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3.Models;

namespace TP3.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            //si l'utilisateur est connecté
            if (Session["User"] != null) {
                Dal dal = new Dal();
                ViewBag.listeLivre = dal.FindAllLivre();
                return View();
            } else {
                return RedirectToAction("Login", "Members");
            }

        }

        public ActionResult AjouterLivre() {
            if (Session["User"] != null) {
                return View();
            }
            return RedirectToAction("Login", "Members");
        }

        public ActionResult AjouterLivreAction(string isbn=null, string author=null, string title=null, int nbPages=0, string edition=null, int year=0, string language=null, string description=null, string keywords=null) {
            if (Session["User"] != null) {
                Dal dal = new Dal();

                if (dal.CreateLivre(isbn, author, title, nbPages, edition, year, language, description, keywords)) {
                    // Si le livre est ajouté avec succès
                    return RedirectToAction("Index", "Home");
                }
                // Si l'ajout du livre échoue
                return RedirectToAction("AjouterLivre", "Home");
            }
            // Si l'utilisateur n'est pas connecté
            return RedirectToAction("Login", "Members");
        }

        public ActionResult SupprimerLivreAction(string isbn = null) {
            if (Session["User"] != null) {
                Dal dal = new Dal();
                if (dal.DeleteLivre(isbn)) {
                }
                return RedirectToAction("Index", "Home");
            }
            // Si l'utilisateur n'est pas connecté
            return RedirectToAction("Login", "Members");
        }

        public ActionResult ModifierLivreAction(string isbn = null, string author = null, string title = null, int nbPages = 0, string edition = null, int year = 0, string language = null, string description = null, string keywords = null) {
            System.Diagnostics.Debug.WriteLine(isbn+","+ author+","+ title+","+ nbPages+","+ edition+","+ year+","+ language+","+ description+","+ keywords);

            if (Session["User"] != null) {
                Dal dal = new Dal();
                if (dal.UpdateLivre(isbn, author, title, nbPages, edition, year, language, description, keywords)) {
                }
                return RedirectToAction("Index", "Home");
            }
            // Si l'utilisateur n'est pas connecté
            return RedirectToAction("Login", "Members");
        }
    }
}