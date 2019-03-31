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
            List<PersonasDTO> lstPersonas = null;
            using (carcenterEntities db = new carcenterEntities()) {
                lstPersonas = (from p in db.PERSONAS
                               orderby p.TIPO_PERSONA
                               select new PersonasDTO
                               {
                                   Identificacion = p.IDENTIFICACION,
                                   Nombres = p.NOMBRES,
                                   Telefono = p.TELEFONO,
                                   Direccion = p.DIRECCION,
                                   Correo = p.CORREO,
                                   Especialidad = p.ESPECIALIDAD,
                                   Tipo_Persona = p.TIPO_PERSONA,
                                   Contrasena = p.CONTRASENA,
                                   Estado_Persona = p.ESTADO_PERSONA
                               }).ToList();


            }

                return View(lstPersonas);
        }
        [HttpGet]
        public ActionResult Add()
        {

            return View();

        }


        [HttpPost]
        public ActionResult Add(PersonasDTO model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //VAMOS AQUIIIIIII

            return View();

        }

        public ActionResult Edit()
        {
            return View();

        }

    }
}