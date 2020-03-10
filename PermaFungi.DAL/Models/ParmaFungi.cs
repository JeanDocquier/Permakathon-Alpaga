using PermaFungi.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Models
{
    public class ParmaFungi : IEntity<int>
    {
        private int _idPermafungi;
        private string _ville;
        private string _adresse;
        private string _contact;
        private string _email;

        public int IdPermaFungi
        {
            get { return _idPermafungi; }
            set
            {
                _idPermafungi = value;
            }
        }

        public string Ville { get => _ville; set => _ville = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Email { get => _email; set => _email = value; }

        public int Id
        {
            get
            {
                return _idPermafungi;
            }
        }

    }
}
