using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Humano : Mamiferos //nombre de la clase y hereda metodos de la clase mamiferos
    {
        public void Razonar() { //creacion del metodo razonar que es propio de la clase humano
            Console.WriteLine("Yo razono");//se imprime en pantalla que esta razonando
        }
        public void NumPatas()//implementacion del metodo de numero de patas de animales terrestres
        {
            Console.WriteLine("Tengo 2 pies");//se imprime en pantalla en numero de patas
        }

        public void MostrarNombre(string nombre)//creacion del metodo para que se Muestre el nombre del animal en consola
        {
            Console.WriteLine("Soy un humano y me llamo "+nombre);
        }
    }
}
