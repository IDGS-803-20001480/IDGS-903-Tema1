using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class Triangulo
    {
        public Double x1 { get; set; }
        public Double y1 { get; set; }
        public Double x2 { get; set; }
        public Double y2 { get; set; }
        public Double x3 { get; set; }
        public Double y3 { get; set; }

        public String res { get; set; }
        public Double area { get; set; }

        public Double lado1 { get; set; }
        public Double lado2 { get; set; }
        public Double lado3 { get; set; }

        public void calcularlados()
        {
            
            this.lado1 = Math.Sqrt(Math.Pow((this.x2 - this.x1), 2) + Math.Pow((this.y2 - this.y1), 2));
            this.lado2 = Math.Sqrt(Math.Pow((this.x3 - this.x1), 2) + Math.Pow((this.y3 - this.y1), 2));
            this.lado3 = Math.Sqrt(Math.Pow((this.x3 - this.x2), 2) + Math.Pow((this.y3 - this.y2), 2));
        }

        public bool evaluar()
        {
            
            if (this.lado1 < this.lado2 + this.lado3 || this.lado2 < this.lado1 + this.lado3 || this.lado3 < this.lado2 + this.lado1) {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void calcularArea()
        {
            calcularlados();
            if (evaluar()) { 
            double semiperimetro = (this.lado1+this.lado2+this.lado3)/2;
            if (this.lado1==this.lado2 && this.lado1 == this.lado3) {
                this.res = "El triangulo es Equilatero";
            }
            else if (this.lado1 == this.lado2 || this.lado1 == lado3 || this.lado3 == this.lado2)
            {
                this.res = "El triangulo es Isoseles";
            }
            else
            {
                this.res = "El triangulo es Escaleno";
            }

            this.area = Math.Sqrt(semiperimetro * (semiperimetro - this.lado1) * (semiperimetro - this.lado2) * (semiperimetro - this.lado3));
            }
            else
            {
                this.res = "No es un triangulo";
                this.area = 0;
            }
            //return new Triangulo() { lado1 = this.lado1,lado2 = this.lado2 ,lado3=this.lado3,res=this.res,area= this.area};
            }
        

    }
}