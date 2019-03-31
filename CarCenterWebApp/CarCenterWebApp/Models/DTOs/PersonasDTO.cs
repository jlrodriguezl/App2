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
        [StringLength(100)]
        [Display(Name = "Correo")]
        public String Correo { get; set; }

        [Required]
        [StringLength(12)]
        [Display(Name = "Contraseña")]
        public String Contrasena { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Estado Persona")]
        public String Estado_Persona { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Dirección")]
        public String Direccion { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Especialidad")]
        public String Especialidad { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Tipo Persona")]
        public String Tipo_Persona { get; set; }
    }
}