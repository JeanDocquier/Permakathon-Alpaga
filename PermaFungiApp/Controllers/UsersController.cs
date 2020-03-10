using PermaFungiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using PermaFungi.DAL;
using PermaFungi.DAL.Repositories;
using PermaFungi.DAL.Models;

namespace PermaFungiApp.Controllers
{
    public class UsersController : ApiController
    {
        private string connexion = "@Data Source=HACKATHON-SRV1\\HACKATHON;User ID=AlpagaUser;Password=AlpagaUser;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        [HttpPost]
        public UserTO Login(string login, string password) {
            User utilisateur = new User() { Email=login, MotDePasse=password};
            UserTO user = new UserRepository(connexion).VerifLogin(utilisateur).ToTransferObject();
            return user;
        }
        [HttpPost]
        public UserTO Ajouter(string nom, string prenom, string email, string motDePasse, string telephone, string role)
        {
            User utilisateur = new User()
            {
                Nom = nom,
                Prenom = prenom,
                Email = email,
                MotDePasse = motDePasse,
                Telephone = telephone,
                Role = role
            };
            var Cxt = new UserRepository(connexion);
            var result = Cxt.Insert(utilisateur).ToTransferObject();
            return result;
        }
    }
}
