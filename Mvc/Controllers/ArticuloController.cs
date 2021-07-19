using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;

namespace Mvc.Controllers
{
    public class ArticuloController : Controller
    {
        public ActionResult Index()
        {

            IEnumerable<mvcArticulo> artList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Articuloes").Result;
            artList = response.Content.ReadAsAsync<IEnumerable<mvcArticulo>>().Result;
            return View(artList);
        }
        public ActionResult Create()
        {
         
            return View(new mvcArticulo());
           

        }
        [HttpPost]
        public ActionResult Create(mvcArticulo art)
        {
            if (art!= null)
            {

                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Articuloes/", art).Result;

            }

            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            mvcArticulo articulo;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Articuloes/" + id.ToString()).Result;
            articulo = response.Content.ReadAsAsync<mvcArticulo>().Result;
            return View("Create", articulo);
        }
        [HttpPost]
        public ActionResult Edit(mvcArticulo art)
        {
            if (art != null)
            {

                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Articuloes/" + art.ArticuloId.ToString(), art).Result;

            }

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Articuloes/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
  
    }
}