using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal_U1_WebII.Models;

namespace TrabajoFinal_U1_WebII.Controllers
{
    public class Ejercicio3Controller : Controller
    {
        // GET: Ejercicio3
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginUsuario()
        {
            ClsEjercicio3 objUsuarioLogin = new ClsEjercicio3();
            if (Request.Form["password"]!= "" || Request.Form["usuario"] != "" || Request.Form["password"] != null || Request.Form[""] != null)
            {
                string usuario = Request.Form["usuario"];
                string password = Request.Form["password"];

                ClsEjercicio3 objEjer3 = new ClsEjercicio3();    
                    objUsuarioLogin = objEjer3.LoginUsuario(usuario, password);
            }


            return View(objUsuarioLogin);
        }
    }
}