using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Ballena : Mamiferos//nombre de la clase y hereda metodos de la clase mamiferos
    {

        public void Nadar()//creacion del metodo nadar que es propio de ballena
        {
            Console.WriteLine("Yo Nado");//se imprime en pantalla que esta nadando
        }
        public void MostrarNombre(string nombre)//creacion del metodo para que se Muestre el nombre del animal en consola
        {
            Console.WriteLine("Soy una ballena y me llamo " + nombre);
        }
    }
}
