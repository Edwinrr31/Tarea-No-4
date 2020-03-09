using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea_4.Models;

namespace Tarea_4.Controllers
{
    public class ConversorController : Controller
    {
        // GET: Conversor
        public ActionResult Index(Conversor conver)
        {
            try
            {
                /*------------------------- Conversor de Longitudes --------------------------*/

                //Kilometros a Milla
                if (conver.primeraUnidad.Equals("Kilometros") && conver.segundaUnidad.Equals("Millas"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 0.62137, 9);
                }
                //Milla a Kilometros
                else if (conver.primeraUnidad.Equals("Millas") && conver.segundaUnidad.Equals("Kilometros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 0.62137, 9);
                }
                //Milla a Metros
                else if (conver.primeraUnidad.Equals("Millas") && conver.segundaUnidad.Equals("Metros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 0.00062137, 9);
                }
                //Metros a Millas
                else if (conver.primeraUnidad.Equals("Metros") && conver.segundaUnidad.Equals("Millas"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 0.00062137, 9);
                }
                //Millas a Pulgadas
                else if (conver.primeraUnidad.Equals("Millas") && conver.segundaUnidad.Equals("Pulgadas"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 63360, 9);
                }
                //Pulgadas a Millas
                else if (conver.primeraUnidad.Equals("Pulgadas") && conver.segundaUnidad.Equals("Millas"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 63360, 9);
                }
                //Millas a Pies
                else if (conver.primeraUnidad.Equals("Millas") && conver.segundaUnidad.Equals("Pies"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 5280.0, 9);
                }
                //Pies a Millas
                else if (conver.primeraUnidad.Equals("Pies") && conver.segundaUnidad.Equals("Millas"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 0.00018939, 9);
                }
                //Millas a Centimetros
                else if (conver.primeraUnidad.Equals("Millas") && conver.segundaUnidad.Equals("Centimetros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 0.0000062137, 9);
                }
                //Centimetros a Millas
                else if (conver.primeraUnidad.Equals("Centimetros") && conver.segundaUnidad.Equals("Millas"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 160934, 9);
                }
                //Kilometros a Metros
                else if (conver.primeraUnidad.Equals("Kilometros") && conver.segundaUnidad.Equals("Metros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 0.0010000, 9);
                }
                //Metros a Kilometros
                else if (conver.primeraUnidad.Equals("Metros") && conver.segundaUnidad.Equals("Kilometros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 1000.0, 9);
                }
                //Kilometros a Pulgadas
                else if (conver.primeraUnidad.Equals("Kilometros") && conver.segundaUnidad.Equals("Pulgadas"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 39370.1, 9);
                }
                //Pulgadas a Kilometros
                else if (conver.primeraUnidad.Equals("Pulgadas") && conver.segundaUnidad.Equals("Kilometros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 39370, 9);
                }
                //Kilometros a Pies
                else if (conver.primeraUnidad.Equals("Kilometros") && conver.segundaUnidad.Equals("Pies"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 3281, 9);
                }
                //Pies a Kilometros
                else if (conver.primeraUnidad.Equals("Pies") && conver.segundaUnidad.Equals("Kilometros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 3281, 9);
                }
                //Kilometros a centimetros
                else if (conver.primeraUnidad.Equals("Kilometros") && conver.segundaUnidad.Equals("Centimetros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 0.000010000, 9);
                }
                //Centimetros a Kilometros
                else if (conver.primeraUnidad.Equals("Centimetros") && conver.segundaUnidad.Equals("Kilometros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 100000, 9);
                }
                //Metros a Pulgadas
                else if (conver.primeraUnidad.Equals("Metros") && conver.segundaUnidad.Equals("Pulgadas"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 39.370, 9);
                }
                //Pulgadas a Metros
                else if (conver.primeraUnidad.Equals("Pulgadas") && conver.segundaUnidad.Equals("Metros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 39.370, 9);
                }
                //Metros a Pies
                else if (conver.primeraUnidad.Equals("Metros") && conver.segundaUnidad.Equals("Pies"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 3.2808, 9);
                }
                //Pies a Metros
                else if (conver.primeraUnidad.Equals("Pies") && conver.segundaUnidad.Equals("Metros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 3.281, 9);
                }
                //Metros a Centimetros
                else if (conver.primeraUnidad.Equals("Metros") && conver.segundaUnidad.Equals("Centimetros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 0.010000, 9);
                }
                //Centimetros a Metros
                else if (conver.primeraUnidad.Equals("Centimetros") && conver.segundaUnidad.Equals("Metros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 100.00, 9);
                }
                //Pulgadas a Pies
                else if (conver.primeraUnidad.Equals("Pulgadas") && conver.segundaUnidad.Equals("Pies"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 0.083333, 9);
                }
                //Pies a Pulgadas
                else if (conver.primeraUnidad.Equals("Pies") && conver.segundaUnidad.Equals("Pulgadas"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 12, 9);
                }
                //Pulgadas a Centimetros
                else if (conver.primeraUnidad.Equals("Pulgadas") && conver.segundaUnidad.Equals("Centimetros"))
                {
                    conver.resultado = Math.Round(conver.cantidad / 0.39370, 9);
                }
                //Centimetros a Pulgadas
                else if (conver.primeraUnidad.Equals("Centimetros") && conver.segundaUnidad.Equals("Pulgadas"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 0.39370, 9);
                }
                //Pies a Centimetro
                else if (conver.primeraUnidad.Equals("Pies") && conver.segundaUnidad.Equals("Centimetros"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 30.48, 9);
                }
                //Centimetros a Pies
                else if (conver.primeraUnidad.Equals("Centimetros") && conver.segundaUnidad.Equals("Pies"))
                {
                    conver.resultado = Math.Round(conver.cantidad * 0.032808, 9);
                }
                //Millas a Millas
                else if (conver.primeraUnidad.Equals("Millas") && conver.segundaUnidad.Equals("Millas"))
                {
                    conver.resultado = Math.Round(conver.cantidad, 9);
                }
                //Kilometros a Kilometros
                else if (conver.primeraUnidad.Equals("Kilometros") && conver.segundaUnidad.Equals("Kilometros"))
                {
                    conver.resultado = Math.Round(conver.cantidad, 9);
                }
                //Metros a Metros
                else if (conver.primeraUnidad.Equals("Metros") && conver.segundaUnidad.Equals("Metros"))
                {
                    conver.resultado = Math.Round(conver.cantidad, 9);
                }
                //Pulgadas a Pulgadas
                else if (conver.primeraUnidad.Equals("Pulgadas") && conver.segundaUnidad.Equals("Pulgadas"))
                {
                    conver.resultado = Math.Round(conver.cantidad, 9);
                }
                //Pies a Pies
                else if (conver.primeraUnidad.Equals("Pies") && conver.segundaUnidad.Equals("Pies"))
                {
                    conver.resultado = Math.Round(conver.cantidad, 9);
                }
                //Centimetros a Centimetros
                else if (conver.primeraUnidad.Equals("Centimetros") && conver.segundaUnidad.Equals("Centimetros"))
                {
                    conver.resultado = Math.Round(conver.cantidad, 9);
                }

                /*--------------------------------------------------------------------------------*/

            }
            catch (Exception e)
            {

            }
            

            ViewBag.resulLongitud = conver.resultado;

            return View();
        }

    }
}