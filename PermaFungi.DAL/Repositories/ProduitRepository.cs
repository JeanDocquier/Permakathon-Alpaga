using PermaFungi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Repositories
{
    public class ProduitRepository : BaseRepository<Produit, int>
    {
        public ProduitRepository(string Cnstr) : base(Cnstr)
        {
            SelectOneCommand = "Select * from Produit where idProduit=@idProduit";
            SelectAllCommand = "Select * from Produit";
            InsertCommand = @"INSERT INTO  Produit (nomProduit , quantite, prix, description)
                            OUTPUT inserted.idUser VALUES(@NomProduit, @Quantite, @Prix ,@Description)";
            UpdateCommand = @"UPDATE  Produit
                           SET NomProduit = @NomProduit, Quantite = @Quantite, Prix = @Prix, Description = @description
                         WHERE IdProduit = @IdProduit;";
            DeleteCommand = @"Delete from  Produit  WHERE IdProduit = @IdProduit;";
        }


        public IEnumerable<Produit> GetByDate(DateTime dateDebut, DateTime dateFin, int idPermafungi)
        {
            SelectAllCommand = @"SELECT * FROM Vends
             INNER JOIN PermaFungi ON PermaFungi.idPermaFungi = Vends.idPermaFungi
             INNER JOIN Produit ON Produit.idProduit = Vends.idPermaFungi
             where Vends.dateVends Between @dateDebut AND @dateFin
             AND Vends.idPermaFungi = @idPermafungi;";
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("dateDebut", dateDebut);
            QueryParameters.Add("dateFin", dateFin);
            QueryParameters.Add("idPermaFungi ", idPermafungi);
            return base.getAll(Map, QueryParameters);

        } 


        public override IEnumerable<Produit> GetAll()
        {
            return base.getAll(Map);
        }

        public override Produit GetOne(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("idProduit", id);
            return base.getOne(Map, QueryParameters);
        }


        public override Produit Insert(Produit toInsert)
        {
            Dictionary<string, object> Parameters = MapToDico(toInsert);
            int id = base.Insert(Parameters);
            toInsert.IdProduit = id;
            return toInsert;
        }

        public override bool Update(Produit toUpdate)
        {
            Dictionary<string, object> Parameters = MapToDico(toUpdate);
            return base.Update(Parameters);

        }

        public override bool Delete(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("@IdProduit", id);
            return base.Delete(QueryParameters);

        }



        #region Mappers
        private Dictionary<string, object> MapToDico(Produit toInsert)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p["idProduit"] = toInsert.Id;
            p["NomProduit"] = toInsert.NomProduit;
            p["Quantite"] = toInsert.Quantite;
            p["Prix"] = toInsert.Prix;
            p["Description"] = toInsert.Description;

            return p;
        }

        private Produit Map(SqlDataReader arg)
        {
            return new Produit()
            {
                IdProduit = (int)arg["idProduit"],
                NomProduit = arg["NomProduit"].ToString(),
                Quantite = (int)arg["Quantite"],
                Prix = (double)arg["Prix"],
                Description = arg["description"].ToString(),


                //WE CAN'T STORE PASSWORD FROM DB
                // MotDePasse= arg["MotDePasse"].ToString()
            };
        }
        #endregion

    }

}