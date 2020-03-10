using System;
using PermaFungi.DAL.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Repositories
{
    public class PermaFungiRepository : BaseRepository<PermaFungiClass, int>
    {
        public PermaFungiRepository(string Cnstr) : base(Cnstr)
        {
        SelectOneCommand = "Select * from PermaFungi where idPermaFungi=@idPermaFungi";
        SelectAllCommand = "Select * from PermaFungi";
        InsertCommand = @"INSERT INTO  PermaFungi (ville , adresse, contact, email)
                            OUTPUT inserted.idPermaFungi VALUES(@Ville, @Adresse, @Contact,@Email)";
        UpdateCommand = @"UPDATE  PermaFungi
                           SET ville = @Ville, Adresse = @Adresse, contact = @Contact, email = @Email
                         WHERE IdPermaFungi = @IdPermaFungi;";
        DeleteCommand = @"Delete from  PermaFungi  WHERE IdPermaFungi = @IdPermaFungi;";
        }

    public override IEnumerable<PermaFungiClass> GetAll()
    {
        return base.getAll(Map);
    }

    public override PermaFungiClass GetOne(int id)
    {
        Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
        QueryParameters.Add("idPermaFungi", id);
        return base.getOne(Map, QueryParameters);
    }


    public override PermaFungiClass Insert(PermaFungiClass toInsert)
    {
        Dictionary<string, object> Parameters = MapToDico(toInsert);
        int id = base.Insert(Parameters);
        toInsert.IdPermaFungi = id;
        return toInsert;
    }

    public override bool Update(PermaFungiClass toUpdate)
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
    private Dictionary<string, object> MapToDico(PermaFungiClass toInsert)
    {
        Dictionary<string, object> p = new Dictionary<string, object>();
        p["idPermaFungi"] = toInsert.Id;
        p["ville"] = toInsert.Ville;
        p["adresse"] = toInsert.Adresse;
        p["contact"] = toInsert.Contact;
        p["email"] = toInsert.Email;

        return p;
    }

    private PermaFungiClass Map(SqlDataReader arg)
    {
        return new PermaFungiClass()
        {
            IdPermaFungi = (int)arg["idPermaFungi"],
            Ville = arg["Ville"].ToString(),
            Adresse = arg["Adresse"].ToString(),
            Contact = arg["Contact"].ToString(),
            Email = arg["Email"].ToString(),
        };
    }
    #endregion
}


}
