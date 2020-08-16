using Operacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Delegado {
    class Program {
        static void Main(string[] args) {
            string a,b;
            int result = 0;

            Division op = new Division();
            op.MessageHandler=ShowMessage;

            Console.Write("ingrese el operador 1: ");
            a=Console.ReadLine();
            
            Console.Write("ingrese el operador 2: ");
            b=Console.ReadLine();

            result=op.Divide(Convert.ToInt32(a), Convert.ToInt32(b));
            Console.WriteLine($"resultado: {result}");
            
            Console.ReadKey();
        }

        public static void ShowMessage(int a, int b) {
            Console.WriteLine($"division entre cero, {a} - {b}");
        }
    }
}
