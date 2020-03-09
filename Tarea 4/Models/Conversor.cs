using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea_4.Models
{
    public class Conversor
    {
        public double cantidad { get; set; }
        public string primeraUnidad { get; set; }
        public string segundaUnidad { get; set; }
        public double resultado { get; set; }

    }

    public enum TipoLongitudes
    {
        Centimetros, Pies, Pulgadas, Metros, Kilometros, Millas
    }
}