using PermaFungi.DAL.Models;
using PermaFungiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PermaFungi.DAL.Repositories;

namespace PermaFungiApp.Controllers
{
    public class ProduitsController : ApiController
    {
        private string connexion = "Persist Security Info=False;User ID=AlpagaUser;Password=AlpagaUser;Initial Catalog=Alpaga;Server=192.168.0.100\\HACKATHON";

        [HttpPost]
        public ProduitTO Ajouter(string nom, int quantite, double prix, string description)
        {
            var prod = new Produit { NomProduit = nom, Quantite = quantite, Prix = prix, Description = description };
            var Cxt = new ProduitRepository(connexion);
            var result = Cxt.Insert(prod).ToTransferObject();
            return result;
        }
    }
}
