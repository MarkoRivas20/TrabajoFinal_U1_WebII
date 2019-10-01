using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal_U1_WebII.Controllers
{
    public class Ejercicio6aController : Controller
    {
        // GET: Ejercicio6a
        public ActionResult Index()
        {
            return View();
        }
        public FileResult Mostrar()
        {
            if (Request.Form["Generar1"] != null)
            {
                return File("~/Documentos/BO20190921.pdf", "application/pdf");
            }
            if (Request.Form["Generar2"] != null)
            {
                return File("~/Documentos/BO20190922.pdf", "application/pdf");
            }
            if (Request.Form["Generar3"] != null)
            {
                return File("~/Documentos/BO20190923.pdf", "application/pdf");
            }
            if (Request.Form["Generar4"] != null)
            {
                return File("~/Documentos/BO20190924.pdf", "application/pdf");
            }
            if (Request.Form["Generar5"] != null)
            {
                return File("~/Documentos/BO20190925.pdf", "application/pdf");
            }
            if (Request.Form["Generar6"] != null)
            {
                return File("~/Documentos/BO20190926.pdf", "application/pdf");
            }
            if (Request.Form["Generar7"] != null)
            {
                return File("~/Documentos/BO20190927.pdf", "application/pdf");
            }
            if (Request.Form["Generar8"] != null)
            {
                return File("~/Documentos/BO20190928.pdf", "application/pdf");
            }
            if (Request.Form["Generar9"] != null)
            {
                return File("~/Documentos/BO20190929.pdf", "application/pdf");
            }
            if (Request.Form["Generar10"] != null)
            {
                return File("~/Documentos/BO20190930.pdf", "application/pdf");
            }
            else
            {
                return File("~/Documentos/EXPEDICION_DOCUMENTOS_OFICIALES_EN_SECRETARIA_GENERAL_2015.pdf", "application/pdf");
            }


        }
    }
}