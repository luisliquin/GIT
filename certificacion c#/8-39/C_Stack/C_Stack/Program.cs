using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C_Stack {
    class Program {
        static void Main(string[] args) {
            /*Stack pila = new Stack();
            pila.Push(34);
            pila.Push("string");
            pila.Push(true);
            pila.Push(34.6);
            Console.WriteLine("la cantidad de la pila es " + pila.Count);
            double el = double.Parse(pila.Pop().ToString());
            bool valor = bool.Parse(pila.Peek().ToString());            
            Console.WriteLine("el elemento que se saca sera: " + el.ToString());
            Console.WriteLine("el ultimo elemento es ahora " + valor);
            Console.WriteLine("ahora tenemos " + pila.Count + " elementos.");            */

            Libros libreria = new Libros();
            Console.WriteLine("ingrese elementos: ");
            libreria.IngresarLibro(3);
            //string valor = libreria.DevolverUltimoElemento().ToString();
            //Console.WriteLine("el ultimo elemento es: " + valor);
            Console.WriteLine("el numero de elementos de la libreria es de: " + libreria.ContarLibros().ToString());

            //Console.WriteLine("ingrese el libro que quiere consultar: ");
            //if (libreria.ConsultaLibro(Console.ReadLine())) {
            //    Console.WriteLine("libro encontrado");
            //}
            //else {
            //    Console.WriteLine("libro inexistente");
            //}

            Console.WriteLine("desea retirar algun libro??");
            if (Console.ReadLine() == "s") {
                libreria.RetirarLibro();
            }

            Console.WriteLine("el numero de elementos de la libreria es de: " + libreria.ContarLibros().ToString());
            libreria.LimpiarLibros();

            Console.WriteLine("el numero de elementos de la libreria es de: " + libreria.ContarLibros().ToString());
            Console.ReadKey();
        }
    }
}