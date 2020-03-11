using PermaFungi.DAL.Infra;
using PermaFungi.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Models
{
    public class Consomme : IEntity<CompositeKey<int, int>>
    {
        private int _idMachine;
        private int _idConsommation;
        private DateTime _dateConsomme;
        public int IdMachine { get => _idMachine; set => _idMachine= value; }
        public int IdConsommation { get => _idConsommation; set => _idConsommation = value; }

        public CompositeKey<int, int> Id
        {
            get
            {
                return new CompositeKey<int, int>() { PK1 = IdMachine, PK2 = IdConsommation };
            }
        }

        public DateTime DateConsomme { get => _dateConsomme; set => _dateConsomme = value; }
    }
}

