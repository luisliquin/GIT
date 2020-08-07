using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables {
    public class Persona {
        public static void MiMetodo(out string nombre, out int edad) {
            nombre = "Juan";
            edad = 50;

            Console.WriteLine("hola mi nombre es " + nombre +
                       " y tengo " + edad + "años.");
        }

        public void OtroMetodo(string nombre, int edad) {
            Console.WriteLine(  "hola mi nombre es " + nombre + 
                                " y tengo " + edad + "años.") ;            
        }
    }
}