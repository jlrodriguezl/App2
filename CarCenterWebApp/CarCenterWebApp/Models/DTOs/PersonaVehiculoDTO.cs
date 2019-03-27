using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CarCenterWebApp.Models.DTOs
{
    public class PersonaVehiculoDTO
    {
        [Required]
        [Display(Name = "Identificación")]        
        public decimal Identificacion { get; set; }
        [Required]
        [Display(Name = "Nombres")]
        [StringLength(15)]
        public string Nombres { get; set; }
        [Required]
        [Display(Name = "Teléfono")]       
        public decimal Telefono { get; set; }       
        [Display(Name = "Dirección")]
        [StringLength(100)]
        public string Direccion { get; set; }
        [Required]
        [Display(Name = "Correo")]
        [StringLength(100)]
        public string Correo { get; set; }
        [Required]
        [Display(Name = "Especialidad")]
        [StringLength(10)]
        public string Especialidad { get; set; }
        [Required]
        [Display(Name = "Tipo Persona")]
        [StringLength(10)]
        public string TipoPersona { get; set; }
        [Required]
        [Display(Name = "Conttraseña")]
        [StringLength(12)]
        public string Contrasena { get; set; }
        [Required]
        [Display(Name = "Estado")]
        [StringLength(10)]
        public string EstadoPesona { get; set; }
        [Required]
        [Display(Name = "Placa")]
        [StringLength(6)]
        public string Placa { get; set; }
        [Required]
        [Display(Name = "Marca")]
        [StringLength(10)]
        public string Marca { get; set; }
        [Required]
        [Display(Name = "Modelo")]      
        public decimal Modelo { get; set; }
        [Required]
        [Display(Name = "Color")]
        [StringLength(10)]
        public string Color { get; set; }
        [Required]
        [Display(Name = "Tipo Vehículo")]
        [StringLength(10)]
        public string TipoVehiculo { get; set; }
        [Required]
        [Display(Name = "Propietario")]
        [StringLength(10)]
        public string EstadoProp { get; set; }

        //Listas
        public List<DominiosDTO> LstColores { get; set; }

    }
}