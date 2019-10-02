using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using TrabajoFinal_U1_WebII.Models;

namespace TrabajoFinal_U1_WebII.Models
{
    public class ClsEjercicio5a
    {

        public List<ClsEjercicio3> BuscarUsuario(string tipoCuenta)
        {
            XDocument xmlUsuario = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/clientes.xml"));
            var objEjer = new List<ClsEjercicio3>();
            objEjer = (from c in xmlUsuario.Descendants("cliente")
                             where c.Element("tipocuenta").Value.ToString() == (tipoCuenta)
                             select new ClsEjercicio3
                             {
                                 id = Convert.ToInt32(c.Element("id").Value.ToString()),
                                 usuario = c.Element("usuario").Value.ToString(),
                                 password = c.Element("password").Value.ToString(),
                                 nombre = c.Element("nombre").Value.ToString(),
                                 apellido = c.Element("apellido").Value.ToString(),
                                 dinero = Convert.ToDouble(c.Element("dinero").Value.ToString()),
                                 tipoCuenta = c.Element("tipocuenta").Value.ToString(),
                                 estado = Convert.ToBoolean(c.Element("estado").Value.ToString())

                             }
                             ).ToList();
            return objEjer;
        }

    }
}