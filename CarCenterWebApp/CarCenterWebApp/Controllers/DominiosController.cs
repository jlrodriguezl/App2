using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarCenterWebApp.Models;
using CarCenterWebApp.Models.DTOs;

namespace CarCenterWebApp.Controllers
{
    public class DominiosController : Controller
    {
        // GET: Dominios
        public ActionResult Index()
        {
            List<DominiosDTO> lstDominios = null;
            using (carcenterEntities db = new carcenterEntities())
            {
                lstDominios = (from d in db.DOMINIOS
                               orderby d.ID_DOMINIO
                               select new DominiosDTO {
                                   IdDominio = d.ID_DOMINIO,
                                   TipoDominio = d.TIPO_DOMINIO,
                                   VlrDominio = d.VLR_DOMINIO
                               }).ToList();
            }
            return View(lstDominios);
        }

        //Método que llama al formulario de Inserción
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(DominiosDTO model)
        {
            //Validar los datos del formulario con base en los Data Annotations
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //Insertar datos en la BD
            using (carcenterEntities db = new carcenterEntities())
            {
                DOMINIOS oDominio = new DOMINIOS();
                oDominio.TIPO_DOMINIO = model.TipoDominio;
                oDominio.ID_DOMINIO = model.IdDominio;
                oDominio.VLR_DOMINIO = model.VlrDominio;

                db.DOMINIOS.Add(oDominio);
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Dominios/"));
        }

        public ActionResult Edit(String tipoDominio, String idDominio)
        {
            DominiosDTO model = new DominiosDTO();
            using (carcenterEntities db = new carcenterEntities())
            {
                var oDominio = db.DOMINIOS.Find(tipoDominio, idDominio);
                model.TipoDominio = oDominio.TIPO_DOMINIO;
                model.IdDominio = oDominio.ID_DOMINIO;
                model.VlrDominio = oDominio.VLR_DOMINIO;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(DominiosDTO model)
        {
            //Validar los datos del formulario con base en los Data Annotations
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (carcenterEntities db = new carcenterEntities())
            {
                var oDominio = db.DOMINIOS.Find(model.TipoDominio, model.IdDominio);
                oDominio.TIPO_DOMINIO = model.TipoDominio;
                oDominio.ID_DOMINIO = model.IdDominio;
                oDominio.VLR_DOMINIO = model.VlrDominio;

                db.Entry(oDominio).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            
            return Redirect(Url.Content("~/Dominios/"));

        }

        [HttpPost]
        public ActionResult Delete(String tipo, String id)
        {  
            using (carcenterEntities db = new carcenterEntities())
            {
                var oDominio = db.DOMINIOS.Find(tipo, id);
                db.DOMINIOS.Remove(oDominio);
                db.SaveChanges();
            }
            return Content("1");
        }
    }
}