using PermaFungi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PermaFungiApp.Models
{
	public static class UserExtension
	{
		public static UserTO ToTransferObject(this User user)
		{
			return new UserTO
			{
				nom = user.Nom,
				prenom = user.Prenom,
				email = user.Email,
				motDePasse = user.MotDePasse,
				role = user.Role,
				adresse = user.Adresse,
				telephone = user.Telephone
			};
		}

		public static User ToEF(this UserTO user)
		{
			return new User
			{
				Nom = user.nom,
				Prenom = user.prenom,
				Email = user.email,
				MotDePasse = user.motDePasse,
				Role = user.role,
				Adresse = user.adresse,
				Telephone = user.telephone
			};
		}
	}
}