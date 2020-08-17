using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asincrono {
    public class EdadException {
        public int Edad { get; private set; }
        public EdadException(int _edad) : base("el registro de edad " +_edad + " esta fuera de rango"){
            Edad = _edad;
        }
    }
}