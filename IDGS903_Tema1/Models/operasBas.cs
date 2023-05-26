using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class operasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }
        public String operacion { get; set; }

        public void Sumar()
        {
            this.Res = this.Num1+this.Num2;
        }

        public void Resta()
        {
            this.Res = this.Num1 - this.Num2;
        }

        public void Multi()
        {
            this.Res = this.Num1 * this.Num2;
        }

        public void Divisison()
        {
            this.Res = this.Num1 / this.Num2;
        }

        public void Seleccionoperacion()
        {
            switch (this.operacion)
            {
                case "suma":
                    Sumar();
                    break;
                case "resta":
                    Resta();
                    break;
                case "multi":
                    Multi();
                    break;
                case "division":
                    Divisison();
                    break;
            }
        }
    }
}