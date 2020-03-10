using System;
using PermaFungi.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PermaFungi.DAL.Repositories
{

    public class PartenaireOuClientRepository : BaseRepository<PartenaireClient, int>

    {
        public PartenaireOuClientRepository(string Cnstr) : base(Cnstr)
        {
            SelectOneCommand = "Select * from PartenaireClient where idPartenaireClient=@idPartenaireClient";
            SelectAllCommand = "Select * from PartenaireClient";
            InsertCommand = @"INSERT INTO  PartenaireClient (nom , adresse, email)
                            OUTPUT inserted.idPermaFungi VALUES(@Nom, @Adresse, @Email)";
            UpdateCommand = @"UPDATE  PartenaireClient
                           SET nom = @Nom, adresse = @Adresse,  email = @Email
                         WHERE IdPartenaireClient = @IdPartenaireClient;";
            DeleteCommand = @"Delete from  PartenaireClient  WHERE IdPartenaireClient = @IdPartenaireClient;";
        }

        public override IEnumerable<PartenaireClient> GetAll()
        {
            return base.getAll(Map);
        }

        public override PartenaireClient GetOne(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("idPermaFungi", id);
            return base.getOne(Map, QueryParameters);
        }


        public override PartenaireClient Insert(PartenaireClient toInsert)
        {
            Dictionary<string, object> Parameters = MapToDico(toInsert);
            int id = base.Insert(Parameters);
            toInsert.IdPartenaireClient = id;
            return toInsert;
        }

        public override bool Update(PartenaireClient toUpdate)
        {
            Dictionary<string, object> Parameters = MapToDico(toUpdate);
            return base.Update(Parameters);

        }

        public override bool Delete(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("@IdPermaFungi", id);
            return base.Delete(QueryParameters);

        }



        #region Mappers
        private Dictionary<string, object> MapToDico(PartenaireClient toInsert)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p["idPartenaireClient"] = toInsert.Id;
            p["nom"] = toInsert.Nom;
            p["adresse"] = toInsert.Adresse;
            p["email"] = toInsert.Email;

            return p;
        }

        private PartenaireClient Map(SqlDataReader arg)
        {
            return new PartenaireClient()
            {
                IdPartenaireClient = (int)arg["idPartenaireClient"],
                Nom = arg["Nom"].ToString(),
                Adresse = arg["Adresse"].ToString(),
                Email = arg["Email"].ToString(),
            };
        }
        #endregion


    }
}
