using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS903_Tema1.Models;

namespace IDGS903_Tema1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult MuestraPulques()
        {
            var pulquesVenta = new PulquesServices();
            var model = pulquesVenta.ObtenerPulque();

            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            TempData["nombres"] = "temporal";
            var pulquesVenta = new PulquesServices();
            var model = pulquesVenta.ObtenerPulque();

            return View(model);
        }

        public ActionResult Index()
        {
            var pulque1 = new Pulques() { Nombre = "pulqueMango", Descripcion="mango"};
            //return Content("programa ASP.Zet");
            return Json(pulque1,JsonRequestBehavior.AllowGet);
        }

        public RedirectResult vista()
        {
            return Redirect("https://google.com.mx");
        }

        public RedirectToRouteResult Vista2()
        {
            return RedirectToAction("MuestraPulques2");
            //dirigue la vista del controlador nombre del controlador que se referencia 
        }

        public ActionResult Vista3()
        {
            ViewBag.Saludo = "Hola mundo";
            ViewBag.fecha = new DateTime(2023, 11, 2);
            ViewData["Nombre"] = "Jonathan";

            string nombre = "";
            if (TempData.ContainsKey("nombre"))
            {
                nombre = TempData["nombres"] as string;
            }
            ViewBag.nombreNuevo = nombre;

            return View();
        }

        public ActionResult index7()
        {
            var pulque1 = new Pulques() { Nombre = "pulqueMango", Descripcion = "mango" ,litros=4,Caducidad = new DateTime(2023,11,5)};
            ViewBag.pulques = pulque1;
            return View();
        }

    }
}
