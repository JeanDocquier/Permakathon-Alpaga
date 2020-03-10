using PermaFungi.DAL.Infra;
using PermaFungi.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Models
{
    public class Vends : IEntity<CompositeKey<int, int>>
    {
        private int _idProduit;
        private int _idPermafungi;

        public int IdProduit { get => _idProduit; set => _idProduit = value; }
        public int IdPermaFungi { get => _idPermafungi; set => _idPermafungi = value; }

        public CompositeKey<int, int> Id
        {
            get
            {
                return new CompositeKey<int, int>() { PK1 = IdProduit, PK2 = IdPermaFungi };
            }
        }

    }
}
