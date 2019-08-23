using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2.Modelo
{
    class Rombo : Cuadrilatero
    {

        public Rombo(double diag1, double diag2)
            : base(diag1, diag1, diag2, diag2)
        {

        }
        public override double calculoArea()
        {
            return (lado1 * lado2) / 2;

        }
    }
}
