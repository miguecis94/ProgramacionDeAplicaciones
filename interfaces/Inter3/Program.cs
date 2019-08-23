using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ave Canario = new Ave("Canario");
            Ave Cuervo = new Ave("Cuervo");
            Program main = new Program();
            main.imprimir(Canario);
            main.imprimir(Cuervo);
            Console.ReadKey();
        }
        public void imprimir(Ave ave)
        {
            Console.WriteLine("Soy un {0} tengo {1} Pata(s), {2} Ala(s) y {3} Cola(s)", ave.Nombre, ave.Patas, ave.Alas, ave.Cola);
            //llamar a nuestros metodos de la interfaz
            Console.WriteLine("Puedo");
            ave.Volar();
            Console.WriteLine("Y tambien puedo");
            ave.Comer();
        }
    }
}
