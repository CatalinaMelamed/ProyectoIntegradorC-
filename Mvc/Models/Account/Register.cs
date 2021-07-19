using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc.Models.Account
{
    public class Register
    {
     
        //UserName
        [Required]
        [Display(Name = "Usuario")]
        public string Usuario{ get; set; }

        //Password
        [Required]
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos{2}caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        //Confirm Password
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Contraseña")]
        [Compare("Contraseña", ErrorMessage = "La contraseña y la confirmacion de contraseña no coiciden")]
        public string ConfirmPassword { get; set; }
    }
}