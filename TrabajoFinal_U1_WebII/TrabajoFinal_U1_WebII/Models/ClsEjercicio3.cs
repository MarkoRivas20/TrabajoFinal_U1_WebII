using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Librerias agregadas
using System.Data;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace TrabajoFinal_U1_WebII.Models
{
    public class ClsEjercicio3
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public double dinero { get; set; }
        public bool estado { get; set; }
        public string tipoCuenta { get; set; }


        public ClsEjercicio3 LoginUsuario(string usuarioLog, string passwordLog)
        {
            XDocument xmlUsuario = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/clientes.xml"));
            var objEjercicio3 = new ClsEjercicio3();
            objEjercicio3 = (from c in xmlUsuario.Descendants("cliente")
                             where c.Element("usuario").Value.ToString() == (usuarioLog) &&
                                   c.Element("password").Value.ToString() == (passwordLog)
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
                             ).FirstOrDefault();
            return objEjercicio3;
        }

        public void retiroBancario(string idUsuario, double cantidadRetiro, double cantidadDineroActual)
        {
            double dineroactual = cantidadDineroActual - cantidadRetiro;
            XDocument cliente = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/clientes.xml"));
            XElement clienteElement = cliente.Descendants("cliente").Where(c => c.Element("id").Value.Equals(idUsuario.ToString())).FirstOrDefault();
            if (clienteElement != null)
            {
                clienteElement.Element("dinero").Value = dineroactual.ToString();

                cliente.Save(HttpContext.Current.Server.MapPath("~/App_Data/clientes.xml"));
            }

        }

        public void depositoBancario(string idUsuario, double cantidadDeposito, double cantidadDineroActual)
        {
            double dineroactual = cantidadDineroActual + cantidadDeposito;
            XDocument cliente = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/clientes.xml"));
            XElement clienteElement = cliente.Descendants("cliente").Where(c => c.Element("id").Value.Equals(idUsuario.ToString())).FirstOrDefault();
            if (clienteElement != null)
            {
                clienteElement.Element("dinero").Value = dineroactual.ToString();

                cliente.Save(HttpContext.Current.Server.MapPath("~/App_Data/clientes.xml"));
            }

        }

        public void modificarPassword(string idUsuario, string passwordUsuario)
        {
            XDocument cliente = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/clientes.xml"));
            XElement clienteElement = cliente.Descendants("cliente").Where(c => c.Element("id").Value.Equals(idUsuario.ToString())).FirstOrDefault();
            if (clienteElement != null)
            {
                clienteElement.Element("password").Value = passwordUsuario.ToString();

                cliente.Save(HttpContext.Current.Server.MapPath("~/App_Data/clientes.xml"));
            }

        }
        public void bloquearTarjeta(string idUsuario, string estado)
        {
            XDocument cliente = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/clientes.xml"));
            XElement clienteElement = cliente.Descendants("cliente").Where(c => c.Element("id").Value.Equals(idUsuario.ToString())).FirstOrDefault();
            if (clienteElement != null)
            {
                clienteElement.Element("estado").Value = estado.ToString();

                cliente.Save(HttpContext.Current.Server.MapPath("~/App_Data/clientes.xml"));
            }

        }
    }
}