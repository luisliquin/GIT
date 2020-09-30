using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C_Stack {
    public class Libros {
        private Stack pilaDB = new Stack();

        public void IngresarLibro(int numero) {
            for (int c = 1; c <= numero; c++) {
                object elemento;
                elemento = Console.ReadLine();
                pilaDB.Push(elemento);
            }
        }

        public object RetirarLibro() {
            object elemento;
            elemento = pilaDB.Pop();
            return elemento;
        }
        public bool ConsultaLibro( object busqueda) {
            bool encontrado = false;
            encontrado = pilaDB.Contains(busqueda);
            return encontrado;
        }

        public object DevolverUltimoElemento() {
            object elemento;
            elemento = pilaDB.Peek();
            return elemento;
        }

        public void LimpiarLibros() {
            pilaDB.Clear();
        }

        public int ContarLibros() {
            return pilaDB.Count;
        }
    }
}
