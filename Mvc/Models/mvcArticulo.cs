using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Mvc.Services;



namespace Mvc.Models
{
    [Table("Articulo")]
    public class mvcArticulo:ICalculadora
    {   [Key]

        public int ArticuloId { get; set; }
        [DisplayName("Nombre")]

        public string ArticuloNombre { get; set; }
        [DisplayName("Precio")]
        public int ArticuloPrecio { get; set; }
        public string NombrePrecio { get { return ArticuloNombre + " " + ArticuloPrecio; } }
      

        public int Multiplicar(int n1, int n2)
        {
            return (ArticuloPrecio);
        }

        public int Restar(int n1, int n2)
        {
            return (ArticuloPrecio);
        }

        public int Sumar(int n1, int n2)
        {
            return(ArticuloPrecio);
        }
    }
}