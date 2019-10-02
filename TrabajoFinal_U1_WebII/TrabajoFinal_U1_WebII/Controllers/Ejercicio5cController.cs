using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal_U1_WebII.Models;

namespace TrabajoFinal_U1_WebII.Controllers
{
    public class Ejercicio5cController : Controller
    {
        // GET: Ejercicio5c
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Mostrar(ClsEjercicio5c objejercicio5c)
        {
            double a, b, c;
            a = objejercicio5c.a;
            b = objejercicio5c.b;
            c = objejercicio5c.c;
            objejercicio5c.resultado1 = (-b + (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
            objejercicio5c.resultado2 = (-b - (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
            var persona = objejercicio5c;
            return Json(persona, JsonRequestBehavior.AllowGet);
        }
    }
}