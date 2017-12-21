using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP3.Models;

namespace TP3.Tests.Models
{
    /// <summary>
    /// Description résumée pour TestDAL
    /// </summary>
    [TestClass]
    public class TestDAL
    {
        public TestDAL()
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
            string username = "mi";
            string password = "allo";
            string email = "moi@mii.com";
            string role = "user";

            //act
           
            Dal dal = new Dal();

            //assert
            Assert.AreEqual(true,dal.CreateUser(username,password,email,role));


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
            User u = new User(username,password,email,role);
            Dal dal = new Dal();

            //assert
            Assert.AreEqual(u, dal.FindUserByEmail(email));


        }

        [TestMethod]
        public void TestFindUserByUsername()
        {
            // Arrange
            string username = "bob";
            string password = "allo";
            string email = "moi@moi.com";
            string role = "user";

            //act
            User u = new User(username, password, email, role);
            Dal dal = new Dal();

            //assert
            Assert.AreEqual(u, dal.FindUserByUsername(username));


        }

        [TestMethod]
        public void TestCreateLivre()
        {
            //arrangement
            string isbn = "1234";
            string author = "bob";
            string title = "livre";
            int nbPages = 5;
            string edition = "voiture";
            int year = 3005;
            string language = "kazakh";
            string description = "blabla";
            string keywords = "borat";

            //act
            Dal dal = new Dal();

            //assert
            Assert.AreEqual(true, dal.CreateLivre(isbn, author, title, nbPages, edition, year, language, description, keywords));


        }

        [TestMethod]
        public void TestFindAllLivre()
        {
            // Arrange
            string username = "bob";
            string password = "allo";
            string email = "moi@moi.com";
            string role = "user";

            //act
            User u = new User(username, password, email, role);
            BddContext bdd = new BddContext();
            List<Livre> list = bdd.LivreDao.FindAllLivre();
            Dal dal = new Dal();

            //assert
            Assert.AreEqual(list, dal.FindAllLivre());


        }

        [TestMethod]
        public void TestUpdateLivre()
        {
            //arrangement
            string isbn = "1234";
            string author = "bob";
            string title = "livre";
            int nbPages = 5;
            string edition = "voiture";
            int year = 3005;
            string language = "kazakh";
            string description = "blabla";
            string keywords = "borat";

            //act
            Dal dal = new Dal();

            //assert
            Assert.AreEqual(true, dal.UpdateLivre(isbn, author, title, nbPages, edition, year, language, description, keywords));


        }

        [TestMethod]
        public void TestDeleteLivre()
        {
            
            //arrangement
            string isbn = "1234";

            //act
            Dal dal = new Dal();

            //assert
            Assert.AreEqual(true, dal.DeleteLivre(isbn));


        }






    }
}
