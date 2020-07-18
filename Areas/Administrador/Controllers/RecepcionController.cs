using BLCovid;
using DACovid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recepción_Donaciones.Areas.Administrador.Controllers
{
    public class RecepcionController : Controller
    {
        // GET: Administrador/Recepcion
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Listado()
        {
            ViewBag.ListadoDonacion = DonacionesDL.Listado();
            return PartialView();
        }
    }
}