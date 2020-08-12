using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia {
    class Program {
        static void Main(string[] args) {
            Carro car = new Carro("marca","modelo1", 15,80,1,"rojo");

            car.AumentarKilometraje(10);
            car.CambiarColor("negro");
            Console.WriteLine("el kilometraje es de: " + car.Kilometraje.ToString());

            Vehiculo ve = new Vehiculo("vehiculo1", "modelo",12.3,120);
            ve.CambiarColor("verde");
            Console.WriteLine(ve.ToString());

            Console.ReadKey();
        }
    }
}
