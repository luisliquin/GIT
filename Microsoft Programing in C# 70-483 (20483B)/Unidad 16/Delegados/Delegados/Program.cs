using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados {
    class Program {
 
        static void Main(string[] args) {
            //Action A = ShowMessage;
            //A();
            Func<int, int, double,double> F = Sumar;
            Console.WriteLine(F(1, 5,2.5));

            Console.ReadKey();
        }

        //static void ShowMessage() {
        //    Console.WriteLine("mensaje");
        //    Console.ReadKey();
        //}

        static double Sumar(int a, int b, double c) {
            return a + b + c;
        }

    }
}
