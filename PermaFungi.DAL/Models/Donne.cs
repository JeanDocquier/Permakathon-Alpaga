using PermaFungi.DAL.Infra;
using PermaFungi.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Models
{
    public class Donne : IEntity<CompositeKey<int, int>>
    {
        private int _idUser;
        private int _idFormation;

        public int IdUser { get => _idUser; set => _idUser = value; }
        public int IdFormation { get => _idFormation; set => _idFormation = value; }

        public CompositeKey<int, int> Id
        {
            get
            {
                return new CompositeKey<int, int>() { PK1 = IdUser, PK2 = IdFormation };
            }
        }

    }
}
