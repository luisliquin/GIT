using System;
using System.Collections.Generic;
using System.Text;

namespace PropiedadesMetodos {
    public class Triangulo {
        double _base;
        double _alto;

        public double Base {
            get { return _base;}
            set { _base = value;}
        }
        public double Alto {
            get { return _alto; }
            set { _alto = value; }
        }

        public double Area() {
            double _area;
            _area = (_base * _alto) / 2;
            return _area;
        }

        public void LeerMedidas() {
            Console.WriteLine("la base es: " + _base);
            Console.WriteLine("la altura es: " + _alto);
        }

        public double NumeroalCuadrado(double numero) {
            double respuesta;
            respuesta = numero * numero;
            return respuesta;
        }
    }
}