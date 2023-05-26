using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class TraductorService
    {
        public void GuardarPalabra(Traductor tra)
        {

            var palabraEsp = tra.palabraEsp.ToLower();
            var palabraIng = tra.palabraIng.ToLower();
            var datos = palabraIng + ',' + palabraEsp + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datosTraductor.txt");
            //dobre escribe todo el archivo
            //File.WriteAllText(archivo, datos);
            File.AppendAllText(archivo, datos);
        }

        public Array LeerTraductor()
        {
            Array traData = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datosTraductor.txt");
            if (File.Exists(archivo))
            {
                traData = File.ReadAllLines(archivo);
            }
            return traData;
        }

        public String LeerPalabra(string textbusq, string opc)
        {
            string palabra = "No se encontro la palabra";
            Array traData = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datosTraductor.txt");
            if (File.Exists(archivo))
            {
                traData = File.ReadAllLines(archivo);
                Array comparacion = null;
                foreach (String item in traData)
                {
                    comparacion = item.Split(',');
                    if (opc == "Esp")
                    {
                        if (comparacion.GetValue(0).ToString() == textbusq)
                        {
                            palabra = comparacion.GetValue(1).ToString();
                        }
                    }
                    else if (opc == "Ing")
                    {
                        if (comparacion.GetValue(1).ToString() == textbusq)
                        {
                            palabra = comparacion.GetValue(0).ToString();
                        }

                    }

                }
            }
            return palabra;
        }
    }
}