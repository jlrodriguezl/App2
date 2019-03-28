using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarCenterWebApp.Models;
using CarCenterWebApp.Models.DTOs;

namespace CarCenterWebApp.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Index()
        {
          

            return View();
        }

        public ActionResult Add()
        {
            return View();

        }

        public ActionResult Edit()
        {
            return View();

        }

    }
}