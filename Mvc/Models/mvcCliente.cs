using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    [Table("Cliente")]
    public class mvcCliente
    {

        public int ClienteId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public string NombreCompleto { get { return Nombre + " " + Apellido; } }
        [Required(ErrorMessage = "Completar DNI")]        
        public string DNI { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
       
    }
}