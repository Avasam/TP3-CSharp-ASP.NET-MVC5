using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3.Models;

namespace TP3.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            Dal dal = new Dal();
            ViewBag.listeLivre = dal.FindAllLivre();
            return View();
        }

        public ActionResult AjouterLivre() {
            return View();
        }

    }
}