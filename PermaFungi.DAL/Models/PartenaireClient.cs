using PermaFungi.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Models
{
    public class PartenaireClient : IEntity<int>
    {
        private int _idPartenaireClient;
        private string _nom;
        private string _adresse;
        private string _email;


        public int IdPartenaireClient
        {
           get { return _idPartenaireClient; }
            set
            {
                _idPartenaireClient = value;
            }
        }


        public string Nom
        {
            get { return _nom; }
            set
            {
                _nom = value;
            }
        }

        public string Adresse
        {
            get { return _adresse; }
            set
            {
                _adresse = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }

        public int Id
        {
            get
            {
                return _idPartenaireClient;
            }
        }

    }
}
