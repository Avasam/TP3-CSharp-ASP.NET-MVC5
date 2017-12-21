using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP3.Models;
using MySql.Data.MySqlClient;

namespace TP3.Tests.Models
{
    /// <summary>
    /// Description résumée pour TestDAOUser
    /// </summary>
    [TestClass]
    public class TestDAOUser
    {
        
        

        public TestDAOUser()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active, ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {

            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestCreateUser()
        {
            // Arrange
            string username = "bob";
            string password = "allo";
            string email = "moi@moi.com";
            string role = "user";

            //act
            MySqlConnection cnx = new MySqlConnection();
            cnx.Open();
            User u = new User(username, password, email, role);
            UserDAO dao = new UserDAO(cnx);

            //assert
            Assert.AreEqual(true, dao.CreateUser(u));

        }

        [TestMethod]
        public void TestFindUserByEmail()
        {
            // Arrange
            string username = "bob";
            string password = "allo";
            string email = "moi@moi.com";
            string role = "user";

            //act
            User u = new User(username, password, email, role);
            MySqlConnection cnx = new MySqlConnection();
            cnx.Open();
            UserDAO dao = new UserDAO(cnx);
            dao.CreateUser(u);
            //assert
            Assert.AreEqual(u, dao.FindUserByEmail(email));

        }

        [TestMethod]
        public void TestFindUserByUsernName()
        {
            // Arrange
            string username = "bob";
            string password = "allo";
            string email = "moi@moi.com";
            string role = "user";

            //act
            User u = new User(username, password, email, role);
            MySqlConnection cnx = new MySqlConnection();
            cnx.Open();
            UserDAO dao = new UserDAO(cnx);
            dao.CreateUser(u);
            //assert
            Assert.AreEqual(u, dao.FindUserByUsername(username));

        }


    }
}
