using IDGS903_Tema1.Models;
using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult RegistroPalabra(String tabla)
        {
            if (tabla == "mostrar")
            {
                var op = new TraductorService();
                ViewBag.tablaTraductor = op.LeerTraductor();
            }
            return View();
        }

        [HttpPost]
        public ActionResult RegistroPalabra(Traductor tra)
        {
            var op = new TraductorService();
            /*if (btnMostrar == "1")
            {
                ViewBag.tablaTraductor = op.LeerTraductor();
            }*/
            op.GuardarPalabra(tra);
            return View();
        }

        public ActionResult LeerArchivo()
        {

            var tra = new TraductorService();
            ViewBag.tablaTraductor = tra.LeerTraductor();
            return View();
        }

        public ActionResult BuscarPalabra()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BuscarPalabras(string buscador, string opc)
        {
            //Console.WriteLine(buscador.ToLower()," ",opc);
            var tra = new TraductorService();
            ViewBag.respuesta = tra.LeerPalabra(buscador.ToLower(), opc);
            return View();
        }
    }
}