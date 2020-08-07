using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
    class Program {
        static void Main(string[] args) {
            string [] miArray = new string[4];
            //int [][] array_bi = new int[2][];
            //array_bi[0] = new int[0];

            int[,] arrayb = new int[3,2];
            arrayb[0, 0] = 1;
            arrayb[0, 1] = 2;

            arrayb[1, 0] = 3;
            arrayb[1, 1] = 4;

            arrayb[2, 0] = 5;
            arrayb[2, 1] = 6;

            for (int f = 0; f <= arrayb.GetUpperBound(0); f++) {
                for (int c = 0; c <= arrayb.GetUpperBound(1); c++) {
                    Console.WriteLine(arrayb[f,c].ToString());
                }
                Console.WriteLine();
            }

            miArray[0] = "2";
            miArray[1] = "hola";
            miArray[2] = "dos";
            miArray[3] = "5";

            //foreach (string elemento in miArray) {
            //    Console.WriteLine(elemento);
            //}
            Console.ReadKey();
        }
    }
}
