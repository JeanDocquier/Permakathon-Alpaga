using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PermaFungi.DAL.Repositories;
using PermaFungi.DAL.Models;

namespace PermaFungiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddUser()
        {
            // Arrange
            string connexion = "Persist Security Info=False;User ID=AlpagaUser;Password=AlpagaUser;Initial Catalog=Alpaga;Server=192.168.0.100\\HACKATHON";

            User utilisateur = new User();

            // Act
            var Cxt = new UserRepository(connexion);
            var result = Cxt.Insert(utilisateur);

            // Assert
            Assert.AreNotEqual(result.IdUser,utilisateur.IdUser);
        }
    }
}
