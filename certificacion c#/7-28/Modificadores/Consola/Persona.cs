using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola {
    public abstract class Persona {
        protected string nombre;
        private const int documento = 546843;

        public abstract string Nombre {
            get;
            set;
        }

        public virtual void MiMetodo() {
            Console.WriteLine("metodo principal");
        }

    }

    public class Empleado : Persona {
        protected int edad;
        public override string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public override void MiMetodo() {
            //base.MiMetodo();
            Console.WriteLine("metodo sobreescrito");
        }
    }
}
