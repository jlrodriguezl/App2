using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarCenterWebApp.Models.DTOs
{
    public class DominiosDTO
    {
       [Required]
       [Display(Name = "Tipo Dominio")]
       [StringLength(50)]
        public String TipoDominio { get; set; }
        [Required]
        [Display(Name = "Id Dominio")]
        [StringLength(10)]
        public String IdDominio { get; set; }
        [Required]
        [Display(Name = "Valor Dominio")]
        [StringLength(50)]
        public String VlrDominio { get; set; }
    }
}