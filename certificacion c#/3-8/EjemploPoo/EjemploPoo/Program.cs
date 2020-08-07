using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo
{
    class Program {
        static void Main(string[] args) {
            //Gato michi = new Gato();
            //michi.CambiarNombre ("Gato con botas");
            //michi.Maullar();

            Cafetera myCafe = new Cafetera();
            if (myCafe.LlenarCafetera(20))
                Console.WriteLine("se llena la cafetera correctamente y valor es de " + myCafe.CantidadActualCafe().ToString());
            else
                Console.WriteLine("no se pudo llenar la cafetera");
            myCafe.ServirCafe();
            Console.WriteLine("la cantidad actual de cafe es: " + myCafe.CantidadActualCafe().ToString());
            Console.ReadKey();
        }
    }

    class Gato {
        public int edad;
        public string nombre;
        public void CambiarNombre(string nuevoNombre){
            this.nombre = nuevoNombre;
        }

        public void Maullar() {
            Console.WriteLine(nombre + " dice " + "Miau");
        }
    }
  
}