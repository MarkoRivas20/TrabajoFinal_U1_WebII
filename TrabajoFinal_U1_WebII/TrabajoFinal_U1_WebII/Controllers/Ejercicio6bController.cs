using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal_U1_WebII.Controllers
{
    public class Ejercicio6bController : Controller
    {
        // GET: Ejercicio3
        public ActionResult Index()
        {
            return View();

        }
        public FileResult TasaMora()
        {
            if (Request.Form["Generar1"] != null)
            {
                var ruta = Server.MapPath("~/Documentos/DIRECTIVA_2019_NUEVA_TASA_MORA.pdf");
                return File(ruta, "application/pdf", "DIRECTIVA_2019_NUEVA_TASA_MORA.pdf");
            }
            if (Request.Form["Generar2"] != null)
            {
                var ruta = Server.MapPath("~/Documentos/DIRECTIVA_2019_COBRANZAS.pdf");
                return File(ruta, "application/pdf", "DIRECTIVA_2019_COBRANZAS.pdf");
            }
            if (Request.Form["Generar3"] != null)
            {
                var ruta = Server.MapPath("~/Documentos/reglamento_general_upt.pdf");
                return File(ruta, "application/pdf", "reglamento_general_upt.pdf");
            }
            if (Request.Form["Generar4"] != null)
            {
                var ruta = Server.MapPath("~/Documentos/estatuto.pdf");
                return File(ruta, "application/pdf", "estatuto.pdf");
            }
            if (Request.Form["Generar5"] != null)
            {
                var ruta = Server.MapPath("~/Documentos/REGLAMENTO_MATRICULA_ESTUDIOSYEVALUACION.pdf");
                return File(ruta, "application/pdf", "REGLAMENTO_MATRICULA_ESTUDIOSYEVALUACION.pdf");
            }
            if (Request.Form["Generar6"] != null)
            {
                var ruta = Server.MapPath("~/Documentos/REGLAMENTO_GRADOS-TITULOS_AGOSTO_2015.pdf");
                return File(ruta, "application/pdf", "REGLAMENTO_GRADOS-TITULOS_AGOSTO_2015.pdf");
            }
            if (Request.Form["Generar7"] != null)
            {
                var ruta = Server.MapPath("~/Documentos/REGLAMENTO_DIPLOMADO_ POSTGRADO_setiembre_2015.pdf");
                return File(ruta, "application/pdf", "REGLAMENTO_DIPLOMADO_ POSTGRADO_setiembre_2015.pdf");
            }
            if (Request.Form["Generar8"] != null)
            {
                //return File("~/Documentos/EXPEDICION_DOCUMENTOS_OFICIALES_EN_SECRETARIA_GENERAL_2015.pdf", "application/pdf");
                var ruta = Server.MapPath("~/Documentos/EXPEDICION_DOCUMENTOS_OFICIALES_EN_SECRETARIA_GENERAL_2015.pdf");
                return File(ruta, "application/pdf", "EXPEDICION_DOCUMENTOS_OFICIALES_EN_SECRETARIA_GENERAL_2015.pdf");
            }
            else
            {
                var ruta = Server.MapPath("~/Documentos/DIRECTIVA_2019_NUEVA_TASA_MORA.pdf");
                return File(ruta, "application/pdf", "DIRECTIVA_2019_NUEVA_TASA_MORA.pdf");
            }


        }
    }
}