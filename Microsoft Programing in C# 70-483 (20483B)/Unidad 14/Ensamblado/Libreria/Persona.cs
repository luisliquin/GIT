using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria {
    public class Persona {
        public string Nombre;
        public string Edad;

        public Persona(string _nombre) {
            this.Nombre=_nombre;
        }

        public void Saludar() {
            MessageBox.Show(Nombre);
        }

        public void Saludo(string nombre) {
            MessageBox.Show("Hola "+ nombre);
        }
    }

    public class Humano {
        public char Genero;
        public bool Estado;

        public string Nombre() {
            return "Hola";
        }
    }

    public enum Nombres {
        Juan, Pedro, Andres    
    }
}
