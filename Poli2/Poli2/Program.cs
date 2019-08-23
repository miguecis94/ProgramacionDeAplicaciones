using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poli2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo MiRectangulo = new Rectangulo();
            Triangulo MiTriangulo = new Triangulo();
            MiRectangulo.Area(5,6);
            MiTriangulo.Area(5,6);
            Console.ReadKey();
        }
    }
}
