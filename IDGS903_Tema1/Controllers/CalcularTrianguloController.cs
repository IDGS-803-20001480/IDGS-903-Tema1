using IDGS903_Tema1.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class CalcularTrianguloController : Controller
    {
        // GET: CalcularTriangulo
        public ActionResult Calcular()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calcular(Triangulo tri) 
        {
            tri.calcularArea();
            ViewBag.Respuesta = "mostrar";
            return View(tri);
        }
    }
}