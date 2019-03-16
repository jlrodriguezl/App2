using System.Web;
using System.Web.Mvc;

namespace CarCenterWebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //Habilitar el filtro de sesión para cada submit en la aplicación
            filters.Add(new Filters.VerificarSesion());
        }
    }
}
