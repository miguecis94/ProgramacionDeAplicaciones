using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Mamiferos : Animales//nombre de la clase y la herencia de de la clase animal
    {
        public void Pensar() {//se creo el metodo pensar que es propio de los mamiferos
            Console.WriteLine("Yo pienso");//se imprime en consola para indicar que el animal esta pensando
        }
        public void CuidarCrias() {//se creo el metodo cuidar crias que igualmente es propio de la clase mamiferos
            Console.WriteLine("Yo cuido a mis crias");//se imprime en pantalla como un indicador de que el animal cuida a sus crias
        }

        public override void getNombre(string nombre)
        {
            
        }
    }
}
