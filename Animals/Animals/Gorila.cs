using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Gorila : Mamiferos //nombre de la clase y hereda metodos de la clase mamiferos
    {
        public void Trepar() //creacion del metodo trepar que es propio de la clase gorila
        {
            Console.WriteLine("Yo Trepo");//se imprime en pantalla que esta trepando
        }
        public void NumPatas()//implementacion del metodo de numero de patas de animales terrestres
        {
            Console.WriteLine("Tengo 2 patas");//se imprime en pantalla en numero de patas
        }

        public void MostrarNombre(string nombre)//creacion del metodo para que se Muestre el nombre del animal en consola
        {
            Console.WriteLine("Soy un gorila y me llamo " + nombre);
        }
    }
}
