using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_List {
    public class Clientes {
        private ArrayList db = new ArrayList();

        public void Agregar(string nombre) {
            db.Add(nombre);
        }

        public void AgregarLista(string[] clientes) {
            db.AddRange(clientes);
        }

        public void Editar(string edit, string new_element) {
            db[db.IndexOf(edit)] = new_element;
        }

        public void Eliminar(string elemento) {
            db.Remove(elemento);
        }

        public void SelectClientes() {
            foreach (object db in db) {
                Console.WriteLine(db.ToString());
            }
        }

        public void Ordenar() {
            db.Sort(new OrdernarDesc());
        }
    }

    class OrdernarDesc : IComparer {
        public int Compare(object x, object y) {
            return (new CaseInsensitiveComparer().Compare(y, x));
        }
    }
}