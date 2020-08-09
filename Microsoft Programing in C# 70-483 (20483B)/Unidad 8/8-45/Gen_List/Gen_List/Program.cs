using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_List {
    class Program {
        static void Main(string[] args) {
            List<Producto> listPro = new List<Producto>();
            listPro.Add(new Producto("pro001", "avena", 6.23));
            listPro.Add(new Producto("pro002", "leche", 1.87));
            listPro.Add(new Producto("pro003", "mermelada", 6.23));
            listPro.Add(new Producto("pro004", "avena", 6.23));

            listPro.Sort();

            foreach (Producto p in listPro) {
                Console.WriteLine(p + ", " + p.Precio.ToString());
            }

            Console.ReadKey();
        }
    }
}
