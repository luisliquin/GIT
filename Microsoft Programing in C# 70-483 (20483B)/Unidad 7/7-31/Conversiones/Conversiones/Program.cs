using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones {
    class Program {
        static void Main(string[] args) {
            Persona per = new Persona();
            
            Console.WriteLine("ingrese un id para la persona");
            per.Id = Console.ReadLine();

            Console.WriteLine(per.ToString());
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
