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
    public class MembersControllerTest {
        private static Random random = new Random();
        public static string RandomString(int length) {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [TestMethod]
        public void Login() {
            // Arrange
            MembersController controller = new MembersController();

            // Test pour afficher la page sans erreur
            // Act
            ViewResult result = controller.Login() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNull(result.ViewBag.error);

            // Test pour afficher la page avec erreur
            // Act
            result = controller.Login("testerror") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("testerror", result.ViewBag.error);
        }

        [TestMethod]
        public void Register() {
            // Arrange
            MembersController controller = new MembersController();

            // Test pour afficher la page sans erreur
            // Act
            ViewResult result = controller.Register() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNull(result.ViewBag.error);

            // Test pour afficher la page avec erreur
            // Act
            result = controller.Register("testerror") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("testerror", result.ViewBag.error);
        }

        [TestMethod]
        public void LoginAction() {
            // Arrange
            MembersController controller = new MembersController();

            // Test un login valide
            // Act
            RedirectToRouteResult result = controller.RegisterAction("admin", "admin", "admin@admin") as RedirectToRouteResult;

            // Assert
            Assert.AreEqual("Members", result.RouteValues["controller"]);
            Assert.AreEqual("Register", result.RouteValues["action"]);


            // Tester un login invalide
            // Act
            string randomString = RandomString(8);
            result = controller.RegisterAction(randomString, randomString, randomString + "@" + randomString) as RedirectToRouteResult;

            // Assert
            Assert.AreEqual("Members", result.RouteValues["controller"]);
            Assert.AreEqual("Login", result.RouteValues["action"]);
        }


        [TestMethod]
        public void RegisterAction() {
            // Arrange
            MembersController controller = new MembersController();

            // Tester créer un user qui existe déjà
            // Act
            RedirectToRouteResult result = controller.RegisterAction("admin", "admin", "admin@admin") as RedirectToRouteResult;

            // Assert
            Assert.AreEqual("Members", result.RouteValues["controller"]);
            Assert.AreEqual("Register", result.RouteValues["action"]);


            // Tester un nouveau user
            // Act
            string randomString = RandomString(8);
            result = controller.RegisterAction(randomString, randomString, randomString + "@" + randomString) as RedirectToRouteResult;

            // Assert
            Assert.AreEqual("Members", result.RouteValues["controller"]);
            Assert.AreEqual("Login", result.RouteValues["action"]);

        }

        [TestMethod]
        public void LogoutAction() {
            // Arrange
            MembersController controller = new MembersController();

            // Act
            RedirectToRouteResult result = controller.LogoutAction() as RedirectToRouteResult;

            // Assert
            Assert.AreEqual("Members", result.RouteValues["controller"]);
            Assert.AreEqual("Login", result.RouteValues["action"]);
        }
    }
}
