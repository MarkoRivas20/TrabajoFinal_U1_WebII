using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal_U1_WebII.Models;

namespace TrabajoFinal_U1_WebII.Controllers
{
    public class Ejercicio4Controller : Controller
    {
        // GET: Ejercicio4
        public ActionResult Index(ClsEjercicio4 obj4, string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return View(obj4.Eliminar(id));

            }
            else if (Request.Form["criterio"] == "docente")
            {
                return View(obj4.DocenteSemestre(Request.Form["docente"], Request.Form["semestre"]));
            }
            else if (Request.Form["criterio"] == "ciclo")
            {
                return View(obj4.Ciclo(Request.Form["ciclo"]));
            }
            else if (Request.Form["criterio"] == "tipo")
            {
                return View(obj4.Tipo(Request.Form["tipo"]));
            }
            else
            {
                return View(obj4.ListarCargasAcademicas());
            }
        }

        public ActionResult AgregarCargaAcademica(ClsEjercicio4 obj4)
        {

            return View();
        }

        public ActionResult Agregar(ClsEjercicio4 obj4)
        {
            ClsEjercicio4 Datos = new ClsEjercicio4();
            Datos.idcarga = Request.Form["idcarga"];
            Datos.idsemestre = Request.Form["idsemestre"];
            Datos.codigodocente = Request.Form["codigodocente"];
            Datos.codigocurso = Request.Form["codigocurso"];
            return View("Index", obj4.Agregar(Datos));
        }
        public ActionResult ModificarCargaAcademica(ClsEjercicio4 obj4)
        {

            return View(obj4.Buscar(Request.Form["idcarga"]));
        }

        public ActionResult Modificar(ClsEjercicio4 obj4)
        {
            ClsEjercicio4 Datos = new ClsEjercicio4();
            Datos.idcarga = Request.Form["idcarga"];
            Datos.idsemestre = Request.Form["idsemestre"];
            Datos.codigodocente = Request.Form["codigodocente"];
            Datos.codigocurso = Request.Form["codigocurso"];
            return View("Index", obj4.Modificar(Datos));
        }

        public ActionResult EliminarCargaAcademica(ClsEjercicio4 obj4, string id)
        {
            return View(obj4.Eliminar(id));
        }
    }
}