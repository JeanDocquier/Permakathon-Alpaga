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

namespace PermaFungiApp.Controllers.API
{
    public class UsersController : ApiController
    {
        private string connexion = "Persist Security Info=False;User ID=AlpagaUser;Password=AlpagaUser;Initial Catalog=Alpaga;Server=192.168.0.100\\HACKATHON";

        public HttpResponseMessage Get()
        {
            UserRepository UserRepo = new UserRepository(connexion);
            var user = UserRepo.GetAll().ToList();
            return Request.CreateResponse(HttpStatusCode.OK, user);
        }

        public HttpResponseMessage Get(int id)
        {
            UserRepository UserRepo = new UserRepository(connexion);
            var result = UserRepo.GetOne(id);
            if (result != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "User with ID: " + id.ToString() + "not found");
            }
        }
        //create
        public HttpResponseMessage Post([FromBody] User user)
        {
            try
            {
                UserRepository UserRepo = new UserRepository(connexion);
                UserRepo.Insert(user);
                return Request.CreateResponse(HttpStatusCode.Created, user);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        //update
        public HttpResponseMessage Put([FromBody]User user)
        {
            try
            {
                UserRepository UserRepo = new UserRepository(connexion);
                if(user == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "User Not Found");
                }
                UserRepo.Update(user);
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage delete(int id)
        {
            try
            {
                UserRepository UserRepo = new UserRepository(connexion);
                var userToDelete = UserRepo.GetOne(id);
                if (userToDelete == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User with ID: " + id.ToString() + "not found");
                UserRepo.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
