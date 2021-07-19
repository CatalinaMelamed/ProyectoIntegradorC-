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
using WebApi.Models;

namespace Mvc.Controllers
{
    public class LayoutController : Controller
    {
        public ActionResult Index()
        { 
            return View("~/Views/Shared/_Layout.cshtml");
        }

        //public bool already_dni(string dni)
        //{
        //    bool existe = false;
        //    using (MySqlConnection connection = new MySqlConnection(MyConnectionString))
        //    {
        //        connection.Open();
        //        string query = "SELECT COUNT(*) FROM dni WHERE nick_dni=@DNI"
        //    }
        //}




        public ActionResult Login(Mvc.Models.mvcCliente mvcCliente)
        {
            if (!String.IsNullOrEmpty(mvcCliente.DNI))
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync($"ValidateExistDocument/{ mvcCliente.DNI}").Result;
                bool encontreDNI = response.Content.ReadAsAsync<bool>().Result;
                if (encontreDNI != true)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
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