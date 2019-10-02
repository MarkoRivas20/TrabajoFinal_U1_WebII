using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal_U1_WebII.Controllers
{
    public class Ejercicio6cController : Controller
    {
        // GET: Ejercicio6c
        public ActionResult Index()
        {
            return View();
        }
        
        public FileResult DescargarSonido()
        {
            if (Request.Form["aire1"] != null)
            {
                return File("~/Audios/aire1.mp3", "audio/mpeg","aire1.mp3");
            }

            if(Request.Form["aire2"] != null)
            {
                return File("~/Audios/aire1.mp3", "audio/mpeg", "aire2.mp3");
            }

            if (Request.Form["aire3"] != null)
            {
                return File("~/Audios/aire3.mp3", "audio/mpeg", "aire3.mp3");

            }

            if (Request.Form["aire4"] != null)
            {
                return File("~/Audios/aire4.mp3", "audio/mpeg", "aire4.mp3");

            }

            if (Request.Form["disparo"] != null)
            {
                return File("~/Audios/disparo.mp3", "audio/mpeg", "disparo.mp3");

            }

            if (Request.Form["golpe"] != null)
            {
                return File("~/Audios/golpe.mp3", "audio/mpeg", "golpe.mp3");

            }

            if (Request.Form["juas"] != null)
            {
                return File("~/Audios/juas.mp3", "audio/mpeg", "juas.mp3");

            }

            if (Request.Form["laser"] != null)
            {
                return File("~/Audios/laser.mp3", "audio/mpeg", "laser.mp3");

            }
            return File("~/Audios/laser.mp3", "audio/mpeg", "laser.mp3");


        }
    }
}