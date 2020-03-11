using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PermaFungiApp.Models
{
    public class ProduitTO
    {
        public int idProduit;
        public string nomProduit;
        public double quantite;
        public double prix;
        public string description;
        public DateTime date;
    }
}