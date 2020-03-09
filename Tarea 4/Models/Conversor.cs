using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea_4.Models
{
    public class Conversor
    {
        public string primeraUnidad { get; set; }
        public string segundaUnidad { get; set; }

        public double longitud { get; set; }
        public double resultadoLongitud { get; set; }

        public double temperatura { get; set; }
        public double resultadoTemperatura { get; set; }

        public double masa { get; set; }
        public double resultadoMasa { get; set; }


    }

    public enum TipoLongitudes
    {
        Centimetros, Pies, Pulgadas, Metros, Kilometros, Millas
    }
    public enum TipoTemperaturas
    {
        Celcius, Farenheit, Kelvin
    }
    public enum TipoMasa
    {
        Gramos, Kilogramos, Onzas, Libras
    }
}