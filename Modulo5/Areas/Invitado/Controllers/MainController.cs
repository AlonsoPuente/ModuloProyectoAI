using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoreDA;

namespace Modulo5.Areas.Invitado.Controllers
{
    public class MainController : Controller
    {
        // GET: Invitado/Main
        public ActionResult IndexProyectoArchivo()
        {
            return View();
        }

        public ActionResult IndexArchivoInvestigacion()
        {
            return View();
        }

        public ActionResult ListadoProyInv()
        {
            return PartialView(DataAccessGeneral.listadoProyecto());
        }

        public ActionResult ListadoAI()
        {
            return PartialView(DataAccessGeneral.listadoArchivoI());
        }

        public ActionResult VerProy()
        {
            return PartialView(DataAccessGeneral.listadoArchivoI());
        }
    }
}