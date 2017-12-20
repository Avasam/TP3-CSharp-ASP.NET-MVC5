using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP3;
using TP3.Controllers;

namespace TP3.Tests.Controllers {
    [TestClass]
    public class HomeControllerTest {
        [TestMethod]
        public void Index() {
            // Arrange
            HomeController controller = new HomeController();

            // Test pour afficher la page sans erreur
            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNull(result.ViewBag.error);

            // Test pour afficher la page avec erreur
            // Act
            result = controller.Index("testerror") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("testerror", result.ViewBag.error);
        }

        [TestMethod]
        public void AjouterLivre() {
            // Arrange
            HomeController controller = new HomeController();

            // Test pour afficher la page sans erreur
            // Act
            ViewResult result = controller.AjouterLivre() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNull(result.ViewBag.error);

            // Test pour afficher la page avec erreur
            // Act
            result = controller.AjouterLivre("testerror") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("testerror", result.ViewBag.error);
        }

        [TestMethod]
        public void AjouterLivreAction() {
            // Arrange
            HomeController controller = new HomeController();

            // Test un login valide
            // Act
            RedirectToRouteResult result = controller.AjouterLivreAction("isbn", "author", "title", 100, "edition", 2017, "language", "description", "keywords") as RedirectToRouteResult;

            // Assert
            Assert.AreEqual("Home", result.RouteValues["controller"]);
            Assert.AreEqual("AjouterLivre", result.RouteValues["action"]);


            // Tester un login invalide
            // Act
            result = controller.AjouterLivreAction(null,null,null,0,null,0,null,null,null) as RedirectToRouteResult;

            // Assert
            Assert.AreEqual("Home", result.RouteValues["controller"]);
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

        [TestMethod]
        public void ModifierLivreAction() {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            RedirectToRouteResult result = controller.ModifierLivreAction("isbn", "author", "title", 100, "edition", 2017, "language", "description", "keywords") as RedirectToRouteResult;

            // Assert
            Assert.AreEqual("Home", result.RouteValues["controller"]);
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

        [TestMethod]
        public void SupprimerLivreAction() {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            RedirectToRouteResult result = controller.SupprimerLivreAction("isbn") as RedirectToRouteResult;

            // Assert
            Assert.AreEqual("Home", result.RouteValues["controller"]);
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

    }
}
