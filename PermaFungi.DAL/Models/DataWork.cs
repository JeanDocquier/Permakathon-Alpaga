using PermaFungi.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Models
{
    public class DataWork : IEntity<int>
    {
        private int _idDataWork;
        private int joursAbsence;
        private double _salaireBrut;
        private int _idUser;
        private string _typeContrat;

        public int IdDataWork { get => _idDataWork; set => _idDataWork = value; }
        public int JoursAbsence { get => joursAbsence; set => joursAbsence = value; }
        public double SalaireBrut { get => _salaireBrut; set => _salaireBrut = value; }
        public int IdUser { get => _idUser; set => _idUser = value; }
        public string TypeContrat { get => _typeContrat; set => _typeContrat = value; }
        public int Id { get => _idDataWork; }
    }
}
