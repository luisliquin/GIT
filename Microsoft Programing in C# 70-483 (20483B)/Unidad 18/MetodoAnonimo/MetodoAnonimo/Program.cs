using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAnonimo {
    class Program {

        delegate void ShowMessageDelegate();
        
        static void Main(string[] args) {
            Action E = ShowMessage;
            E();

            Action D = delegate(){
                Console.WriteLine("mensaje metodo anonimo");
            };
            D();

            ShowMessageDelegate C = delegate(){
                Console.WriteLine("delegate metodo anonimo");
            };
            C();

            Console.ReadKey();
        }

        static void ShowMessage() {
            Console.WriteLine("mensaje");
        }
    }
}