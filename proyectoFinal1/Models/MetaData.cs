using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoFinal1.Models
{
    public class bodegaMetaData
    {
        public int id { get; set; }
        [Remote("nvalido", "bodegas", ErrorMessage = "La bodega ya exite")]

        [Display(Name = "Nombre:")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Ingrese la Ubicacion")]
        [Display(Name = "Ubicacion:")]
        public string ubicacion { get; set; }

        [StringLength(8, ErrorMessage = "8 Valor max. de digitos")]
        [RegularExpression("^\\d+$", ErrorMessage = "El campo solo acepta números.")]
        public string telefono { get; set; }
    }
}