using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoreDA;

namespace Modulo5.Areas.Administrador.Controllers
{
    public class MainController : Controller
    {
        // GET: Administrador/Main
        public ActionResult IndexProyecto()
        {
            return View();
        }

        public ActionResult IndexArchivoInvestigacion()
        {
            return View();
        }

        public ActionResult ListadoP()
        {
            ViewBag.ListadoProyecto = DataAccessGeneral.listadoProyecto();
            return PartialView(DataAccessGeneral.listadoProyecto());
            //return View();
        }

        public ActionResult FormProyecto()
        {
            return PartialView();
        }

        public ActionResult Form_Part_Proy()
        {
            return PartialView();
        }

        public ActionResult ListadoAI()
        {
            return PartialView(DataAccessGeneral.listadoArchivoI());
        }

        public ActionResult FormArchivoI()
        {
            return PartialView();
        }

        public ActionResult Form_Part_ArchivoI()
        {
            return PartialView();
        }

        // cuando son llamdas asincronas
        public JsonResult GrabarProyecto(string titulo, string absract,
            string keyword, string fecha_pub, string tipo, DateTime fecha_ini, DateTime fecha_fini, string link,
            int estado, int usuario_crea, int Id_usuario, string rol)
        {
            Proyecto proyecto = new Proyecto();

            proyecto.Titulo = titulo;
            proyecto.Abstract = absract;
            proyecto.Keywords = keyword;
            proyecto.Fecha_pub = fecha_pub;
            proyecto.Tipo = tipo;
            proyecto.Fecha_ini = fecha_ini;
            proyecto.Fecha_fin = fecha_fini;
            proyecto.Link_file = link;
            proyecto.Estado = estado;
            proyecto.ID_Usuario_crea = usuario_crea;


            Det_Partic_Proyecto participante = new Det_Partic_Proyecto();
            participante.ID_Usuario = Id_usuario;
            participante.Rol = rol;

            // texto satisfactorio

            bool exito = DataAccessGeneral.RegistrarProyecto(proyecto);
            bool exito1 = DataAccessGeneral.RegistrarParticipante(participante);

            string mensaje = string.Empty;

            if (exito && exito1)
            {
                mensaje = "Registro satisfactorio";
            }
            else
            {
                mensaje = "Ha ocurrido un error. Intente nuevamente";
            }

            return Json(mensaje, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GrabarArchivoI(string nombre, string descripcion,
            DateTime fecha_invest, DateTime fecha_pub_ini, DateTime fecha_pub_fin, string foto, int estado, string referencia,
            DateTime fecha_crea, int usuario_crea, DateTime fecha_mod, int usuario_mod, string link_file, string keywords, int id_proyecto, string AI_externo, int id_usuario, string rol)
        {
            Archivo_Investigacion archivoI = new Archivo_Investigacion();
            archivoI.Nombre = nombre;
            archivoI.Descripcion = descripcion;
            archivoI.Fecha_invest = fecha_invest;
            archivoI.Fecha_pub_ini = fecha_pub_ini;
            archivoI.Fecha_pub_fin = fecha_pub_fin;
            archivoI.Foto = foto;
            archivoI.Estado = estado;
            archivoI.Referencia = referencia;
            archivoI.Fecha_crea = fecha_crea;
            archivoI.ID_Usuario_crea = usuario_crea;
            archivoI.Fecha_mod = fecha_mod;
            archivoI.ID_Usuario_mod = usuario_mod;
            archivoI.Link_file = link_file;
            archivoI.Keywords = keywords;
            archivoI.ID_Proyecto = id_proyecto;
            archivoI.AI_Externo = AI_externo;

            Det_Archivo_Inv participanteAI = new Det_Archivo_Inv();
            participanteAI.ID_Usuario = id_usuario;
            participanteAI.Rol = rol;

            // texto satisfactorio

            bool exito = DataAccessGeneral.RegistrarArchivoI(archivoI);
            bool exito1 = DataAccessGeneral.RegistrarParticipanteAI(participanteAI);

            string mensaje = string.Empty;

            if (exito && exito1)
            {
                mensaje = "Registro satisfactorio";
            }
            else
            {
                mensaje = "Ha ocurrido un error. Intente nuevamente";
            }

            return Json(mensaje, JsonRequestBehavior.AllowGet);

        }

        public ActionResult EliminarProyecto(int ID)
        {
            bool exito = DataAccessGeneral.EliminarProyecto(ID);
            return RedirectToAction("IndexProyecto");
        }



        public ActionResult EliminarArchivoI(int ID)
        {
            bool exito = DataAccessGeneral.EliminarArchivoI(ID);
            return RedirectToAction("IndexArchivoInvestigacion");
        }

        public ActionResult EditarProyecto(int ID)
        {
            Proyecto proyecto = DataAccessGeneral.listadoProyecto().Where(x => x.ID_Proyecto == ID).FirstOrDefault();
            return View(proyecto);
        }

        [HttpPost]
        public ActionResult EditarProyecto(Proyecto proyecto)
        {
            //para cargar la data
            bool exito = DataAccessGeneral.ActualizarProyecto(proyecto);
            return RedirectToAction("IndexProyecto");

        }

        public ActionResult EditarArchivoI(int ID)
        {
            Archivo_Investigacion archivoI = DataAccessGeneral.listadoArchivoI().Where(x => x.ID_ArchivoI == ID).FirstOrDefault();
            return View(archivoI);
        }

        [HttpPost]
        public ActionResult EditarArchivoI(Archivo_Investigacion archivoI)
        {
            //para cargar la data
            bool exito = DataAccessGeneral.ActualizarArchivoI(archivoI);
            return RedirectToAction("IndexArchivoInvestigacion");

        }

        /// <summary>
        /// ///////////////////////////////////
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult VerProyecto(int ID)
        {
            Proyecto proyecto = DataAccessGeneral.listadoProyecto().Where(x => x.ID_Proyecto == ID).FirstOrDefault();
            return View(proyecto);
        }


        //////////////////////////////////////////////////////////////////////////////////////

        //public JsonResult GrabarParProy(int Id_Proyecto, int Id_usuario, string rol)
        //{
        //    Det_Partic_Proyecto participante = new Det_Partic_Proyecto();

        //    participante.ID_Proyecto = Id_Proyecto;
        //    participante.ID_Usuario = Id_usuario;
        //    participante.Rol = rol;

        //    // texto satisfactorio

        //    bool exito = DataAccesGeneral.RegistrarParticipante(participante);

        //    string mensaje = string.Empty;

        //    if (exito)
        //    {
        //        mensaje = "Registro satisfactorio";
        //    }
        //    else
        //    {
        //        mensaje = "Ha ocurrido un error. Intente nuevamente";
        //    }

        //    return Json(mensaje, JsonRequestBehavior.AllowGet);

        //}
    }
}