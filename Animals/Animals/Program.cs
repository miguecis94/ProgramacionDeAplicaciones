using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)//metodo principal
        {
            Humano miHumano = new Humano();//instancia del objeto de tipo humano
            miHumano.getNombre("Anahis");//Obtiene el nombre del animal
            miHumano.MostrarNombre("Anahis");//Manda llamar el método MostrarNombre 
            miHumano.Respirar();//Manda llamar el método Respirar
            miHumano.Pensar();//Manda llamar el método Pensar
            miHumano.CuidarCrias();//Manda llamar el método CuidarCrias
            miHumano.Razonar();//Manda llamar el método Razonar
            miHumano.NumPatas();//Manda llamar el método NumPatas
            Ballena miBallena = new Ballena(); //instancia del objeto de tipo ballena
            miBallena.getNombre("Willy");//Obtiene el nombre del animal
            miBallena.MostrarNombre("Willy");//Manda llamar el método MostrarNombre para miBallena
            miBallena.Respirar();//Manda llamar el método Respirar para Ballena
            miBallena.Pensar();//Manda llamar el método Pensar para Ballena
            miBallena.CuidarCrias();//Manda llamar el método CuidarCrias para Ballena
            miBallena.Nadar();//Manda llamar el método nadar para Ballena
            Caballo miCaballo = new Caballo();//instancia del objeto de tipo caballo
            miCaballo.getNombre("Spirit");//Obtiene el nombre del animal
            miCaballo.MostrarNombre("Spirit");//Manda llamar el método MostrarNombre para miCaballo
            miCaballo.Respirar();//Manda llamar el método Respirar para miCaballo
            miCaballo.Pensar();//Manda llamar el método Pensar para miCaballo
            miCaballo.CuidarCrias();//Manda llamar el método CuidarCrias para miCaballo
            miCaballo.Galopar();//Manda llamar el método Galopar para miCaballo
            miCaballo.NumPatas();//Manda llamar el método NumPatas para miCaballo
            Gorila miGorila = new Gorila();//instancia del objeto de tipo gorila
            miGorila.getNombre("Gorge");//Obtiene el nombre del animal
            miGorila.MostrarNombre("Gorge");//Muestra el nombre 
            miGorila.Respirar();//Manda llamar el método Respirar para miGorila
            miGorila.Pensar();//Manda llamar el método Pensar para miGorila
            miGorila.CuidarCrias();//Manda llamar el método CuidarCrias para miGorila
            miGorila.Trepar();//Manda llamar el método Trepar para miGorila
            miGorila.NumPatas();//Manda llamar el método NumPatas para miGorila
            Lagartija miLagartija = new Lagartija();//instancia del objeto de tipo lagartija
            miLagartija.getNombre("Rango");//Obtiene el nombre
            miLagartija.MostrarNombre("Rango");//Muestra el nombre con el metodo MostrarNombre
            miLagartija.Respirar();//Manda llamar el método Respirar para miLagartija
            miLagartija.NumPatas();//Manda llamar el método NumPatas para miLagartija
            Console.ReadKey();//Para mantener la pantalla y no se cierre la pantalla
        }
    }
}
