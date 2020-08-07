using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo2 {
    public class Persona {
        private string  _nombre;
        private string  _apellido;
        private int     _edad;
        private string  _documento;

        public void SetNombre(string nombre) {
            this._nombre = nombre;
        }

        public string GetNombre() {
            return this._nombre;
        }

        public void SetApellido(string apellido) {
            this._apellido = apellido;
        }

        public string GetApellido() {
            return this._apellido;
        }
        public void SetEdad(int edad) {
            this._edad = edad;
        }

        public int GetEdad() {
            return this._edad;
        }
        public void SetDocumento(string documento) {
            this._documento = documento;
        }

        public string GetDocumento() {
            return this._documento;
        }
    }
}