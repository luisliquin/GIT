using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Colecciones {
    class Program {
        static void Main(string[] args) {
            ArrayList al = new ArrayList();
            Queue cola = new Queue();
            Stack pila = new Stack();

            Hashtable table = new Hashtable();
            SortedList list = new SortedList();

            Dictionary<int, string> dlc = new Dictionary<int, string>();

            Figura<double> fig = new Figura<double>();

            al.Add(23);
            al.Add("hola");
            al.Add(true);
            fig.tamaño = 45.6;

            for (int d = 0; d < al.Count; d++) {
                Console.WriteLine(al[d].ToString());
            }

            Console.Read();
        }
    }
}