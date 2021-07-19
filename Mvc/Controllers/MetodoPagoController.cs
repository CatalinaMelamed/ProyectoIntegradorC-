using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class MetodoPagoController : Controller
    {
        // GET: MetodoPago
        public ActionResult Index()
        {

            IEnumerable<mvcMetodoPago> metList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("MetodoPagoes").Result;
            metList = response.Content.ReadAsAsync<IEnumerable<mvcMetodoPago>>().Result;
            return View(metList);
        }
        public ActionResult Create()
        {

            return View(new mvcMetodoPago());


        }
        [HttpPost]
        public ActionResult Create(mvcMetodoPago met)
        {
            if (met != null)
            {

                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("MetodoPagoes/", met).Result;

            }

            return RedirectToAction("Index");
        }
    }
}