using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria {
    public class ObjetoInterno {
        public readonly string apellidos = "alvarez";
        public static string nombre = "hola";
        public static int edad = 100;

        public ObjetoInterno() {
            apellidos = "";
        }
    }

    
    public class Deriv : ObjetoInterno {
        new public int edad = 15;

        public void ImprimirNombre() {
            Console.WriteLine(nombre);
        }
        public void ImprimirEdad() {
            Console.WriteLine(edad);
        }
        public void ImprimirEdadPadre() {
            Console.WriteLine(ObjetoInterno.edad);
        }    
    }
}
