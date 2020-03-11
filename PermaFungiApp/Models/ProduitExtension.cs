using PermaFungi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PermaFungiApp.Models
{
    public static class ProduitExtension
    {
        public static ProduitTO ToTransferObject(this Produit produit)
        {
            return new ProduitTO
            {
                idProduit = produit.IdProduit,
                nomProduit = produit.NomProduit,
                quantite = produit.Quantite,
                prix = produit.Prix,
                description = produit.Description,
            };
        }

        public static Produit ToEF(this ProduitTO produit)
        {
            return new Produit
            {
                IdProduit = produit.idProduit,
                NomProduit = produit.nomProduit,
                Quantite = produit.quantite,
                Prix = (float)produit.prix,
                Description = produit.description,
            };
        }
    }
}