using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TP3.Models;

namespace TP3.Controllers {
    [Authorize]
    public class HomeController : Controller {

        [Authorize]
        public ActionResult Index(string error = null, string aspxerrorpath = null) {
            if (Session == null) {
                return RedirectToAction("Login", "Members");
            } else {
                if (aspxerrorpath != null) {
                ViewBag.error = "\""+aspxerrorpath + "\" n'est pas un chemin valide.\n+ "+ error;
                } else {
                    ViewBag.error = error;
                }
                Dal dal = new Dal();
                ViewBag.listeLivre = dal.FindAllLivre();
                ViewBag.role = Session["Role"];
                return View();
            }

        }

        [Authorize]
        public ActionResult AjouterLivre(string error=null) {
            if (Session == null || !"admin".Equals(Session["Role"])) {
                if (Session != null) FormsAuthentication.RedirectToLoginPage();
                return RedirectToAction("Login", "Members");
            } else {
                ViewBag.error = error;
                return View();
            }
        }

        [Authorize]
        public ActionResult AjouterLivreAction(string isbn = null, string author = null, string title = null, int nbPages = 0, string edition = null, int year = 0, string language = null, string description = null, string keywords = null) {
            if (Session == null || !"admin".Equals(Session["Role"])) {
                if (Session != null) FormsAuthentication.RedirectToLoginPage();
                return RedirectToAction("Login", "Members");
            } else {
                Dal dal = new Dal();
                System.Diagnostics.Debug.WriteLine(isbn + "," + author + "," + title + "," + nbPages + "," + edition + "," + year + "," + language + "," + description + "," + keywords);
                if (dal.CreateLivre(isbn, author, title, nbPages, edition, year, language, description, keywords)) {
                    return RedirectToAction("Index", "Home");
                } else {
                    return RedirectToAction("AjouterLivre", "Home", new { error = "Il y a eu une erreur lors de l'ajout du livre." });
                }
            }
        }

        [Authorize]
        public ActionResult SupprimerLivreAction(string isbn = null) {
            if (Session == null || !"admin".Equals(Session["Role"])) {
                if (Session != null) FormsAuthentication.RedirectToLoginPage();
                return RedirectToAction("Login", "Members");
            } else {
                Dal dal = new Dal();
                if (dal.DeleteLivre(isbn)) {
                    return RedirectToAction("Index", "Home");
                } else {
                    return RedirectToAction("Index", "Home", new { error = "Il y a eu une erreur lors de a suppression du livre." });
                }
            }
        }

        [Authorize]
        public ActionResult ModifierLivreAction(string isbn = null, string author = null, string title = null, int nbPages = 0, string edition = null, int year = 0, string language = null, string description = null, string keywords = null) {
            if (Session == null || !"admin".Equals(Session["Role"])) {
                if (Session != null) FormsAuthentication.RedirectToLoginPage();
                return RedirectToAction("Login", "Members");
            } else {
                System.Diagnostics.Debug.WriteLine(isbn + "," + author + "," + title + "," + nbPages + "," + edition + "," + year + "," + language + "," + description + "," + keywords);

                Dal dal = new Dal();
                if (dal.UpdateLivre(isbn, author, title, nbPages, edition, year, language, description, keywords)) {
                    return RedirectToAction("Index", "Home");
                } else {
                    return RedirectToAction("Index", "Home", new { error = "Il y a eu une erreur lors de a modification du livre." });
                }
            }

        }
    }
}
