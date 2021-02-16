using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Dictionary {
    class Program {
        static void Main(string[] args) {
            //Dictionary<string, string> midic = new Dictionary<string, string>();

            IDictionary<string, string> midic = new Dictionary<string, string>();
            midic.Add("clave1", "valor1");
            midic.Add("clave2", "valor2");
            midic.Add("clave3", "valor3");

            midic.Add(new KeyValuePair<string, string>("1","uno"));

            foreach (KeyValuePair<string, string> elemento in midic) {
                Console.WriteLine("keys: {0} valores {1}", elemento.Key.ToString(), elemento.Value.ToString());
            }

            string val;

            if (midic.TryGetValue("clave", out val)) {
                Console.WriteLine("el valor se ha encontrado y es: " + val);
            }
            else {
                Console.WriteLine("error");
            }
            
            Console.ReadKey();
        }
    }
}