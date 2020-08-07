using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables {
    class Program {
        static void Main(string[] args) {
            string nombre; // = "maria";
            int edad;      // = 25;

            string var1 = "string ";
            string[] array = {"uno","dos", "tres" };

            Persona per = new Persona();
            per.OtroMetodo("fabian", 33);
            
            Persona.MiMetodo(out nombre, out edad);
            Console.WriteLine(nombre + " " + edad);

            Console.WriteLine(array.Length.ToString());
            Console.ReadKey();
        }
    }
}
