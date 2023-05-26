﻿using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class PulquesServices
    {
        public List<Pulques> ObtenerPulque()
        {
            var pulque1 = new Pulques()
            {
                Nombre = "Pulque1",
                Descripcion = "Frutos Rojos",
                litros = 25,
                Caducidad = new DateTime(2023, 11, 5)
            };
            var pulque2 = new Pulques()
            {
                Nombre = "Pulque2",
                Descripcion = "Mango piña",
                litros = 25,
                Caducidad = new DateTime(2023, 5, 15)
            };


            return new List<Pulques> { pulque1, pulque2 };
        }
    }
}