using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoFinal_U1_WebII.Models
{
    public class ClsEjercicio1
    {
        public int[,] matriz { get; set; } = new int[3, 3];
        public double promedio { get; set; }

        public int mayor { get; set; }
        public int menor { get; set; }
        public int diagonalprincipal { get; set; }
        public int diagonalsecundaria { get; set; }
        public int valoresencima { get; set; }
        public int valoresdebajo { get; set; }
    }
}