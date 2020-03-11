using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PermaFungi.DAL.Repositories;
using PermaFungi.DAL.Models;
using System.Collections.Generic;
using PermaFungi.DAL.Infra;

namespace PermaFungiTest
{
    [TestClass]
    public class TestVends
    {
        private string connexion = "Persist Security Info=False;User ID=AlpagaUser;Password=AlpagaUser;Initial Catalog=Alpaga;Server=192.168.0.100\\HACKATHON";
        [TestMethod]
        public void TestMethod1()
        {
            var Cxt = new VendsRepository(connexion);

            var vente = new Vends
            {
                DateVente = new DateTime(),
                IdPermaFungi = 1,
                IdProduit = 2
            };

            CompositeKey<int, int> id = new CompositeKey<int, int> { PK1 =2 , PK2 = 2 };

            Assert.IsNotNull(Cxt.GetOne(id));
        }
    }
}
