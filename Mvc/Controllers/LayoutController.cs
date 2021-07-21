using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using WebApi.Models;

namespace Mvc.Controllers
{
    public class LayoutController : Controller
    {
        public ActionResult Index()
        { 
            return View("~/Views/Shared/_Layout.cshtml");
        }    
        public ActionResult Login(Mvc.Models.mvcCliente mvcCliente)
        {
            if (!String.IsNullOrEmpty(mvcCliente.DNI))
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync($"ValidateExistDocument/{ mvcCliente.DNI}").Result;
                bool encontreDNI = response.Content.ReadAsAsync<bool>().Result;
                if (encontreDNI != true)
                {
                    MessageBox.Show("Error al Ingresar DNI");
                    return RedirectToAction("Index");
                    
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("¡Bienvenido! Que desea pedir hoy?");
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                MessageBox.Show("Error No has ingresado ningún DNI");
                return RedirectToAction("Index");

            }
        }
       

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}