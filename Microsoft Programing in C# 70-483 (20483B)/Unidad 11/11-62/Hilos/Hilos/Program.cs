using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hilos {
    class Program {
        static void Main(string[] args) {
            Thread hilo1 = new Thread(new ThreadStart(Tarea1));
            Thread hilo2 = new Thread(new ThreadStart(Tarea2));
            hilo1.Start();
            hilo2.Start();
            hilo1.Priority=ThreadPriority.Highest;
            hilo1.Priority=ThreadPriority.Lowest;
            Console.ReadKey();
        }

        static private void Metodo() {
            Console.WriteLine("inicio del proceso 2");
            Console.WriteLine("termino del proceso 2");
        }

        static private void Tarea1() {
            for (int x = 1; x<=10; x++) {
                Thread.Sleep(1000);
                Console.WriteLine("{0}",x);
            }
        }

        static private void Tarea2() {
            for (int x = 11; x<=20; x++) {
                Thread.Sleep(1000);
                Console.WriteLine("{0}", x);
            }
        }
    }
}