using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo {
    abstract class Mascota {
        protected string _Nombre;
        protected int _edad;

        public abstract string Saludar();
    }
    class Gato : Mascota {
        public Gato(string nombre) : base() {
            this._Nombre=nombre;
        }
        public override string Saludar() {
            return "hola soy un Gato y mi nombre es: " + this._Nombre;
        }
    }
    
    class Perico : Mascota {
        public Perico(string nombre) : base() {
            this._Nombre=nombre;
        }
        public override string Saludar() {
            return "hola soy un Perico y mi nombre es: " + this._Nombre;
        }
    }
}