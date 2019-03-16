using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarCenterWebApp.Models;

namespace CarCenterWebApp.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(int user, string pwd)
        {
            try
            {
                using (carcenterEntities db = new carcenterEntities())
                {
                    var lst = from p in db.PERSONAS
                              where p.IDENTIFICACION == user && p.CONTRASENA == pwd
                              select p;
                    if(lst.Count() > 0)
                    {
                        PERSONAS oPersona = lst.First(); 
                        Session["User"] = oPersona;
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario o Contraseña Incorrectos");
                    }
                }
                    
            }
            catch(Exception ex)
            {
                return Content("Ocurrió un error :( "+ex.Message);
            }
        }
    }
}