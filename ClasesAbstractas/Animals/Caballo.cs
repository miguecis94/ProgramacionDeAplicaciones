using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Caballo : Mamiferos //nombre de la clase y hereda metodos de la clase mamiferos
    {
        public void Galopar() //creacion del metodo galopar que es propio de la clase caballo
        {
            Console.WriteLine("Yo Galopo");//se imprime en pantalla que esta galopando
        }
        public void NumPatas()//implementacion del metodo de numero de patas de animales terrestres
        {
            Console.WriteLine("Tengo 4 patas");//se imprime en pantalla en numero de patas
        }

        public void MostrarNombre(string nombre)//creacion del metodo para que se Muestre el nombre del animal en consola
        {
            Console.WriteLine("Soy un caballo y me llamo " + nombre);
        }
    }
}
