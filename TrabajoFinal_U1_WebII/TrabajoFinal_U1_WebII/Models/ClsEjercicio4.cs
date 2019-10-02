using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace TrabajoFinal_U1_WebII.Models
{
    public class ClsEjercicio4
    {
        public String idcarga { get; set; }
        public String idsemestre { get; set; }
        public String nombresemestre { get; set; }
        public String codigodocente { get; set; }
        public String nombredocente { get; set; }
        public String apellidodocente { get; set; }
        public String nombresdocente { get; set; }
        public String codigocurso { get; set; }
        public String nombrecurso { get; set; }
        public String tipocurso { get; set; }
        public String ciclocurso { get; set; }

        public List<ClsEjercicio4> ListarCargasAcademicas()
        {
            //origen de fuente de datos
            XDocument xmldocente = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/docente.xml"));
            XDocument xmlcargaacademica = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/cargaacademica.xml"));
            XDocument xmlcurso = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/curso.xml"));
            XDocument xmlsemestre = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/semestre.xml"));


            //definir la sentencia LINQ
            var objEjercicio4 = new List<ClsEjercicio4>();
            objEjercicio4 = (from colDoc in xmldocente.Descendants("docente")
                             join colCar in xmlcargaacademica.Descendants("cargaacademica")
                             on colDoc.Element("codigo").Value equals colCar.Element("codigodocente").Value
                             join colCur in xmlcurso.Descendants("curso")
                             on colCar.Element("codigocurso").Value equals colCur.Element("codigo").Value
                             join colSem in xmlsemestre.Descendants("semestre")
                             on colCar.Element("idsemestre").Value equals colSem.Element("id").Value

                             //orderby colCar.Element("nombre").ToString()
                             select new ClsEjercicio4()
                             {
                                 idcarga = colCar.Element("idcarga").Value,
                                 idsemestre = colSem.Element("id").Value,
                                 nombresemestre = colSem.Element("nombre").Value,
                                 codigodocente = colDoc.Element("codigo").Value,
                                 nombredocente = colDoc.Element("nombre").Value,
                                 apellidodocente = colDoc.Element("apellido").Value,
                                 nombresdocente = colDoc.Element("nombre").Value + " " + colDoc.Element("apellido").Value,
                                 codigocurso = colCur.Element("codigo").Value,
                                 nombrecurso = colCur.Element("nombrecurso").Value,
                                 tipocurso = colCur.Element("tipo").Value,
                                 ciclocurso = colCur.Element("ciclo").Value,
                             }).ToList();

            return objEjercicio4;
        }

        public List<ClsEjercicio4> Eliminar(string id)
        {
            string path = HttpContext.Current.Server.MapPath("~/App_Data/cargaacademica.xml");
            XDocument xdoc = XDocument.Load(path);

            var carga = xdoc.Descendants("cargaacademica").Single(p => p.Element("idcarga").Value.Equals(id));
            carga.Remove();
            xdoc.Save(path);

            XDocument xmldocente = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/docente.xml"));
            XDocument xmlcargaacademica = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/cargaacademica.xml"));
            XDocument xmlcurso = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/curso.xml"));
            XDocument xmlsemestre = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/semestre.xml"));


            //definir la sentencia LINQ
            var objEjercicio4 = new List<ClsEjercicio4>();
            objEjercicio4 = (from colDoc in xmldocente.Descendants("docente")
                             join colCar in xmlcargaacademica.Descendants("cargaacademica")
                             on colDoc.Element("codigo").Value equals colCar.Element("codigodocente").Value
                             join colCur in xmlcurso.Descendants("curso")
                             on colCar.Element("codigocurso").Value equals colCur.Element("codigo").Value
                             join colSem in xmlsemestre.Descendants("semestre")
                             on colCar.Element("idsemestre").Value equals colSem.Element("id").Value

                             //orderby colCar.Element("nombre").ToString()
                             select new ClsEjercicio4()
                             {
                                 idcarga = colCar.Element("idcarga").Value,
                                 idsemestre = colSem.Element("id").Value,
                                 nombresemestre = colSem.Element("nombre").Value,
                                 codigodocente = colDoc.Element("codigo").Value,
                                 nombredocente = colDoc.Element("nombre").Value,
                                 apellidodocente = colDoc.Element("apellido").Value,
                                 nombresdocente = colDoc.Element("nombre").Value + " " + colDoc.Element("apellido").Value,
                                 codigocurso = colCur.Element("codigo").Value,
                                 nombrecurso = colCur.Element("nombrecurso").Value,
                                 tipocurso = colCur.Element("tipo").Value,
                                 ciclocurso = colCur.Element("ciclo").Value,
                             }).ToList();

            return objEjercicio4;
        }

        public List<ClsEjercicio4> Agregar(ClsEjercicio4 obj4)
        {
            string path = HttpContext.Current.Server.MapPath("~/App_Data/cargaacademica.xml");
            XDocument xdoc = XDocument.Load(path);

            XElement emp = new XElement("cargaacademica",
            new XElement("idcarga", obj4.idcarga),
            new XElement("idsemestre", obj4.idsemestre),
            new XElement("codigodocente", obj4.codigodocente),
            new XElement("codigocurso", obj4.codigocurso));
            xdoc.Root.Add(emp);
            xdoc.Save(path);

            XDocument xmldocente = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/docente.xml"));
            XDocument xmlcargaacademica = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/cargaacademica.xml"));
            XDocument xmlcurso = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/curso.xml"));
            XDocument xmlsemestre = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/semestre.xml"));


            //definir la sentencia LINQ
            var objEjercicio4 = new List<ClsEjercicio4>();
            objEjercicio4 = (from colDoc in xmldocente.Descendants("docente")
                             join colCar in xmlcargaacademica.Descendants("cargaacademica")
                             on colDoc.Element("codigo").Value equals colCar.Element("codigodocente").Value
                             join colCur in xmlcurso.Descendants("curso")
                             on colCar.Element("codigocurso").Value equals colCur.Element("codigo").Value
                             join colSem in xmlsemestre.Descendants("semestre")
                             on colCar.Element("idsemestre").Value equals colSem.Element("id").Value

                             //orderby colCar.Element("nombre").ToString()
                             select new ClsEjercicio4()
                             {
                                 idcarga = colCar.Element("idcarga").Value,
                                 idsemestre = colSem.Element("id").Value,
                                 nombresemestre = colSem.Element("nombre").Value,
                                 codigodocente = colDoc.Element("codigo").Value,
                                 nombredocente = colDoc.Element("nombre").Value,
                                 apellidodocente = colDoc.Element("apellido").Value,
                                 nombresdocente = colDoc.Element("nombre").Value + " " + colDoc.Element("apellido").Value,
                                 codigocurso = colCur.Element("codigo").Value,
                                 nombrecurso = colCur.Element("nombrecurso").Value,
                                 tipocurso = colCur.Element("tipo").Value,
                                 ciclocurso = colCur.Element("ciclo").Value,
                             }).ToList();

            return objEjercicio4;
        }

        public List<ClsEjercicio4> Modificar(ClsEjercicio4 obj4)
        {
            string path = HttpContext.Current.Server.MapPath("~/App_Data/cargaacademica.xml");
            XDocument xdoc = XDocument.Load(path);

            XElement emp = xdoc.Descendants("cargaacademica").FirstOrDefault(p => p.Element("idcarga").Value == obj4.idcarga);
            if (emp != null)
            {
                emp.Element("idsemestre").Value = obj4.idsemestre;
                emp.Element("codigodocente").Value = obj4.codigodocente;
                emp.Element("codigocurso").Value = obj4.codigocurso;
                xdoc.Save(path);
            }


            XDocument xmldocente = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/docente.xml"));
            XDocument xmlcargaacademica = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/cargaacademica.xml"));
            XDocument xmlcurso = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/curso.xml"));
            XDocument xmlsemestre = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/semestre.xml"));


            //definir la sentencia LINQ
            var objEjercicio4 = new List<ClsEjercicio4>();
            objEjercicio4 = (from colDoc in xmldocente.Descendants("docente")
                             join colCar in xmlcargaacademica.Descendants("cargaacademica")
                             on colDoc.Element("codigo").Value equals colCar.Element("codigodocente").Value
                             join colCur in xmlcurso.Descendants("curso")
                             on colCar.Element("codigocurso").Value equals colCur.Element("codigo").Value
                             join colSem in xmlsemestre.Descendants("semestre")
                             on colCar.Element("idsemestre").Value equals colSem.Element("id").Value

                             //orderby colCar.Element("nombre").ToString()
                             select new ClsEjercicio4()
                             {
                                 idcarga = colCar.Element("idcarga").Value,
                                 idsemestre = colSem.Element("id").Value,
                                 nombresemestre = colSem.Element("nombre").Value,
                                 codigodocente = colDoc.Element("codigo").Value,
                                 nombredocente = colDoc.Element("nombre").Value,
                                 apellidodocente = colDoc.Element("apellido").Value,
                                 nombresdocente = colDoc.Element("nombre").Value + " " + colDoc.Element("apellido").Value,
                                 codigocurso = colCur.Element("codigo").Value,
                                 nombrecurso = colCur.Element("nombrecurso").Value,
                                 tipocurso = colCur.Element("tipo").Value,
                                 ciclocurso = colCur.Element("ciclo").Value,
                             }).ToList();

            return objEjercicio4;
        }

        public List<ClsEjercicio4> DocenteSemestre(string docente, string semestre)
        {
            //origen de fuente de datos
            XDocument xmldocente = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/docente.xml"));
            XDocument xmlcargaacademica = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/cargaacademica.xml"));
            XDocument xmlcurso = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/curso.xml"));
            XDocument xmlsemestre = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/semestre.xml"));


            //definir la sentencia LINQ
            var objEjercicio4 = new List<ClsEjercicio4>();
            objEjercicio4 = (from colDoc in xmldocente.Descendants("docente")
                             join colCar in xmlcargaacademica.Descendants("cargaacademica")
                             on colDoc.Element("codigo").Value equals colCar.Element("codigodocente").Value
                             join colCur in xmlcurso.Descendants("curso")
                             on colCar.Element("codigocurso").Value equals colCur.Element("codigo").Value
                             join colSem in xmlsemestre.Descendants("semestre")
                             on colCar.Element("idsemestre").Value equals colSem.Element("id").Value
                             where colDoc.Element("apellido").Value == (docente) &&
                             colSem.Element("nombre").Value == (semestre)

                             //orderby colCar.Element("nombre").ToString()
                             select new ClsEjercicio4()
                             {
                                 idcarga = colCar.Element("idcarga").Value,
                                 idsemestre = colSem.Element("id").Value,
                                 nombresemestre = colSem.Element("nombre").Value,
                                 codigodocente = colDoc.Element("codigo").Value,
                                 nombredocente = colDoc.Element("nombre").Value,
                                 apellidodocente = colDoc.Element("apellido").Value,
                                 nombresdocente = colDoc.Element("nombre").Value + " " + colDoc.Element("apellido").Value,
                                 codigocurso = colCur.Element("codigo").Value,
                                 nombrecurso = colCur.Element("nombrecurso").Value,
                                 tipocurso = colCur.Element("tipo").Value,
                                 ciclocurso = colCur.Element("ciclo").Value,
                             }).ToList();

            return objEjercicio4;
        }

        public List<ClsEjercicio4> Ciclo(string ciclo)
        {
            //origen de fuente de datos
            XDocument xmldocente = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/docente.xml"));
            XDocument xmlcargaacademica = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/cargaacademica.xml"));
            XDocument xmlcurso = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/curso.xml"));
            XDocument xmlsemestre = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/semestre.xml"));


            //definir la sentencia LINQ
            var objEjercicio4 = new List<ClsEjercicio4>();
            objEjercicio4 = (from colDoc in xmldocente.Descendants("docente")
                             join colCar in xmlcargaacademica.Descendants("cargaacademica")
                             on colDoc.Element("codigo").Value equals colCar.Element("codigodocente").Value
                             join colCur in xmlcurso.Descendants("curso")
                             on colCar.Element("codigocurso").Value equals colCur.Element("codigo").Value
                             join colSem in xmlsemestre.Descendants("semestre")
                             on colCar.Element("idsemestre").Value equals colSem.Element("id").Value
                             where colCur.Element("ciclo").Value == (ciclo)

                             //orderby colCar.Element("nombre").ToString()
                             select new ClsEjercicio4()
                             {
                                 idcarga = colCar.Element("idcarga").Value,
                                 idsemestre = colSem.Element("id").Value,
                                 nombresemestre = colSem.Element("nombre").Value,
                                 codigodocente = colDoc.Element("codigo").Value,
                                 nombredocente = colDoc.Element("nombre").Value,
                                 apellidodocente = colDoc.Element("apellido").Value,
                                 nombresdocente = colDoc.Element("nombre").Value + " " + colDoc.Element("apellido").Value,
                                 codigocurso = colCur.Element("codigo").Value,
                                 nombrecurso = colCur.Element("nombrecurso").Value,
                                 tipocurso = colCur.Element("tipo").Value,
                                 ciclocurso = colCur.Element("ciclo").Value,
                             }).ToList();

            return objEjercicio4;
        }

        public List<ClsEjercicio4> Tipo(string tipo)
        {
            //origen de fuente de datos
            XDocument xmldocente = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/docente.xml"));
            XDocument xmlcargaacademica = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/cargaacademica.xml"));
            XDocument xmlcurso = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/curso.xml"));
            XDocument xmlsemestre = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/semestre.xml"));


            //definir la sentencia LINQ
            var objEjercicio4 = new List<ClsEjercicio4>();
            objEjercicio4 = (from colDoc in xmldocente.Descendants("docente")
                             join colCar in xmlcargaacademica.Descendants("cargaacademica")
                             on colDoc.Element("codigo").Value equals colCar.Element("codigodocente").Value
                             join colCur in xmlcurso.Descendants("curso")
                             on colCar.Element("codigocurso").Value equals colCur.Element("codigo").Value
                             join colSem in xmlsemestre.Descendants("semestre")
                             on colCar.Element("idsemestre").Value equals colSem.Element("id").Value
                             where colCur.Element("tipo").Value == (tipo)

                             //orderby colCar.Element("nombre").ToString()
                             select new ClsEjercicio4()
                             {
                                 idcarga = colCar.Element("idcarga").Value,
                                 idsemestre = colSem.Element("id").Value,
                                 nombresemestre = colSem.Element("nombre").Value,
                                 codigodocente = colDoc.Element("codigo").Value,
                                 nombredocente = colDoc.Element("nombre").Value,
                                 apellidodocente = colDoc.Element("apellido").Value,
                                 nombresdocente = colDoc.Element("nombre").Value + " " + colDoc.Element("apellido").Value,
                                 codigocurso = colCur.Element("codigo").Value,
                                 nombrecurso = colCur.Element("nombrecurso").Value,
                                 tipocurso = colCur.Element("tipo").Value,
                                 ciclocurso = colCur.Element("ciclo").Value,
                             }).ToList();

            return objEjercicio4;
        }

        public ClsEjercicio4 Buscar(string idcarga)
        {
            var objEjercicio4 = new ClsEjercicio4();

            string path = HttpContext.Current.Server.MapPath("~/App_Data/cargaacademica.xml");
            XDocument xdoc = XDocument.Load(path);

            var carga = xdoc.Descendants("cargaacademica").Single(p => p.Element("idcarga").Value.Equals(idcarga));

            objEjercicio4.idcarga = carga.Element("idcarga").Value;
            objEjercicio4.idsemestre = carga.Element("idsemestre").Value;
            objEjercicio4.codigodocente = carga.Element("codigodocente").Value;
            objEjercicio4.codigocurso = carga.Element("codigocurso").Value;


            return objEjercicio4;
        }
    }
}