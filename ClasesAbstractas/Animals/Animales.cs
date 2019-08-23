using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animales //Se creo la clase tipo abstracta para definirla como la clase principal
    {
        public abstract void getNombre(string nombre);//se creo el metodo abstracto para guardar el nombre del animal


        public void Respirar() {//se creo el metodo respirar para que herede a todos los animales que respiran
            Console.WriteLine("Yo respiro");//se imprime en consola para indicar que esta respirando
        }
    }
}
