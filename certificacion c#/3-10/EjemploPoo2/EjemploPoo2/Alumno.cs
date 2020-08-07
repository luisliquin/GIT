using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo2 {
    public class Alumno : Personal {
        public Alumno(string _nom_, string _dni_) : base(_nom_, _dni_) {            
        }

        public override void Saludar() {
            //base.Saludar();
            Console.WriteLine("Hola, mi nombre es " + GetNombre() + " y soy Alumno");
        }
    }
}