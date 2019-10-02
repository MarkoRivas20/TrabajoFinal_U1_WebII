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

        public ActionResult CerrarSesion()
        {
            return View();
        }

        public ActionResult LoginUsuario()
        {
            if (Session.Keys.Count > 0)
            {
                return View();
            }
            else
            {
                ClsEjercicio3 objUsuarioLogin = new ClsEjercicio3();
                if (Request.Form["password"] != "" || Request.Form["usuario"] != "" || Request.Form["password"] != null || Request.Form[""] != null)
                {
                    string usuario = Request.Form["usuario"];
                    string password = Request.Form["password"];

                    ClsEjercicio3 objEjer3 = new ClsEjercicio3();
                    objUsuarioLogin = objEjer3.LoginUsuario(usuario, password);
                    if (objUsuarioLogin != null)
                    {
                        Session["id"] = objUsuarioLogin.id;
                        Session["usuario"] = objUsuarioLogin.usuario;
                        Session["password"] = objUsuarioLogin.password;
                        Session["nombre"] = objUsuarioLogin.nombre;
                        Session["apellido"] = objUsuarioLogin.apellido;
                        Session["dinero"] = objUsuarioLogin.dinero;
                        Session["estado"] = objUsuarioLogin.estado;
                        ViewBag.miEstado = (bool)Session["estado"];
                        Session["tipoCuenta"] = objUsuarioLogin.tipoCuenta;


                    }
                    
                }
                //Session.Contents.RemoveAll();
                return View(objUsuarioLogin);
            }
            
        }
        public ActionResult retirarMonto()
        {
            if (Request.Form["btnRetirar"] != null)
            {
                if (Request.Form["txtMontoRetiro"] != null)
                {
                    double cantidadDineroActual = (double)Session["dinero"];
                    double cantidadRetiro = Convert.ToDouble(Request.Form["txtMontoRetiro"]);
                    string idUsuario = Session["id"].ToString();
                    Session["dinero"] = cantidadDineroActual-cantidadRetiro;
                    ClsEjercicio3 objEjer3=new ClsEjercicio3();
                    objEjer3.retiroBancario(idUsuario, cantidadRetiro, cantidadDineroActual);

                }

            }
            return View();
        }

        public ActionResult depositarMonto()
        {
            if (Request.Form["btnDepositar"] != null)
            {
                if (Request.Form["txtMontoDeposito"] != null)
                {
                    double cantidadDineroActual = (double)Session["dinero"];
                    double cantidadDesposito = Convert.ToDouble(Request.Form["txtMontoDeposito"]);
                    string idUsuario = Session["id"].ToString();
                    Session["dinero"] = cantidadDineroActual + cantidadDesposito;
                    ClsEjercicio3 objEjer3 = new ClsEjercicio3();
                    objEjer3.depositoBancario(idUsuario, cantidadDesposito, cantidadDineroActual);

                }

            }
            return View();
        }

        public ActionResult cambiarPassword()
        {
            if (Request.Form["btnCambiarPassword"] != null)
            {
                if (Request.Form["txtPassword"] != null)
                {
                    string idUsuario = Session["id"].ToString();
                    string passwordUsuario = Request.Form["txtPassword"];
                    Session["password"] = passwordUsuario;
                    ClsEjercicio3 objEjer3 = new ClsEjercicio3();
                    objEjer3.modificarPassword(idUsuario, passwordUsuario);
                }

            }
            return View();
        }
        public ActionResult bloquearTarjeta()
        {
            if (Request.Form["btnBloquearTarjeta"] != null)
            {
                if (Request.Form["cmbEstado"] != null)
                {
                    string idUsuario = Session["id"].ToString();
                    string estado = Request.Form["cmbEstado"];
                    //Session["estado"] = estado;
                    Session.Contents.RemoveAll();
                    ClsEjercicio3 objEjer3 = new ClsEjercicio3();
                    objEjer3.bloquearTarjeta(idUsuario, estado);
                }

            }
            return View();
        }
    }
}