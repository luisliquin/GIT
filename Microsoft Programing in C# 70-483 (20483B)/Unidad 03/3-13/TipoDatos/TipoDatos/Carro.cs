using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDatos {
    public class Carro {
        string  marca = "BMW";
        double  largo = 4.9;
        double  ancho = 1.8;
        int     garantia = 5;
        char    estado = 'A';
        bool    habilitado = true;

        string[] varArray = {"hola", "soy", "un", "array"};
        delegate void mydelegado(string _nom);

        enum colores : short {
            rojo    = 1,
            negro   = 0,
            azul    = 0
        }

        struct propiedades {
            public string  modelo;
            
            public propiedades(string _mod) {
                modelo = _mod;
            }
        }

        static void Main(string[] args) {
            Carro car = new Carro();
            propiedades pro = new propiedades("ndandwajk");
            int[] numeros = new int[] {1,2,3,4,5};

            mydelegado del = new mydelegado(Run);

            Console.WriteLine(car.marca + " " + car.garantia.ToString());
            Console.WriteLine(colores.rojo + " " + car.habilitado.ToString() + " " + pro.modelo);
            Console.WriteLine(car.varArray[1].ToString());

            del("delegado");
            Console.ReadKey();
        }

        static public void Run(string nombre) {
            Console.WriteLine("hola " + nombre);
            //throw new NotImplementedException();
        }
    }
}