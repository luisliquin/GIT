using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq {
    class Persona {
        private string _nombre;
        private string _apellido;
        private int _edad;

        public Persona(string nom, string ape, int edad) {
            this._nombre= nom;
            this._apellido=ape;
            this._edad=edad;
        }

        public string Nombre { get { return _nombre;}}
        public string Apellido { get { return _apellido;}}
        public int Edad { get { return _edad; }}
    }
}
