using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class Puntos
    {
        public float x1 { get; set; }
        public float y1 { get; set; }
        public float x2 { get; set; }
        public float y2 { get; set; }

        public double calcular()
        {

            double res = 0;
            res = Math.Sqrt(Math.Pow((this.x2 - this.x1), 2) + Math.Pow((this.y2 - this.y1), 2));
            return res;
        }
    }
}