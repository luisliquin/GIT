using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda {
    class Expresion {
        static void Main(string[] args) {
            //Func<string, int, int, decimal> H;
            //H=(msg, a, b) => Add(msg, a, b);
            //Console.WriteLine(H("mensaje", 5, 5));

            Func<string, int, int, decimal> V;
            V=(msg, a, b) => {
                Console.WriteLine($"{msg}: {a} + {b}");
                return a+b;
            };

            Console.WriteLine(  V("mensaje 2", 10, 10));

            Console.ReadKey();
        }

        static decimal Add(string msg, int a, int b) {
            Console.WriteLine($"{msg}: {a} + {b}");
            return a+b;
        }
    }
}
