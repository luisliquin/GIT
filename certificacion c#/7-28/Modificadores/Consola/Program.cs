using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace Consola {
    class Program {
        static void Main(string[] args) {
            //Persona per = new Persona();
            Empleado emp = new Empleado();
            //Deriv d = new Deriv();
            //d.ImprimirEdad();
            //d.ImprimirNombre();
            //d.ImprimirEdadPadre();

            emp.MiMetodo();
            //Console.WriteLine(ObjetoInterno.edad);
            Console.ReadKey();
        }
    }
}