using PermaFungi.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Models
{
    public class User : IEntity<int>
    {
        private int _idUser;
        private string _nom;
        private string _prenom;
        private string _email;
        private string _motDePasse;
        private string _role;
        private string _adresse;
        private string _telephone;
        private int _idPermaFungi;
        public int IdUser 
        {
            get
            {
                return _idUser;
            }
            set
            {
               _idUser = value;
            }
        }

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string MotDePasse
        {
            get
            {
                return _motDePasse;
            }

            set
            {
                _motDePasse = value;
            }
        }

        public string Telephone
        {
            get
            {
                return _telephone;
            }

            set
            {
                _telephone = value;
            }
        }
        public string Role
        {
            get
            {
                return _role;
            }

            set
            {
                _role = value;
            }
        }

        public string Adresse
        {
            get
            {
                return _adresse;
            }

            set
            {
                _adresse = value;
            }
        }
        public int Id
        {
            get
            {
                return _idUser;
            }
        }


        public string HashMDP
        {
            get
            {
                if (_motDePasse == null) throw new InvalidOperationException("Le mot de passe est vide");
                using (SHA512 sha512Hash = SHA512.Create())
                {

                    byte[] sourceBytes = Encoding.UTF8.GetBytes(_motDePasse);
                    byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                    string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                    return hash;
                }
            }
        }

        public int IdPermaFungi { get => _idPermaFungi; set => _idPermaFungi = value; }
    }
}
