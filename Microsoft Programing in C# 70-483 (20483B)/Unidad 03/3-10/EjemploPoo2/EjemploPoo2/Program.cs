using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo2 {
    class Program {
        static void Main(string[] args) {
            //Persona per = new Persona();
            //per.SetNombre("Juan");
            //per.SetApellido("Perez");
            //per.SetEdad(29);
            //Console.WriteLine(
            //    "Su nombre es " + per.GetNombre() +
            //    ", su apellido es " + per.GetApellido() +
            //    " y tiene " + per.GetEdad().ToString() + " años."
            //    );

            //Personal personal  = new Personal("Jose", "12354678");

            //Profesor profe = new Profesor("profesor1", "12346102","direccion xxx");
            //Console.WriteLine("Nombre: "  + profe.GetNombre());
            //Console.WriteLine("DNI: "     + profe.GetDni());
            //Console.WriteLine("Direccion "+ profe.GetDireccion());

            Personal per = new Personal("personal juan", "123");
            per.Saludar();
            per = new Alumno("Alumno Jose", "1313");
            per.Saludar();
            Console.ReadKey();
        }
    }
}