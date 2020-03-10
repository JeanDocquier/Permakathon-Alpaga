using PermaFungi.DAL.Infra;
using PermaFungi.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Models
{
    public class Offre : IEntity<CompositeKey<int, int>>
    {
        private int _idPermaFungi;
        private int _idFormation;

        public int IdPermaFungi { get => _idPermaFungi; set => _idPermaFungi = value; }
        public int IdFormation { get => _idFormation; set => _idFormation = value; }

        public CompositeKey<int, int> Id
        {
            get
            {
                return new CompositeKey<int, int>() { PK1 = IdPermaFungi, PK2 = IdFormation };
            }
        }

    }
}
