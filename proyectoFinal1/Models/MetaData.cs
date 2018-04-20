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

        [Display(Name = "Nombre Bodega:")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Ingrese la Ubicacion")]
        [Display(Name = "Ubicación:")]
        public string ubicacion { get; set; }

        [StringLength(8, ErrorMessage = "8 Valor max. de digitos")]
        [RegularExpression("^\\d+$", ErrorMessage = "El campo solo acepta números.")]
        [Display(Name = "Teléfono: ")]
        public string telefono { get; set; }
    }

    //clase validaciones producto
    public class productoMetaData {
        public int id { get; set; }
        [Display(Name = "Nombre:")]
        [Remote("nvalido", "productoes", ErrorMessage = "El producto ya exite")]
        public string nombre { get; set; }

        [Display(Name = "Precio Q.")]
        [Required(ErrorMessage ="Debe Ingresar precio")]
        public Nullable<decimal> precio { get; set; }

        [Display(Name = "Bodega:")]
        public virtual bodega bodega1 { get; set; }
        [Display(Name = "Bodega:")]
        public Nullable<int> bodega { get; set; }
    }

    public class facturaMetaData {
        public int id { get; set; }

        [Required(ErrorMessage ="Ingrese Nombre de Cliente")]
        [Display(Name ="CLiente:")]
        public string cliente { get; set; }

        [Required(ErrorMessage ="Ingrese Nit")]
        [Display (Name ="Nit:")]
        public string nit { get; set; }

        [Display(Name = "Producto:")]
        public Nullable<int> producto { get; set; }

        [Display(Name = "Cantidad:")]
        [Required(ErrorMessage = "La cantidad es requerida")]
        [Range(0, 100, ErrorMessage = "La cantidad debe ser entre 0 y 100")]
        public Nullable<int> cantidad { get; set; }

        [Display(Name = "Producto:")]
        public virtual producto producto1 { get; set; }
    }

}