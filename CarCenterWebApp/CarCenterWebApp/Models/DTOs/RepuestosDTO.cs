using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarCenterWebApp.Models.DTOs
{
    public class RepuestosDTO
    {
        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "ID REPUESTO")]
        [StringLength(10)]
        public Decimal Idrepuesto { get; set; }
        [Required]
        [Display(Name = "DESCRIPCION MENSAJE")]
        [StringLength(100)]
        public String descmensaje { get; set; }



    }
}