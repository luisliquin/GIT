using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Musica {
    public class Vehiculo : IFuncion {

        public Vehiculo() { }

        private string _Nombre;
        
        public string Nombre {
            get {
                return _Nombre;
            }
            set {
                _Nombre=value;
            }
        }

        public string Encender() {
            return "Prendido";
        }
    }
}