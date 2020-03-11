using PermaFungi.DAL.Infra;
using PermaFungi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Repositories
{
    public class VendsRepository : BaseRepository<Vends, CompositeKey<int, int>>
    {
        public VendsRepository(string Cnstr) : base(Cnstr)
        {
            SelectOneCommand = "Select * from Vends where idProduit=@idProduit AND idPermaFungi=@idPermaFungi";
            SelectAllCommand = "Select * from Vends";
            InsertCommand = @"INSERT INTO  Vends ( idPermaFungi, idProduit , dateVends)
                             VALUES(@IdPermaFungi, @IdProduit, @DateVends)";
            UpdateCommand = @"UPDATE  Vends SET idPermaFungi = @IdPermaFungi, idProduit = @IdProduit,  dateVends = @DateVends WHERE idProduit=@idProduit AND idPermaFungi=@idPermaFungi;";
            DeleteCommand = @"Delete from  Vends  WHERE idProduit=@idProduit AND idPermaFungi=@idPermaFungi;";
        }

        public override IEnumerable<Vends> GetAll()
        {
            return base.getAll(Map);
        }

        public override Vends GetOne(CompositeKey<int, int> id)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("IdPermaFungi", id.PK1);
            Parameters.Add("IdProduit", id.PK2);
            return base.getOne(Map, Parameters);
        }

        public override Vends Insert(Vends toInsert)
        {
            Dictionary<string, object> Parameters = MapToDico(toInsert);
            base.Insert(Parameters);
            return toInsert;
        }

        public override bool Update(Vends toUpdate)
        {
            Dictionary<string, object> Parameters = MapToDico(toUpdate);
            return base.Update(Parameters);

        }

        public override bool Delete(CompositeKey<int, int> id)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("IdPermaFungi", id.PK1);
            Parameters.Add("IdProduit", id.PK2);
            return base.Delete(Parameters);
        }


        #region Mappers
        private Dictionary<string, object> MapToDico(Vends toInsert)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p["IdPermaFungi"] = toInsert.IdPermaFungi;
            p["IdProduit"] = toInsert.IdProduit;
            p["DateVente"] = toInsert.DateVente;
            return p;
        }

        private Vends Map(SqlDataReader p)
        {
            return new Vends()
            {

                IdPermaFungi = (int)p["IdPermaFungi"],
                IdProduit = (int)p["IdProduit"],
                DateVente = (DateTime)p["dateVends"]

            };
        }
        #endregion



    }
}


