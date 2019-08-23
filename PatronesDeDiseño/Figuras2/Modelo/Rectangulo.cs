using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2.Modelo
{
    class Rectangulo : Cuadrilatero 
    {
        public Rectangulo(double ancho, double altura)
           : base(ancho, ancho, altura, altura)
        {

        }

        public override double calculoArea()
        {

            return lado1 * lado2;
        }
    }
}
