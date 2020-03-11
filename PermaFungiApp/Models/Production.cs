using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PermaFungiApp.Models
{

    public class Production
    {
        public string[] Mois = new string[12] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" };
        public double[] Pleurottes = new double[12];
        public double[] Pieds = new double[12];
        public double[] Panicaults = new double[12];
    }
}