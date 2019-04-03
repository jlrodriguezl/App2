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
            using (carcenterEntities db = new carcenterEntities()) {

                PERSONAS oPersona = new PERSONAS();
                oPersona.IDENTIFICACION = Convert.ToDecimal(model.Identificacion);
                oPersona.NOMBRES = model.Nombres;
                oPersona.TELEFONO = Convert.ToDecimal(model.Telefono);
                oPersona.DIRECCION = model.Direccion;
                oPersona.CORREO = model.Correo;
                oPersona.ESPECIALIDAD = model.Especialidad;
                oPersona.TIPO_PERSONA = model.Tipo_Persona;
                oPersona.CONTRASENA = model.Contrasena;
                oPersona.ESTADO_PERSONA = model.Estado_Persona;

                db.PERSONAS.Add(oPersona);
                db.SaveChanges();
            }

                return Redirect(Url.Content("~/Personas/"));

        }

        public ActionResult Edit(Decimal Identificacion)
        {
            PersonasDTO model = new PersonasDTO();
            using (carcenterEntities db = new carcenterEntities()) {
                var oPersona = db.PERSONAS.Find(Identificacion);
                model.Identificacion = oPersona.IDENTIFICACION;
                model.Nombres = oPersona.NOMBRES;
                model.Telefono = oPersona.TELEFONO;
                model.Direccion = oPersona.DIRECCION;
                model.Correo = oPersona.CORREO;
                model.Especialidad = oPersona.ESPECIALIDAD;
                model.Tipo_Persona = oPersona.TIPO_PERSONA;
                model.Contrasena = oPersona.CONTRASENA;
                model.Estado_Persona = oPersona.ESTADO_PERSONA;
            }
                return View(model);

        }
        [HttpPost]
        public ActionResult Edit(PersonasDTO model) {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            using (carcenterEntities db = new carcenterEntities())
            {
                var oPersona = db.PERSONAS.Find(model.Identificacion);
                oPersona.IDENTIFICACION = Convert.ToDecimal(model.Identificacion);
                oPersona.NOMBRES = model.Nombres;
                oPersona.TELEFONO = Convert.ToDecimal(model.Telefono);
                oPersona.DIRECCION = model.Direccion;
                oPersona.CORREO = model.Correo;
                oPersona.ESPECIALIDAD = model.Especialidad;
                oPersona.TIPO_PERSONA = model.Tipo_Persona;
                oPersona.CONTRASENA = model.Contrasena;
                oPersona.ESTADO_PERSONA = model.Estado_Persona;

            }
            return Redirect(Url.Content("~/Personas/"));
        }

        [HttpPost]
        public ActionResult Delete(Decimal Identificacion) {
            using (carcenterEntities db = new carcenterEntities()) {
                var oPersona = db.PERSONAS.Find(Identificacion);
                db.PERSONAS.Remove(oPersona);
                db.SaveChanges();
            }
            return Content("1");
        }
    }
}