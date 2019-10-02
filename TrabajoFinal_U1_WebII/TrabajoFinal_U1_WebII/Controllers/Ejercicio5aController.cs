using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using Newtonsoft.Json;
using System.Data;
using System.Xml.Serialization;
using System.Xml.Linq;
using TrabajoFinal_U1_WebII.Models;
using System.Web.Script.Serialization;

namespace TrabajoFinal_U1_WebII.Controllers
{
    public class Ejercicio5aController : Controller
    {
        // GET: Ejercicio5a
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult MostrarBusqueda()
        {
            ClsEjercicio5a objEjer5a = new ClsEjercicio5a();

            if (Request.Form["tipoCuenta"] !=null)
            {
                var resultado = objEjer5a.BuscarUsuario(Request.Form["tipoCuenta"]);
                resultado.Cast<object>().ToArray();
                return Json(resultado, JsonRequestBehavior.AllowGet);

            }
            else
            {
                var resultado = objEjer5a.BuscarUsuario(Request.Form["tipoCuenta"]);
                resultado.Cast<object>().ToArray();
                return Json(resultado, JsonRequestBehavior.AllowGet);
            }

        }
    }
}