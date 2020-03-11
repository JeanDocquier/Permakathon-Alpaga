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
        private double _quantite;
        private double _prix;
        private string _description;
        private int _idObjectifs;
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

        public double Quantite
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

        public int IdObjectifs { get => _idObjectifs; set => _idObjectifs = value; }
    }
}
