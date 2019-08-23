using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2.Modelo
{
    public abstract class Cuadrilatero
    {
        protected double lado1, lado2, lado3, lado4;


        public Cuadrilatero(double lado1, double lado2, double lado3, double lado4)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            this.lado4 = lado4;
        }

        public virtual double calculoPerimetro()
        {
            return lado1 + lado2 + lado3 + lado4;
        }

        public abstract double calculoArea();
    }
}
