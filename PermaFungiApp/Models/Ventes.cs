using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PermaFungiApp.Models
{
    public class Ventes
    {
        public string[] Mois = new string[12] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" };
        public double[] MarcCollectes = new double[12];
        public double[] Kit = new double[12];
        public double[] Fungipop = new double[12];
    }
}