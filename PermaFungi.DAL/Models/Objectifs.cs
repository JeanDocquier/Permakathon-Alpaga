using PermaFungi.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Models
{
    public class Objectifs : IEntity<int>
    {
        private int _idObjectifs;
        private double _prevision;
        private DateTime _datePrevision;

        public int IdObjectifs
        {
            get
            {
                return _idObjectifs;
            }
            set
            {
                _idObjectifs = value;
            }
        }

        public double Prevision
        {
            get { return _prevision; }
            set
            {
                _prevision = value;
            }
        }

        public DateTime DatePrevision
        {
            get
            {
                return _datePrevision;
            }
            set
            {
                _datePrevision = value;
            }
        }

        public int Id
        {
            get
            {
                return _idObjectifs;
            }
        }
    }

}