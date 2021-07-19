using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    [Table("Articulo")]
    public class mvcArticulo
    {   [Key]

        public int ArticuloId { get; set; }
        [DisplayName("Nombre")]

        public string ArticuloNombre { get; set; }
        [DisplayName("Precio")]
        public int ArticuloPrecio { get; set; }
        public string NombrePrecio { get { return ArticuloNombre + " " + ArticuloPrecio; } }
    }
}