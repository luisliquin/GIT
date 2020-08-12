using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_SortedList {
    class Program {
        static void Main(string[] args) {
            SortedList<int, string> slist = new SortedList<int, string>();

            slist.Add(4, "cuatro");
            slist.Add(1, "uno");
            slist.Add(3, "tres");
            slist.Add(2, "dos");
                        
            for (int i = 0; i < slist.Count; i++) {
                Console.WriteLine("keys: {0}, valores {1}", slist.Keys[i].ToString(), slist.Values[i].ToString());
            }

            string valor;

            if (slist.TryGetValue(3, out valor)) {
                Console.WriteLine("el valor del indice es: " + valor);
            }
            else {
                Console.WriteLine("la clave no fue encontrada");
            }

            bool llave = slist.ContainsKey(9);
            bool val = slist.ContainsValue("cuatro");

            Console.WriteLine("la llave nro 2 es " + llave.ToString());
            Console.WriteLine("el valor de cuatro es " + val.ToString());

            Console.ReadKey();
        }
    }
}