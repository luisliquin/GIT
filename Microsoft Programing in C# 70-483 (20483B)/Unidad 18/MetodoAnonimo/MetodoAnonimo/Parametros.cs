using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAnonimo {
    class Parametros {
        static void Main(string[] args) {
            Func<int, int , int > F = delegate(int A, int B){
                return A + B;
            };
            
            Console.WriteLine(F(4, 4));

            Action<string> S;

            S=delegate (string message) {
                Console.WriteLine(message);
            };

            S("mensaje");
            Console.ReadKey();
        }

        static void ShowMessage(string message) {
            Console.WriteLine(message);
        }

        static int Add(int a, int b) {
            return a+b;
        }
    }
}