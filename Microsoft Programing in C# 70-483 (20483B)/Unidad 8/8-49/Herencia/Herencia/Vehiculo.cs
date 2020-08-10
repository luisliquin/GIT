using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia {
    //clase padre
    public class Vehiculo {
        protected string _marca;
        protected string _modelo;
        protected double _kilometraje;
        protected int _velocidad;

        public Vehiculo() {
        }

        public Vehiculo(string marca, string modelo, double kilo, int velo) {
            this._marca = marca;
            this._modelo = modelo;
            this._kilometraje = kilo;
            this._velocidad = velo;
        }

        public override string ToString() {
            //return base.ToString();
            return "Vehiculo => Marca: " + _marca + " Modelo: " + _modelo;
        }

        public void AumentarKilometraje(int k) {
            this._kilometraje = _kilometraje + k;
        }

        public virtual void CambiarColor(string color) {
            Console.WriteLine("no se ha asignado ningun color");
        }

    }

    class Carro : Vehiculo {
        private int codLicencia;
        private string color;
        
        public Carro() { }
        public Carro(string marca, string modelo, double kilo, int velo, int codLic, string color ) : 
            base(marca, modelo, kilo, velo) {
            this.codLicencia = codLic;
            this.color = color;
        }

        public double Kilometraje {
            get { return this._kilometraje; }
        }

        public override void CambiarColor(string color) {
            this.color = color;
            Console.WriteLine("el color es: " + color);
        }
    }
}
