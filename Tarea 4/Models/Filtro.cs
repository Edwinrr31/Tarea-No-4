using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea_4.Models
{
    public class Filtro
    {
        public string filtro { get; set; }

        public enum FiltroContenido
        {
            Noticias, Musica, Peliculas
        }
    }
}