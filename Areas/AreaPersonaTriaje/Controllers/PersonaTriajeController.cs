using BLCovid;
using DACovid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TRIAJE_COVID.Areas.AreaPersonaTriaje.Controllers
{
    public class PersonaTriajeController : Controller
    {
        // GET: AreaPersonaTriaje/PersonaTriaje
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Listado()
        {
            ViewBag.ListadoPersona = PersonaBL.Listado();
            return PartialView();
        }

        [HttpPost]
        public JsonResult Grabar(string nombrePersona,string apellidos,int edad, string sexo, string ocupacion, string sintomas, string direccion )
        {
            PersonaTriaje persona = new PersonaTriaje
            {
                Nombres = nombrePersona,
                Apellidos = apellidos,
                Edad = edad,
                Sexo = sexo,
                Ocupacion = ocupacion,
                Sintomas = sintomas,
                Direccion = direccion
            };
            bool exito = true;
            PersonaBL.Registrar(persona);           

            return Json(exito, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Eliminar(int codigoPersona)
        {
            bool exito = PersonaBL.Eliminar(codigoPersona);
            return Json(exito, JsonRequestBehavior.AllowGet);
        }

    }
}