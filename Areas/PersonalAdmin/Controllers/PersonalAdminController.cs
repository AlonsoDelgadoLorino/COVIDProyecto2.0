using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using COVIDProyecto2._0.Models;
using System.Web.Security;
using System.Runtime.Remoting.Messaging;
using BLCovid;
using DACovid;

namespace COVIDProyecto2._0.Areas.PersonalAdmin.Controllers
{
    public class PersonalAdminController : Controller
    {
        // GET: PersonalAdmin/PersonalAdmin

        public ActionResult Reporte()
        {
            return View();
        }
        public ActionResult Login()
        {
            if (Session["UserAdmin_id"] != null)
            {
                return RedirectToAction("Menu");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public JsonResult LogearUsuario(string user, string pass)
        {
            // BOPersonalAdmin personal = DAPersonalAdmin.GetUser(user, pass);
            PersonalAdministrativo personal = LoginBL.GetUser(user, pass);
            bool exito;
            if (personal != null)
            {
                Session["UserAdmin_nombre"] = personal.Nombres + " " + personal.Apellidos;
                Session["UserAdmin_id"] = personal.ID;
                exito = true;
            }
            else
            {
                exito = false;
            }
            return Json(exito);

        }
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        public ActionResult Menu()
        {
            if (Session["UserAdmin_id"] != null)
            {
                return View();
            }
            else
            {
               return RedirectToAction("Login");
            }
            
        }
    }
}