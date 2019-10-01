using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal_U1_WebII.Models;

namespace TrabajoFinal_U1_WebII.Controllers
{
    public class Ejercicio1Controller : Controller
    {
        // GET: Ejercicio1
        public ActionResult Index(ClsEjercicio1 objejercicio1)
        {
            Random rnd = new Random();
            int suma = 0, may = 0, men = 99;
            double media = 0.0;
            int diagonalprincipal = 0;
            int diagonalsecundaria = 0;
            int valoresencima = 0;
            int valoresdebajo = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    objejercicio1.matriz[i, j] = rnd.Next(0, 200);
                    suma = suma + objejercicio1.matriz[i, j];
                    if (objejercicio1.matriz[i, j] > may)
                    {
                        may = objejercicio1.matriz[i, j];
                    }
                    if (objejercicio1.matriz[i, j] < men)
                    {
                        men = objejercicio1.matriz[i, j];
                    }
                    if (i == j)
                    {
                        diagonalprincipal = diagonalprincipal + objejercicio1.matriz[i, j];
                    }
                }
            }
            for (int i = 2; i >= 0; i--)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((3 - 1 - i) == j)
                    {
                        diagonalsecundaria = diagonalsecundaria + objejercicio1.matriz[i, j];
                    }
                }

            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (objejercicio1.matriz[i, j] > diagonalprincipal)
                    {
                        valoresencima = valoresencima + objejercicio1.matriz[i, j];
                    }
                    if (objejercicio1.matriz[i, j] < diagonalprincipal)
                    {
                        valoresdebajo = valoresdebajo + objejercicio1.matriz[i, j];
                    }
                }
            }
            media = suma / 9;
            objejercicio1.promedio = media;
            objejercicio1.mayor = may;
            objejercicio1.menor = men;
            objejercicio1.diagonalprincipal = diagonalprincipal;
            objejercicio1.diagonalsecundaria = diagonalsecundaria;
            objejercicio1.valoresencima = valoresencima;
            objejercicio1.valoresdebajo = valoresdebajo;
            return View(objejercicio1);
        }
    }
}