using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarCenterWebApp.Models.DTOs
{
    public class PersonasDTO
    {
        [Required]
        [StringLength(15)]
        [Display(Name = "Identificación")]
        public Decimal Identificacion { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Nombres")]
        public String Nombres { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Telefono")]
        public Decimal Telefono { get; set; }
        [Required]
        [StringLength(15)]
        [Display(Name = "Identificación")]
        public String Correo { get; set; }
        [Required]
        [StringLength(15)]
        [Display(Name = "Identificación")]
        public String Contrasena { get; set; }
        [Required]
        [StringLength(15)]
        [Display(Name = "Identificación")]
        public String EstadoPersona { get; set; }
    }
}