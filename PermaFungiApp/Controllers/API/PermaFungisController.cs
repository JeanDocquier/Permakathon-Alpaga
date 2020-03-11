using PermaFungi.DAL.Models;
using PermaFungi.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PermaFungiApp.Controllers.API
{
    public class PermaFungisController : ApiController
    {
        private string connexion = "Persist Security Info=False;User ID=AlpagaUser;Password=AlpagaUser;Initial Catalog=Alpaga;Server=192.168.0.100\\HACKATHON";

        public HttpResponseMessage Get()
        {
            PermaFungiRepository PFRepo = new PermaFungiRepository(connexion);
            var PF = PFRepo.GetAll().ToList();
            return Request.CreateResponse(HttpStatusCode.OK, PF);
        }

        public HttpResponseMessage Get(int id)
        {
            PermaFungiRepository PFRepo = new PermaFungiRepository(connexion);
            var result = PFRepo.GetOne(id);
            if (result != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "PermaFungi with ID: " + id.ToString() + "not found");
            }
        }
        //create
        public HttpResponseMessage Post([FromBody] PermaFungiClass PF)
        {
            try
            {
                PermaFungiRepository PFRepo = new PermaFungiRepository(connexion);
                PFRepo.Insert(PF);
                return Request.CreateResponse(HttpStatusCode.Created, PF);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        //update
        public HttpResponseMessage Put([FromBody]PermaFungiClass PF)
        {
            try
            {
                PermaFungiRepository PFRepo = new PermaFungiRepository(connexion);
                if (PF == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "PermaFungi Not Found");
                }
                PFRepo.Update(PF);
                return Request.CreateResponse(HttpStatusCode.OK, PF);
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
                PermaFungiRepository PFRepo = new PermaFungiRepository(connexion);
                var PFToDelete = PFRepo.GetOne(id);
                if (PFToDelete == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "PermaFungi with ID: " + id.ToString() + "not found");
                PFRepo.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
