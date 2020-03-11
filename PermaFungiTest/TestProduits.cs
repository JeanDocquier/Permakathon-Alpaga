using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PermaFungi.DAL.Models;
using PermaFungi.DAL.Repositories;

namespace PermaFungiTest
{
    [TestClass]
    public class TestProduits
    {
        private string connexion = "Persist Security Info=False;User ID=AlpagaUser;Password=AlpagaUser;Initial Catalog=Alpaga;Server=192.168.0.100\\HACKATHON";

        [TestMethod]
        public void GetAllProduits()
        {
            var ctx = new ProduitRepository(connexion);
            
             ctx.GetAll();
        }

        [TestMethod]
        public void Insert_GetOne_Update()
        {
            var ctx = new ProduitRepository(connexion);

            var produit = new Produit
            {
                Description = "test",
                IdObjectifs = 0,
                Prix = 14,
                Quantite = 1,
                NomProduit = "Essais"
            };

            var produit2 = ctx.Insert(produit);
            produit2.Quantite = 10;
            
            var done = ctx.Update(produit2);

            Assert.IsNotNull(ctx.GetOne(produit2.IdProduit));
            Assert.IsTrue(done);
            Assert.AreEqual(ctx.GetOne(produit2.IdProduit).Quantite, produit2.Quantite);
        }
    }
}
