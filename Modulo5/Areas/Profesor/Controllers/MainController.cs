using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoreDA;

namespace Modulo5.Areas.Profesor.Controllers
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
            return PartialView(DataAccessGeneral.listadoProyecto());
        }


        public ActionResult ListadoAI()
        {
            return PartialView(DataAccessGeneral.listadoArchivoI());
        }

       // cuando son llamdas asincronas
        

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
    }

}