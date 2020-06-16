using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PermaFungi.DAL.Repositories;
using PermaFungi.DAL.Models;

namespace PermaFungiTest
{
    [TestClass]
    public class TestUser
    {
        private string connexion = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = PERMAFUNGI; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private User utilisateur = new User()
        {
            Nom = "Agnaou",
            Prenom = "Tarik",
            Email = "tarik@t-knix.be",
            MotDePasse = "test",
            Adresse = "rue du test",
            Telephone = "025306235",
            Role = "comptable",
            IdPermaFungi = 1
        };

        [TestMethod]
        public void AddUser()
        {
            // Arrange
            

            // Act
            var Cxt = new UserRepository(connexion);
            var result = Cxt.Insert(utilisateur);

            // Assert
            Assert.AreEqual(result.IdUser, utilisateur.IdUser);
            Assert.AreNotEqual(0, utilisateur.IdUser);
        }

        [TestMethod]
        public void VerifPassword()
        {
            // Arrange

            // Act
            var Cxt = new UserRepository(connexion);
            var result = Cxt.VerifLogin(utilisateur);

            // Assert
            Assert.IsNotNull(result);
        }

        public void GetAll() 
        { 
            // Arrange

            // Act
        }
    }
}
