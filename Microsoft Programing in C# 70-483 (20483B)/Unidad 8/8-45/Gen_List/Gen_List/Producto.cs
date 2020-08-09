using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_List {
    public class Producto : IComparable {
        private string codigo;
        private string nombre;
        private double precio;

        public Producto(string cod, string nom, double pre) {
            this.codigo = cod;
            this.nombre = nom;
            this.precio = pre;
        }

        public override string ToString() {
            return codigo + " -> " + nombre.ToUpper();
        }

        public int CompareTo(object obj) {
            Producto otroProd = (Producto)obj;
            if (this.nombre != otroProd.Nombre) {
                return this.nombre.CompareTo(otroProd.Nombre);
            }
            else {
                return this.precio.CompareTo(otroProd.Precio);
            }
        }

        public string Codigo {
            get { return codigo;}
        }

        public string Nombre {
            get { return nombre;}
        }

        public double Precio {
            get { return precio;}
        }
    }
}
