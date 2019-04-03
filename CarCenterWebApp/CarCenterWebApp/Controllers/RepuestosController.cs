using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarCenterWebApp.Models;
using CarCenterWebApp.Models.DTOs;

namespace CarCenterWebApp.Controllers
{
    public class RepuestosController : Controller
    {
        // GET: Repuestos
        public ActionResult Index()
        {
            List<RepuestosDTO> lstRepuestos = null;
            using (carcenterEntities db = new carcenterEntities())
            {
                lstRepuestos = (from d in db.REPUESTOS
                                orderby d.ID_REPUESTO
                                select new RepuestosDTO
                                {
                                    Idrepuesto = d.ID_REPUESTO,
                                    descmensaje = d.DESC_MENSAJE,

                                }).ToList();
            }
            return View(lstRepuestos);
        }

        //Método que llama al formulario de Inserción
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(RepuestosDTO model)
        {
            //Validar los datos del formulario con base en los Data Annotations
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //Insertar datos en la BD
            using (carcenterEntities db = new carcenterEntities())
            {
                REPUESTOS oRepuestos = new REPUESTOS();
                oRepuestos.ID_REPUESTO = model.Idrepuesto;
                oRepuestos.DESC_MENSAJE = model.descmensaje;


                db.REPUESTOS.Add(oRepuestos);
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Repuestos/"));
        }

        public ActionResult Edit(String idRepuestos, String descmensaje)
        {
            RepuestosDTO model = new RepuestosDTO();
            using (carcenterEntities db = new carcenterEntities())
            {
                var oRepuestos = db.REPUESTOS.Find(idRepuestos, descmensaje);
                model.Idrepuesto = oRepuestos.ID_REPUESTO;
                model.descmensaje = oRepuestos.DESC_MENSAJE;

            }
            return View(model);
        }

        [HttpPost]

        public ActionResult Edit(RepuestosDTO model)
        {
            //Validar los datos del formulario con base en los Data Annotations
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (carcenterEntities db = new carcenterEntities())
            {
                var oRepuestos = db.REPUESTOS.Find(model.Idrepuesto, model.descmensaje);
                oRepuestos.ID_REPUESTO = model.Idrepuesto;
                oRepuestos.DESC_MENSAJE = model.descmensaje;
                db.Entry(oRepuestos).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }


            return Redirect(Url.Content("~/Repuestos/"));

        }

        [HttpPost]
        public ActionResult Delete(String idrepuestos, String descmensaje)
        {
            using (carcenterEntities db = new carcenterEntities())
            {
                var oRepuestos = db.REPUESTOS.Find(idrepuestos, descmensaje);
                db.REPUESTOS.Remove(oRepuestos);
                db.SaveChanges();
            }
            return Content("1");
        }

    }
}