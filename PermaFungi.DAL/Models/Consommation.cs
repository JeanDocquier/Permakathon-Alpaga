using PermaFungi.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Models
{
    public class Consommation : IEntity<int>
    {
        private int _idConsommation;
        private string typeConsommation;
        private double prixConsommation;
        private int _idObjectifs;

        public int IdConsommation { get => _idConsommation; set => _idConsommation = value; }
        public string TypeConsommation { get => typeConsommation; set => typeConsommation = value; }
        public double PrixConsommation { get => prixConsommation; set => prixConsommation = value; }
        public int IdObjectifs { get => _idObjectifs; set => _idObjectifs = value; }

        public int Id { get => _idConsommation; }

    }
}
