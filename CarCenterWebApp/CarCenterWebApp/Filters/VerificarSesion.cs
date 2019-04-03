﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarCenterWebApp.Controllers;
using CarCenterWebApp.Models;

namespace CarCenterWebApp.Filters
{
    public class VerificarSesion : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Obtener de la sesión los datos de la persona logueada
            var oPersona = (PERSONAS)HttpContext.Current.Session["User"];
            //Si la sesión no existe o no se ha iniciado sesión....
            if(oPersona == null)
            {
                //Si la petición viene de un controlador diferente a AccesoController o HomeController, regresamos
                //al usuario a la pantalla de login
                if(filterContext.Controller is AccesoController == false &&
                    filterContext.Controller is HomeController == false &&
                    filterContext.Controller is PersonaVehiculoController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Acceso/Index");
                }                
            }
            else
            {
                if (filterContext.Controller is AccesoController == true)
                {
                    filterContext.HttpContext.Response.Redirect("~/Home/Index");
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}