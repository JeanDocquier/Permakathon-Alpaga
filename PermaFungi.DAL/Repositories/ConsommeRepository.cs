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
    public class ConsommeRepository : BaseRepository<Consomme, CompositeKey<int, int>>
    {
        public ConsommeRepository(string Cnstr) : base(Cnstr)
        {
            SelectOneCommand = "Select * from Consomme where idMachine=@idMachine AND idConsomation=@idConsomation";
            SelectAllCommand = "Select * from Consomme";
            InsertCommand = @"INSERT INTO  Consomme (idMachine ,idConsomation, dateConsomme)
                            OUTPUT inserted.idUser VALUES(@idMachine, @idConsomation, @dateConsomme)";
            UpdateCommand = @"UPDATE  Consomme
                           SET idMachine=@idMachine, idConsomation =@idConsomation, dateConsomme = @DateConsomme
                         WHERE  idMachine=@idMachine AND idConsomation=@idConsomation;";
            DeleteCommand = @"Delete from  Consomme  WHERE idMachine=@idMachine AND idConsomation=@idConsomation;";
        }


        public override IEnumerable<Consomme> GetAll()
        {
            return base.getAll(Map);
        }

        public override Consomme GetOne(CompositeKey<int, int> id)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("IdMachine", id.PK1);
            Parameters.Add("IdConsomation", id.PK2);
            return base.getOne(Map, Parameters);
        }

        public override Consomme Insert(Consomme toInsert)
        {
            Dictionary<string, object> Parameters = MapToDico(toInsert);
            base.Insert(Parameters);
            return toInsert;
        }

        public override bool Update(Consomme toUpdate)
        {
            Dictionary<string, object> Parameters = MapToDico(toUpdate);
            return base.Update(Parameters);

        }

        public override bool Delete(CompositeKey<int, int> id)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("idMachine", id.PK1);
            Parameters.Add("idConsomme", id.PK2);
            return base.Delete(Parameters);
        }


        #region Mappers
        private Dictionary<string, object> MapToDico(Consomme toInsert)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p["idMachine"] = toInsert.IdMachine;
            p["idConsomation"] = toInsert.IdConsommation;
            p["dateConsomme"] = toInsert.DateConsomme;
            return p;
        }

        private Consomme Map(SqlDataReader p)
        {
            return new Consomme()
            {

                IdMachine = (int)p["idMachine"],
                IdConsommation = (int)p["idConsomation"],
                DateConsomme = (DateTime)p["DateConsomme"]

            };
        }
        #endregion

    }
}
