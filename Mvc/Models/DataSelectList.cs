using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class DataSelectList
    {
        public IEnumerable<mvcCliente> Clientes { get; set; }
        public IEnumerable<mvcArticulo> Articulos { get; set; }
       
    }
}