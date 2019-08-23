using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals 
{
    class Lagartija : Animales//nombre dde la clase y herencia de la clase animales
    {
       
        public void MostrarNombre(string nombre)//creacion del metodo para que se Muestre el nombre del animal en consola
        {
            Console.WriteLine("Soy una lagartija y me llamo " + nombre);
        }
        public void NumPatas()//implementacion del metodo de numero de patas de animales terrestres
        {
            Console.WriteLine("Tengo 4 patas");//se imprime en pantalla en numero de patas
        }
        public override void getNombre(string nombre)
        {

        }

    }
}
