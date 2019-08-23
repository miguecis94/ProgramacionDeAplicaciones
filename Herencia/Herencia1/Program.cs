using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseHija Herencia = new ClaseHija();
            Herencia.Saludar();
            Herencia.Despedirse();
            Console.ReadKey();
        }
    }
}
