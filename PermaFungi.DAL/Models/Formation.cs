using PermaFungi.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Models
{
    public class Formation : IEntity<int>
    {
        private int _idFormation;
        private string _nom;
        private int _quantite;
        private double _prix;
        private int _idObjects;

        public int IdFormation { get => _idFormation; set => _idFormation = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public double Prix { get => _prix; set => _prix = value; }
        public int IdObjects { get => _idObjects; set => _idObjects = value; }
        public int Quantite { get => _quantite; set => _quantite = value; }
        public int Id { get => _idFormation; }
    }
}
