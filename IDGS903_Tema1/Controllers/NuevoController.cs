using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Ventana()
        {
            return View();
        }

        public ActionResult Calculos(String n1,String n2,String operacion)
        {
            double res;
            switch (operacion)
            {
                case "suma":
                    res = Convert.ToDouble(n1) + Convert.ToDouble(n2);
                break;
                case "resta":
                    res = Convert.ToDouble(n1) - Convert.ToDouble(n2);
                break;
                case "multi":
                    res = Convert.ToDouble(n1) * Convert.ToDouble(n2);
                break;
                case "division":
                    res = Convert.ToDouble(n1) / Convert.ToDouble(n2);
                break;
                default:
                    ViewBag.Res = Convert.ToString(0);
                    return View();
            }

            //res= Convert.ToInt16(n1) + Convert.ToInt16(n2);
            ViewBag.Res=Convert.ToString(res);
            return View();
        }

        public ActionResult Ventana3(operasBas op)
        {
            op.Seleccionoperacion();
            var model = new operasBas();
            model.Res = op.Res;

            return View(model);

        }
    }
}