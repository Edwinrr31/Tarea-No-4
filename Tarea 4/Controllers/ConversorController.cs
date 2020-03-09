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

            /*------------------------------- Conversor de Longitudes --------------------------------*/

            try
            {
                //Kilometros a Milla
                if (conver.primeraUnidad.Equals("Kilometros") && conver.segundaUnidad.Equals("Millas"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 0.62137, 9);
                }
                //Milla a Kilometros
                else if (conver.primeraUnidad.Equals("Millas") && conver.segundaUnidad.Equals("Kilometros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 0.62137, 9);
                }
                //Milla a Metros
                else if (conver.primeraUnidad.Equals("Millas") && conver.segundaUnidad.Equals("Metros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 0.00062137, 9);
                }
                //Metros a Millas
                else if (conver.primeraUnidad.Equals("Metros") && conver.segundaUnidad.Equals("Millas"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 0.00062137, 9);
                }
                //Millas a Pulgadas
                else if (conver.primeraUnidad.Equals("Millas") && conver.segundaUnidad.Equals("Pulgadas"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 63360, 9);
                }
                //Pulgadas a Millas
                else if (conver.primeraUnidad.Equals("Pulgadas") && conver.segundaUnidad.Equals("Millas"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 63360, 9);
                }
                //Millas a Pies
                else if (conver.primeraUnidad.Equals("Millas") && conver.segundaUnidad.Equals("Pies"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 5280.0, 9);
                }
                //Pies a Millas
                else if (conver.primeraUnidad.Equals("Pies") && conver.segundaUnidad.Equals("Millas"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 0.00018939, 9);
                }
                //Millas a Centimetros
                else if (conver.primeraUnidad.Equals("Millas") && conver.segundaUnidad.Equals("Centimetros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 0.0000062137, 9);
                }
                //Centimetros a Millas
                else if (conver.primeraUnidad.Equals("Centimetros") && conver.segundaUnidad.Equals("Millas"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 160934, 9);
                }
                //Kilometros a Metros
                else if (conver.primeraUnidad.Equals("Kilometros") && conver.segundaUnidad.Equals("Metros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 0.0010000, 9);
                }
                //Metros a Kilometros
                else if (conver.primeraUnidad.Equals("Metros") && conver.segundaUnidad.Equals("Kilometros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 1000.0, 9);
                }
                //Kilometros a Pulgadas
                else if (conver.primeraUnidad.Equals("Kilometros") && conver.segundaUnidad.Equals("Pulgadas"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 39370.1, 9);
                }
                //Pulgadas a Kilometros
                else if (conver.primeraUnidad.Equals("Pulgadas") && conver.segundaUnidad.Equals("Kilometros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 39370, 9);
                }
                //Kilometros a Pies
                else if (conver.primeraUnidad.Equals("Kilometros") && conver.segundaUnidad.Equals("Pies"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 3281, 9);
                }
                //Pies a Kilometros
                else if (conver.primeraUnidad.Equals("Pies") && conver.segundaUnidad.Equals("Kilometros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 3281, 9);
                }
                //Kilometros a centimetros
                else if (conver.primeraUnidad.Equals("Kilometros") && conver.segundaUnidad.Equals("Centimetros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 0.000010000, 9);
                }
                //Centimetros a Kilometros
                else if (conver.primeraUnidad.Equals("Centimetros") && conver.segundaUnidad.Equals("Kilometros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 100000, 9);
                }
                //Metros a Pulgadas
                else if (conver.primeraUnidad.Equals("Metros") && conver.segundaUnidad.Equals("Pulgadas"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 39.370, 9);
                }
                //Pulgadas a Metros
                else if (conver.primeraUnidad.Equals("Pulgadas") && conver.segundaUnidad.Equals("Metros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 39.370, 9);
                }
                //Metros a Pies
                else if (conver.primeraUnidad.Equals("Metros") && conver.segundaUnidad.Equals("Pies"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 3.2808, 9);
                }
                //Pies a Metros
                else if (conver.primeraUnidad.Equals("Pies") && conver.segundaUnidad.Equals("Metros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 3.281, 9);
                }
                //Metros a Centimetros
                else if (conver.primeraUnidad.Equals("Metros") && conver.segundaUnidad.Equals("Centimetros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 0.010000, 9);
                }
                //Centimetros a Metros
                else if (conver.primeraUnidad.Equals("Centimetros") && conver.segundaUnidad.Equals("Metros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 100.00, 9);
                }
                //Pulgadas a Pies
                else if (conver.primeraUnidad.Equals("Pulgadas") && conver.segundaUnidad.Equals("Pies"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 0.083333, 9);
                }
                //Pies a Pulgadas
                else if (conver.primeraUnidad.Equals("Pies") && conver.segundaUnidad.Equals("Pulgadas"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 12, 9);
                }
                //Pulgadas a Centimetros
                else if (conver.primeraUnidad.Equals("Pulgadas") && conver.segundaUnidad.Equals("Centimetros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud / 0.39370, 9);
                }
                //Centimetros a Pulgadas
                else if (conver.primeraUnidad.Equals("Centimetros") && conver.segundaUnidad.Equals("Pulgadas"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 0.39370, 9);
                }
                //Pies a Centimetro
                else if (conver.primeraUnidad.Equals("Pies") && conver.segundaUnidad.Equals("Centimetros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 30.48, 9);
                }
                //Centimetros a Pies
                else if (conver.primeraUnidad.Equals("Centimetros") && conver.segundaUnidad.Equals("Pies"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud * 0.032808, 9);
                }
                //Millas a Millas
                else if (conver.primeraUnidad.Equals("Millas") && conver.segundaUnidad.Equals("Millas"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud, 9);
                }
                //Kilometros a Kilometros
                else if (conver.primeraUnidad.Equals("Kilometros") && conver.segundaUnidad.Equals("Kilometros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud, 9);
                }
                //Metros a Metros
                else if (conver.primeraUnidad.Equals("Metros") && conver.segundaUnidad.Equals("Metros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud, 9);
                }
                //Pulgadas a Pulgadas
                else if (conver.primeraUnidad.Equals("Pulgadas") && conver.segundaUnidad.Equals("Pulgadas"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud, 9);
                }
                //Pies a Pies
                else if (conver.primeraUnidad.Equals("Pies") && conver.segundaUnidad.Equals("Pies"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud, 9);
                }
                //Centimetros a Centimetros
                else if (conver.primeraUnidad.Equals("Centimetros") && conver.segundaUnidad.Equals("Centimetros"))
                {
                    conver.resultadoLongitud = Math.Round(conver.longitud, 9);
                }

            }
            catch (Exception e)
            {

            }

            ViewBag.resulLongitud = conver.resultadoLongitud;

            /*----------------------------------------------------------------------------------------*/

            /*------------------------------- Conversor de Temperaturas --------------------------------*/

            try
            {
                //Celcius a Farenheit
                if (conver.primeraUnidad.Equals("Celcius") && conver.segundaUnidad.Equals("Farenheit"))
                {
                    conver.resultadoTemperatura = (conver.temperatura * 1.8) + 32;
                }
                //Farenheit a Celcius
                else if(conver.primeraUnidad.Equals("Farenheit") && conver.segundaUnidad.Equals("Celcius"))
                {
                    conver.resultadoTemperatura = (conver.temperatura - 32) / 1.8;
                }
                //Celcius a Kelvin
                else if(conver.primeraUnidad.Equals("Celcius") && conver.segundaUnidad.Equals("Kelvin"))
                {
                    conver.resultadoTemperatura = 273.15 + conver.temperatura;
                }
                //Kelvin a Celcius
                else if (conver.primeraUnidad.Equals("Kelvin") && conver.segundaUnidad.Equals("Celcius"))
                {
                    conver.resultadoTemperatura = conver.temperatura - 273.15;
                }
                //Farenheit a Kelvin
                else if (conver.primeraUnidad.Equals("Farenheit") && conver.segundaUnidad.Equals("Kelvin"))
                {
                    conver.resultadoTemperatura = ((conver.temperatura - 32) / 1.8000) + 273.15;
                }
                //Kelvin a Farenheit
                else if (conver.primeraUnidad.Equals("Kelvin") && conver.segundaUnidad.Equals("Farenheit"))
                {
                    conver.resultadoTemperatura = ((conver.temperatura - 273.15) * 1.8000) + 32.00;
                }
                //Celcius a Celcius
                else if (conver.primeraUnidad.Equals("Celcius") && conver.segundaUnidad.Equals("Celcius"))
                {
                    conver.resultadoTemperatura = conver.temperatura ;
                }
                //Farenheit a Farenheit
                else if (conver.primeraUnidad.Equals("Farenheit") && conver.segundaUnidad.Equals("Farenheit"))
                {
                    conver.resultadoTemperatura = conver.temperatura;
                }
                //Kelvin a Kelvin
                else if (conver.primeraUnidad.Equals("Kelvin") && conver.segundaUnidad.Equals("Kelvin"))
                {
                    conver.resultadoTemperatura = conver.temperatura;
                }

            }
            catch (Exception e)
            {

            }

            ViewBag.resulTemperatura = conver.resultadoTemperatura;

            /*--------------------------------------------------------------------------------*/

            /*------------------------------- Conversor de Masa --------------------------------*/

            try
            {
                //Gramos a Kilogramos
                if (conver.primeraUnidad.Equals("Gramos") && conver.segundaUnidad.Equals("Kilogramos"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa / 1000.0, 9);
                }
                //Kilogramos a Gramos
                else if (conver.primeraUnidad.Equals("Kilogramos") && conver.segundaUnidad.Equals("Gramos"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa / 0.0010000, 9);
                }
                //Gramos a Onzas
                else if (conver.primeraUnidad.Equals("Gramos") && conver.segundaUnidad.Equals("Onzas"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa * 0.035274, 9);
                }
                //Onzas a Gramos
                else if (conver.primeraUnidad.Equals("Onzas") && conver.segundaUnidad.Equals("Gramos"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa / 0.035274, 9);
                }
                //Gramos a Libras
                else if (conver.primeraUnidad.Equals("Gramos") && conver.segundaUnidad.Equals("Libras"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa * 0.0022046, 9);
                }
                //Libras a Gramos
                else if (conver.primeraUnidad.Equals("Libras") && conver.segundaUnidad.Equals("Gramos"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa / 0.0022046, 9);
                }
                //Kilogramos a Onzas
                else if (conver.primeraUnidad.Equals("Kilogramos") && conver.segundaUnidad.Equals("Onzas"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa * 35.274, 9);
                }
                //Onzas a Kilogramos
                else if (conver.primeraUnidad.Equals("Onzas") && conver.segundaUnidad.Equals("Kilogramos"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa / 35.274, 9);
                }
                //Kilogramos a libras
                else if (conver.primeraUnidad.Equals("Kilogramos") && conver.segundaUnidad.Equals("Libras"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa * 2.2046, 9);
                }
                //Libras a Kilogramos
                else if (conver.primeraUnidad.Equals("Libras") && conver.segundaUnidad.Equals("Kilogramos"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa / 2.2046, 9);
                }
                //Onzas a Libras
                else if (conver.primeraUnidad.Equals("Onzas") && conver.segundaUnidad.Equals("Libras"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa * 0.062500, 9);
                }
                //Libras a Onzas
                else if (conver.primeraUnidad.Equals("Libras") && conver.segundaUnidad.Equals("Onzas"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa * 16.000, 9);
                }
                //Gramos a Gramos
                else if (conver.primeraUnidad.Equals("Gramos") && conver.segundaUnidad.Equals("Gramos"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa, 9);
                }
                //Kilogramos a Kilogramos
                else if (conver.primeraUnidad.Equals("Kilogramos") && conver.segundaUnidad.Equals("Kilogramos"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa, 9);
                }
                //Onzas a Onzas
                else if (conver.primeraUnidad.Equals("Onzas") && conver.segundaUnidad.Equals("Onzas"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa, 9);
                }
                //Libras a Libras
                else if (conver.primeraUnidad.Equals("Libras") && conver.segundaUnidad.Equals("Libras"))
                {
                    conver.resultadoMasa = Math.Round(conver.masa, 9);
                }

            }
            catch (Exception e)
            {

            }

            ViewBag.resulMasa = conver.resultadoMasa;

            /*--------------------------------------------------------------------------------*/


            return View();
        }

    }
}