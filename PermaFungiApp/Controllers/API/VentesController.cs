using PermaFungi.DAL.Infra;
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
    public class VentesController : ApiController
    {
        private string connexion = "Persist Security Info=False;User ID=AlpagaUser;Password=AlpagaUser;Initial Catalog=Alpaga;Server=192.168.0.100\\HACKATHON";

        public HttpResponseMessage Get()
        {
            VendsRepository VenteRepo = new VendsRepository(connexion);
            var user = VenteRepo.GetAll().ToList();
            return Request.CreateResponse(HttpStatusCode.OK, user);
        }

        public HttpResponseMessage Get(int idPF,int idProd)
        {
            VendsRepository VenteRepo = new VendsRepository(connexion);
            PermaFungiRepository PFRepo = new PermaFungiRepository(connexion);
            ProduitRepository prodRepo = new ProduitRepository(connexion);


            var compositKey = new CompositeKey<int,int>();
            compositKey.PK1 = PFRepo.GetOne(idPF).Id;
            compositKey.PK2 = prodRepo.GetOne(idProd).Id;
            var result = VenteRepo.GetOne(compositKey);
            if (result != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Vente with ID: " + compositKey.ToString() + "not found");
            }
        }
        //create
        public HttpResponseMessage Post([FromBody] Vends vente)
        {
            try
            {
                VendsRepository VenteRepo = new VendsRepository(connexion);
                VenteRepo.Insert(vente);
                return Request.CreateResponse(HttpStatusCode.Created, vente);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        //update
        public HttpResponseMessage Put([FromBody] Vends vente)
        {
            try
            {
                VendsRepository VenteRepo = new VendsRepository(connexion);
                if (vente == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Vente Not Found");
                }
                VenteRepo.Update(vente);
                return Request.CreateResponse(HttpStatusCode.OK, vente);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage delete(int idPF, int idProd)
        {
            try
            {
                VendsRepository VenteRepo = new VendsRepository(connexion);
                var compositKey = new CompositeKey<int, int>();
                compositKey.PK1 = idPF;
                compositKey.PK2 = idProd;
                var venteToDelete = VenteRepo.GetOne(compositKey);
                if (venteToDelete == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Vente with ID: " + compositKey.ToString() + "not found");
                VenteRepo.Delete(compositKey);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
