using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo {
    class Calculadora {
        private double _numero1;
        private double _numero2;

        public Calculadora(double num1, double num2) {
            this._numero1=num1;
            this._numero2=num2;
        }

        public Calculadora() { }

        public int Sumar(int valor1, int valor2, int valor3) {
            return (valor1 + valor2 + valor3);
        }

        public double Sumar(double valor1, double valor2) {
            return (valor1 + valor2);        
        }

        public double Sumar(double numero) {
            double rpta = _numero1 + _numero2;
            return rpta + numero;
        }
    }
}
