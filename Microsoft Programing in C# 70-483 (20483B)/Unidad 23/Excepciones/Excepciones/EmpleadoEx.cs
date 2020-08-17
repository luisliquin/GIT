using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones {
    public class EmpleadoEx {
        private string _srtNombre;
        private int _intEdad;

        public string Nombre {
            get { return _srtNombre; }
            set { _srtNombre=value;
                if (_srtNombre=="") {
                    throw new Exception("No debe dejar en blanco el nombre");
                }            
            }
        }

        public int Edad {
            get { return _intEdad; }
            set {
                _intEdad=value;
                if (_intEdad < 0 || _intEdad > 70) {
                    throw new Exception("Edad fuera de rango");
                }
            }
        }
    }
}
