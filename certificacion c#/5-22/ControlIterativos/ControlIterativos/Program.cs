using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlIterativos {
    class Program {
        static void Main(string[] args) {
            int opcion;
            char continuar = 'n';
            do {
                Console.Clear();
                Console.WriteLine("menu de opciones");
                Console.WriteLine("1. sumar 2 valores");
                Console.WriteLine("2. conteo de valores");
                Console.WriteLine("3. separar cadena");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Escoja una opcion por favor");
                opcion = int.Parse(Console.ReadLine());

                switch(opcion){
                    case 1:
                        double valor1, valor2;

                        Console.WriteLine("ingrese primer valor");
                        valor1 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("ingrese segundo valor");
                        valor2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("la suma de estos 2 valores es " + (valor1 + valor2));
                        break;

                    case 2:
                        int numero;
                        Console.WriteLine("ingrese un numero range (2-40)");
                        numero = int.Parse(Console.ReadLine());
                        
                        for (int s = 1; s <= numero; s++ ) {
                            Console.WriteLine(s.ToString());
                        }
                        break;

                    case 3:
                        string cadena;
                        Console.WriteLine("escriba su nombre");
                        cadena = Console.ReadLine();

                        foreach (char c in cadena) {
                            Console.WriteLine(c.ToString());
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("cerrando sistema");
                        Console.ReadKey();
                        return;
                }

                Console.WriteLine("quiere continuar ejecutrando mas opciones¿?");
                continuar = char.Parse(Console.ReadLine());

            } while (continuar == 'S' || continuar == 's');
            
            Console.Clear();
            Console.WriteLine("cerrando sistema!!!!!!!!!!!!");
            Console.ReadKey();
        }
    }
}