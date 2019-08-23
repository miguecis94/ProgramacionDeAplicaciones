using Figuras2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2.Control
{
    class Controlador
    {
        static Controlador control;
        Cuadrilatero cua;

        private Controlador()
        {

        }

        public bool CrearRectangulo(double a, double b)
        {
            cua = new Rectangulo(a, b); // instanciamos la clase Rectangulo con 2 parámetros
            return true;
        }

        public bool CrearCuadra(double a)
        {
            cua = new Cuadro(a); // instanciamos la clase Cuadro con 1 parámetros
            return true;
        }

        public bool crearRombo(double a, double b)
        {
            cua = new Rombo(a, b); // instanciamos la clase Rombo con 2 parámetros
            return true;
        }


        public double ConsultarPerimetro()
        {

            return cua.calculoPerimetro();
        }

        public double ConsultarArea()
        {
            return cua.calculoArea();

        }

        public static Controlador obtenerControl()
        {


            if (control == null) // aqui verificamos si existe un controlador iniciado
                control = new Controlador();// si no existe, crearemos uno nuevo
            return control;
        }
    }
}
