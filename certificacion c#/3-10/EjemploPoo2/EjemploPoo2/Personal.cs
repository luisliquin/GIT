using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo2 {
    public class Personal {

        private string nombre;
        private string dni;

        public Personal(string _nom, string _dni) {
            this.nombre = _nom;
            this.dni = _dni;
        }

        public string GetNombre() {
            return nombre;
        }

        public virtual void Saludar() {
            Console.WriteLine("Hola, mi nombre es " + nombre + " y soy un Personal.");
        }

        public string GetDni() {
            return dni;
        }

        public void SetNombre(string _nom) {
            this.nombre = _nom;
        }

        public void SetDni(string _dni) {
            this.dni = _dni;
        }
    }

    public class Profesor : Personal {
        private string direccion;
        public string GetDireccion() {
            return this.direccion;
        }
        public Profesor(string _nom_, string _dni_, string _direc) : base(_nom_, _dni_) {
            this.direccion = _direc;
        }
    }
}
