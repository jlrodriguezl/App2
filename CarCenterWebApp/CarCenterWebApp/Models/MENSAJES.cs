//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarCenterWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MENSAJES
    {
        public decimal ID_MENSAJE { get; set; }
        public string DESC_MENSAJE { get; set; }
        public System.DateTime FECHA_MENSAJE { get; set; }
        public decimal ID_CITA { get; set; }
    
        public virtual CITAS CITAS { get; set; }
    }
}
