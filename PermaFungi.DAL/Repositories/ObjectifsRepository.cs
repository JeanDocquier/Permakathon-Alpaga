using PermaFungi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Repositories
{
    public class ObjectifsRepository : BaseRepository<Objectifs, int>
    {

         public ObjectifsRepository(string Cnstr) : base(Cnstr)
    {
        SelectOneCommand = "Select * from Objectif where idObjectif=@idObjectif";
        SelectAllCommand = "Select * from Objectif";
        InsertCommand = @"INSERT INTO  Objectif (Prevision, Date)
                            OUTPUT inserted.idUser VALUES(@Prevision, @Date)";
        UpdateCommand = @"UPDATE  Objectif
                           SET Prevision =@Prevision, Date =@Date
                         WHERE IdObjectif = @IdObjectif;";
        DeleteCommand = @"Delete from  Objectif  WHERE IdObjectif = @IdObjectif;";
    }

     


        public override IEnumerable<Objectifs> GetAll()
        {
            return base.getAll(Map);
        }

        public override Objectifs GetOne(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("idObjectif", id);
            return base.getOne(Map, QueryParameters);
        }


        public override Objectifs Insert(Objectifs toInsert)
        {
            Dictionary<string, object> Parameters = MapToDico(toInsert);
            int id = base.Insert(Parameters);
            toInsert.IdObjectifs = id;
            return toInsert;
        }

        public override bool Update(Objectifs toUpdate)
        {
            Dictionary<string, object> Parameters = MapToDico(toUpdate);
            return base.Update(Parameters);

        }

        public override bool Delete(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("@IdObjectif", id);
            return base.Delete(QueryParameters);

        }

        #region Mappers
        private Dictionary<string, object> MapToDico(Objectifs toInsert)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p["idObjectif"] = toInsert.Id;
            p["Prevision"] = toInsert.Prevision;
            p["Date"] = toInsert.DatePrevision;
            
            return p;
        }

        private Objectifs Map(SqlDataReader arg)
        {
            return new Objectifs()
            {
                IdObjectifs= (int)arg["idObjectif"],
                Prevision =(int) arg["Prevision"],
                DatePrevision = (DateTime)arg["Date"],
              
            };
        }
        #endregion

    }
}
