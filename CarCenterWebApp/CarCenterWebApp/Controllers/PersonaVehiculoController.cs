using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarCenterWebApp.Models;
using CarCenterWebApp.Models.DTOs;

namespace CarCenterWebApp.Controllers
{
    public class PersonaVehiculoController : Controller
    {
        // GET: PersonaVehiculo
        public ActionResult Index()
        {
            PersonaVehiculoDTO personaVehiculoDTO = new PersonaVehiculoDTO();
            List<DominiosDTO> lstColores = null;
            List<DominiosDTO> lstMarcas = null;
            List<DominiosDTO> lstTipoVehiculo = null;
            using (carcenterEntities db = new carcenterEntities())
            {                
                lstColores = (from d in db.DOMINIOS
                              where d.TIPO_DOMINIO == "COLORES"
                              orderby d.VLR_DOMINIO
                              select new DominiosDTO
                              {
                                  IdDominio = d.ID_DOMINIO,
                                  TipoDominio = d.TIPO_DOMINIO,
                                  VlrDominio = d.VLR_DOMINIO
                              }).ToList();
                personaVehiculoDTO.LstColores = lstColores;

                lstMarcas = (from d in db.DOMINIOS
                              where d.TIPO_DOMINIO == "MARCAS"
                              orderby d.VLR_DOMINIO
                              select new DominiosDTO
                              {
                                  IdDominio = d.ID_DOMINIO,
                                  TipoDominio = d.TIPO_DOMINIO,
                                  VlrDominio = d.VLR_DOMINIO
                              }).ToList();
                personaVehiculoDTO.LstMarcas = lstMarcas;

                lstTipoVehiculo = (from d in db.DOMINIOS
                             where d.TIPO_DOMINIO == "TIPOS_VEHICULO"
                             orderby d.VLR_DOMINIO
                             select new DominiosDTO
                             {
                                 IdDominio = d.ID_DOMINIO,
                                 TipoDominio = d.TIPO_DOMINIO,
                                 VlrDominio = d.VLR_DOMINIO
                             }).ToList();
                personaVehiculoDTO.LstTipoVehiculo = lstTipoVehiculo;
            }
            return View(personaVehiculoDTO);
        }

        [HttpPost]
        public ActionResult Index(PersonaVehiculoDTO model)
        {
            //Validar los datos del formulario con base en los Data Annotations
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //Insertar datos en la BD
            using (carcenterEntities db = new carcenterEntities())
            {
                PERSONAS p = new PERSONAS();
                p.IDENTIFICACION = model.Identificacion;
                p.NOMBRES = model.Nombres;
                p.TELEFONO = model.Telefono;
                p.DIRECCION = model.Direccion;
                p.CORREO = model.Correo;
                p.ESTADO_PERSONA = "A";
                p.TIPO_PERSONA = "CLI";
                p.CONTRASENA = model.Contrasena;

                db.PERSONAS.Add(p);

                VEHICULOS v = new VEHICULOS();
                v.PLACA = model.Placa;
                v.MODELO = model.Modelo;
                v.TIPO_VEHICULO = model.TipoVehiculo;
                v.COLOR = model.Color;
                v.MARCA = model.Marca;

                db.VEHICULOS.Add(v);

                PERSONA_VEHICULO pv = new PERSONA_VEHICULO();
                pv.ESTADO_PROP = "A";
                pv.IDENTIFICACION = model.Identificacion;
                pv.PLACA = model.Placa;

                db.PERSONA_VEHICULO.Add(pv);

                db.SaveChanges();
            }
            return Redirect(Url.Content("~/"));
        }
    }
}