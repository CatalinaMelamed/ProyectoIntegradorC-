using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class clienteController : Controller
    {
        // GET: cliente
        public ActionResult Index()
        {

            IEnumerable<mvcCliente> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Clientes").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<mvcCliente>>().Result;
            return View(empList);
         
        }
        
        public ActionResult Create()
        {
           
            return View(new mvcCliente());
          

        }
        [HttpPost]
        public ActionResult Create(mvcCliente emp)
        {
            if (emp != null)
            {

                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Clientes/", emp).Result;

            }

            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            mvcCliente cliente;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Clientes/" + id.ToString()).Result;
            cliente = response.Content.ReadAsAsync<mvcCliente>().Result;
            return View("Create", cliente);
        }
        [HttpPost]
        public ActionResult Edit(mvcCliente emp)
        {
            if (emp != null)
            {

                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Clientes/" + emp.ClienteId.ToString(), emp).Result;

            }

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Clientes/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
        public ActionResult Detail(int id)
        {
            if (!String.IsNullOrEmpty(id.ToString()))
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Clientes/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcCliente>().Result);
            }
            else
            {
                return View("Detail", id);

            }

        }
    }
}