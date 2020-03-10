using PermaFungi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Repositories
{
    public class UserRepository : BaseRepository<User, int>
    {
        public UserRepository(string Cnstr) : base(Cnstr)
        {
            SelectOneCommand = "Select * from User where idUser=@idUser";
            SelectAllCommand = "Select * from User";
            InsertCommand = @"INSERT INTO  User (Nom ,Prenom , adresse, telephone , role, Email ,motDePasse)
                            OUTPUT inserted.idUser VALUES(@Nom, @Prenom, @Adresse ,@Telephone ,@Role, @Email ,@MotDePasse)";
            UpdateCommand = @"UPDATE  User
                           SET Nom = @Nom,  Prenom = @Prenom,  Adresse= @Adresse, Telephone =@Telephone, Role =@Role , Email = @Email,  MotDePasse = @MotDePasse
                         WHERE IdUser = @IdUser;";
            DeleteCommand = @"Delete from  User  WHERE IdUser = @IdUser;";
        }


        public User VerifLogin(User user)
        {
            SelectOneCommand = "Select * from Membre where Email=@Email and Password=@Passeword";
            return base.getOne(Map, MapToDico(user));
        }


        public override IEnumerable<User> GetAll()
        {
            return base.getAll(Map);
        }

        public override User GetOne(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("idUser", id);
            return base.getOne(Map, QueryParameters);
        }


        public override User Insert(User toInsert)
        {
            Dictionary<string, object> Parameters = MapToDico(toInsert);
            int id = base.Insert(Parameters);
            toInsert.IdUser= id;
            return toInsert;
        }

        public override bool Update(User toUpdate)
        {
            Dictionary<string, object> Parameters = MapToDico(toUpdate);
            return base.Update(Parameters);

        }

        public override bool Delete(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("@IdUser", id);
            return base.Delete(QueryParameters);

        }



        #region Mappers
        private Dictionary<string, object> MapToDico(User toInsert)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p["idUser"] = toInsert.Id;
            p["Nom"] = toInsert.Nom;
            p["Prenom"] = toInsert.Prenom;
            p["Telephone"] = toInsert.Telephone;
            p["Email"] = toInsert.Email;
            p["Role"] = toInsert.Role;
            p["MotDePasse"] = toInsert.HashMDP;
            p["Adresse"] = toInsert.Adresse;
            return p;
        }

        private User Map(SqlDataReader arg)
        {
            return new User()
            {
                IdUser = (int)arg["idUser"],
                Nom = arg["nom"].ToString(),
                Prenom = arg["prenom"].ToString(),
                Telephone = arg["telephone"].ToString(),
                Email = arg["email"].ToString(),
                Role = arg["role"].ToString(),
                Adresse = arg["adresse"].ToString(),
                
                //WE CAN'T STORE PASSWORD FROM DB
                // MotDePasse= arg["MotDePasse"].ToString()
            };
        }
        #endregion

    }



}
