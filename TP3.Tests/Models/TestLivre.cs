using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP3.Models;

namespace TP3.Tests.Models
{
    /// <summary>
    /// Description résumée pour TestLivre
    /// </summary>
    [TestClass]
    public class TestLivre
    {
        public TestLivre()
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
        public void TestLivreGetterSetter()
        {
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
            Livre l = new Livre(isbn,author,title,nbPages,edition,year,language,description,keywords);

            //assert
            Assert.AreEqual("1234",l.isbn);
            Assert.AreEqual("bob", l.author);
            Assert.AreEqual("livre", l.title);
            Assert.AreEqual(5, l.nbPages);
            Assert.AreEqual("voiture", l.edition);
            Assert.AreEqual(3005, l.year);
            Assert.AreEqual("kazakh", l.language);
            Assert.AreEqual("blabla", l.description);
            Assert.AreEqual("borat", l.keywords);
        }
    }
}
