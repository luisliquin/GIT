using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo {
    class Lista<T> {
        private T[] arreglo;
        public Lista(int largo) {
            arreglo=new T [largo];
        }

        public T ObtenerElemento(int indice) {
            return arreglo[indice];
        }

        public void AgregarElemento(T elemento, int posicion) {
            arreglo[posicion]=elemento;
        }
    }
}
