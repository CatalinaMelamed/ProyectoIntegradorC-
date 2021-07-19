using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    [Table("MetodoPago")]
    public partial class mvcMetodoPago
    {
        public int PagoId { get; set; }
        [DisplayName("Metodo de Pago")]
        public string MetodoPago1 { get; set; }
    }
}