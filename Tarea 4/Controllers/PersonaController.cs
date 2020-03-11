using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea_4.Models;
namespace Tarea_4.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        [HttpPost]
        public ActionResult Persona(Persona perso, HttpPostedFileBase imagen)
        {


            if (ModelState.IsValid)
            {
                string nombreFoto = imagen.FileName;
                imagen.SaveAs(Server.MapPath("/Fotos/" + nombreFoto));

                ViewBag.foto = nombreFoto;
                return View(perso);
            }
            else _ = ModelState.IsValid;
                    {
                string Archivo = imagen.FileName;
                imagen.SaveAs(Server.MapPath("/PDF/" + Archivo));

                ViewBag.PDF = Archivo;
                return View(perso);
            }

            
        }



        public ActionResult Index()
        {
            return View();
        }
    }
}