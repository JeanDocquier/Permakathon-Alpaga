using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PermaFungi.DAL.Repositories;
using PermaFungi.DAL.Models;

namespace PermaFungiTest
{
    [TestClass]
    public class TestPermafungi
    {
        private string connexion = "Persist Security Info=False;User ID=AlpagaUser;Password=AlpagaUser;Initial Catalog=Alpaga;Server=192.168.0.100\\HACKATHON";
        [TestMethod]
        public void GetOne()
        {
            var Cxt = new PermaFungiRepository(connexion);

            var Permafungi = new PermaFungiClass { 
             Adresse = "rue de l'espoir",
              Contact = "David",
               Email = "demo@demo.be",
                Ville = "chl"
            };
            var newPermafungi = Cxt.Insert(Permafungi);
            Assert.AreEqual(Cxt.GetOne(newPermafungi.IdPermaFungi).Ville,"chl");
        }
    }
}
