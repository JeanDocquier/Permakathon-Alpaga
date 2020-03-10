using PermaFungi.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Models
{
    public class Produit : IEntity<int>
    {
        private int _idProduit;
        private string _nomProduit;
        private int _quantite;
        private double _prix;
        private string _description;

        public int IdProduit 
        {
            get
            {
                return _idProduit;
            }
            set
            {
                _idProduit= value;
            }
        }


        public string NomProduit
        {
            get
            {
                return _nomProduit;
            }
            set
            {
                _nomProduit = value;
            }
        }

        public int Quantite
        {
            get
            {
                return _quantite;
            }
            set
            {
                _quantite = value;
            }
        }

        public double Prix
        {
            get
            {
                return _prix;
            }
            set
            {
                _prix = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        public int Id
        {
        get
        {
         return _idProduit;
        }
        }

     
}
}
