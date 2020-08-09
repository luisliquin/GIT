using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C_Queue {
    class Program {
        static void Main(string[] args) {
            Queue cola = new Queue();
            char continuar = 's';
            int opcion = 0;
            //cola.Enqueue("cadena");
            //cola.Enqueue(18);
            //cola.Enqueue(87.3);

            //object ultimo_elemento = cola.Dequeue();
            //Console.WriteLine("el numero de elementos de la cola es: " + cola.Count);
            //Console.WriteLine("el primero en salir es: " + ultimo_elemento.ToString());

            do {
                Console.Clear();
                Console.WriteLine("-----menu-----");
                Console.WriteLine("1. ingresar elemento");
                Console.WriteLine("2. contar elementos");
                Console.WriteLine("3. buscar elementos");
                Console.WriteLine("4. limpiar cola");

                Console.WriteLine("ingrese opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        cola.Enqueue(Console.ReadLine());
                        Console.WriteLine("se ingreso");
                        break;
                    case 2:
                        Console.WriteLine(cola.Count + " elementos");
                        break;
                    case 3:
                        if (cola.Contains(Console.ReadLine())) {
                            Console.WriteLine("elemento encontrado");
                        }
                        else {
                            Console.WriteLine("elemento no encontrado");
                        }
                        break;
                    case 4:
                        cola.Clear();
                        Console.WriteLine(cola.Count + " elementos");
                        break;
                }
                Console.ReadKey();
            }
            while (continuar == 's' || continuar == 'S');
            Console.ReadKey();
        }
    }
}