using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal_U1_WebII.Models;

namespace TrabajoFinal_U1_WebII.Controllers
{
    public class Ejercicio2Controller : Controller
    {
        // GET: Ejercicio2
        public ActionResult Index(ClsEjercicio2 objejercicio2)
        {
            if (Request.Form["Generar"] != null)
            {
                ViewBag.fil = objejercicio2.fil;
                ViewBag.col = objejercicio2.col;
            }
            return View(objejercicio2);
        }
        public ActionResult Mostrar(ClsEjercicio2 objejercicio2)
        {
            int c1 = 0;
            double[,] matrizA = new double[objejercicio2.fil, objejercicio2.col];
            double[,] matrizB = new double[objejercicio2.fil, objejercicio2.col];
            double[,] matrizSuma = new double[objejercicio2.fil, objejercicio2.col];
            double[,] matrizResta = new double[objejercicio2.fil, objejercicio2.col];
            double[,] matrizmultiplicacion = new double[objejercicio2.fil, objejercicio2.col];
            for (int i = 0; i < objejercicio2.fil; i++)
            {
                for (int j = 0; j < objejercicio2.col; j++)
                {
                    matrizA[i, j] = Convert.ToDouble(Request.Form["MatrizA" + c1]);
                    matrizB[i, j] = Convert.ToDouble(Request.Form["MatrizB" + c1]);
                    matrizSuma[i, j] = matrizA[i, j] + matrizB[i, j];
                    matrizResta[i, j] = matrizA[i, j] - matrizB[i, j];


                    c1++;
                }
            }
            for (int i = 0; i < objejercicio2.fil; i++)
            {
                for (int j = 0; j < objejercicio2.col; j++)
                {
                    matrizmultiplicacion[i, j] = 0;
                    for (int z = 0; z < objejercicio2.col; z++)
                    {
                        matrizmultiplicacion[i, j] = matrizA[i, z] * matrizB[z, j] + matrizmultiplicacion[i, j];
                    }

                }
            }
            ViewBag.matrizSuma = matrizSuma;
            ViewBag.matrizResta = matrizResta;
            ViewBag.matrizMultiplicacion = matrizmultiplicacion;
            return View(objejercicio2);
        }
    }
}