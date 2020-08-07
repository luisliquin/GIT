using System;

namespace PropiedadesMetodos {
    class Program {
        static void Main(string[] args) {
            Triangulo tria = new Triangulo();
            tria.Alto = 23.45;
            tria.Base = 10.34;

            Console.WriteLine("el area del triangulo es (23.45 * 10.34) es: " + tria.Area().ToString());
            tria.LeerMedidas();
            Console.WriteLine("el cuadrado de 8 es: " + tria.NumeroalCuadrado(8).ToString());
            Console.WriteLine("el cuadrado de 8.67 es: " + tria.NumeroalCuadrado(8.67).ToString());
            Console.ReadKey();
        }
    }
}
