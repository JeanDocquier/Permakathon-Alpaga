using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
