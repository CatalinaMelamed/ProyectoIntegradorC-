using Mvc.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mvc.Controllers
{
    public class AccountController : Controller
    {
        //public ActionResult Index ()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult loginform(FormCollection collection)
        //{
        //    string email = collection.Get("email");
        //    string contraseña = collection.Get("Contraseña");
        //    if (email == "")
        //}

        //GET: /Account/Login
        //public ActionResult Login()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Login(Login model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (Membership.ValidateUser(model.Usuario, model.Contraseña))
        //        {
        //            FormsAuthentication.SetAuthCookie(model.Usuario, model.RecordarCuenta);                    
                    
        //            return RedirectToAction("Index", "Layout");
                    
        //        }
        //        else
        //        {
        //            ModelState.AddModelError(" ", "El Usuario o Contraseña es incorrecto");
        //        }

        //    }
        //    return View(model);
        //}
        //// GET: /Account/LogOff
        //public ActionResult LogOff()
        //{
        //    FormsAuthentication.SignOut();
        //    return RedirectToAction("Index", "Layout");
        //}

        ////
        //// GET: /Account/Register
        //public ActionResult Register()
        //{
        //    return View();
        //}

        ////
        //// POST: /Account/Register
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Register(Register model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // Intento de Registrar al usuario/a
        //        try
        //        {
        //            MembershipUser NewUser = Membership.CreateUser(model.Usuario, model.Password);
        //            //Iniciar la sesion del usuario con la neuva cuneta
        //            FormsAuthentication.SetAuthCookie(model.Usuario, false);
        //            return RedirectToAction("Index", "Layout");
        //        }
        //        catch (MembershipCreateUserException e)
        //        {
        //            ModelState.AddModelError("Error de Registro", "Error de Registro: " + e.StatusCode.ToString());
        //        }
        //    }

        //    return View(model);
        //}

        //public enum ManageMessageId
        //{
        //    ChangePasswordSuccess,
        //    SetPasswordSuccess,
        //}
    }
}