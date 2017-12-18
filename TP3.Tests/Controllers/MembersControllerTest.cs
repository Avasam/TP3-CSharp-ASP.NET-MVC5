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
        [TestMethod]
        public void Login() {
            // Arrange
            MembersController controller = new MembersController();

            // Act
            ViewResult result = controller.Login() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void LoginAction() {
            // Arrange
            MembersController controller = new MembersController();

            // Act
            string email = "admin@admin";
            string password = "admin";
            ViewResult result = controller.LoginAction(email, password) as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Register() {
            // Arrange
            MembersController controller = new MembersController();

            // Act
            ViewResult result = controller.Register() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void RegisterAction() {
            // Arrange
            MembersController controller = new MembersController();

            // Act
            string username = "admin";
            string password = "admin";
            string email = "admin@admin";

            ViewResult result = controller.RegisterAction(username, password, email) as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void LogoutAction() {
            // Arrange
            MembersController controller = new MembersController();

            // Act
            ViewResult result = controller.LogoutAction() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }
    }
}
