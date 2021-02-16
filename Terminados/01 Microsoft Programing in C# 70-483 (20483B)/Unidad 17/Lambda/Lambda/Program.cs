using System;
using System.Threading;

namespace Lambda {
    class Program {
        static void Main(string[] args) {
            Action D;
            D=MT1;
            
            D += () => Console.WriteLine("Metodo 2");
            
            D+=delegate () {
                Thread.Sleep(5000);
                Console.WriteLine("Metodo 3");
            };

            D+=() => {
                Console.WriteLine("Metodo 4");
                Console.WriteLine("Metodo 5");
            };

            D();
            Console.ReadKey();
        }

        static void MT1() {
            Console.WriteLine("Metodo 1");
        }
    }
}