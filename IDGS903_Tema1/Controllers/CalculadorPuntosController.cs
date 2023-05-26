using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class CalculadorPuntosController : Controller
    {
        // GET: CalculadorPuntos
        public ActionResult Index(Puntos pont)
        {
            
            return View(pont);
        }

        public ActionResult distancia(Puntos pont) {
            ViewBag.Puntos = pont.calcular();
            return View();
        }
    }
}