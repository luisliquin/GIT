using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales {
    class Program {
        static void Main(string[] args) {
            int edad  = 0;
            string siestudias = string.Empty;
            int carrera = 0;
            Console.WriteLine("ingrese una edad");
            edad = Convert.ToInt32(Console.ReadLine());
            
            if (edad >= 18) {
                Console.WriteLine("eres mayor de edad");
                Console.WriteLine("acualmente estudias? s/n");
                siestudias = Console.ReadLine();

                if (siestudias == "s") {
                    Console.WriteLine("que maravilla");
                }
                else {
                    Console.WriteLine("que pena... ¿que carrera te gustaria estudiar?");
                    Console.WriteLine("ing industrial - 1");
                    Console.WriteLine("ing ambiental - 2");
                    Console.WriteLine("ing de minas - 3");
                    Console.WriteLine("ing informatica - 4");
                    carrera = Convert.ToInt32(Console.ReadLine());
                    switch (carrera) {
                        case 1:
                            Console.WriteLine("es bueno desempeñarse en muchas de las industrias del pais");
                            break;
                        case 2:
                            Console.WriteLine("es un campo con mucha investigacion");
                            break;
                        case 3:
                            Console.WriteLine("ing de minas conlleva muchas responsabilidades");
                            break;
                        case 4:
                            Console.WriteLine("has escogido una carrera maravillosa");
                            break;
                    }
                }
            }
            else {
                Console.WriteLine("eres un niño");
            }
            Console.ReadKey();
        }
    }
}
