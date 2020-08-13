using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq {
    class Program {
        static void Main(string[] args) {
            ////1. FUENTE DE DATOS
            //int[] datos = new int[]{2,4,7,8,15,20,12};
            ////CREAR CONSULTA
            //var consulta = from d in datos where (d % 2) == 0 select d;
            ////EJECUTAR CONSULTA
            //foreach (var c in consulta) {
            //    Console.WriteLine("Los elementos son: {0}",c);
            //}

            //Persona[] personas = {  new Persona("Jose", "Suarez", 25),
            //                        new Persona("Marco", "De la fuente", 34),
            //                        new Persona("Pablo", "Escobar", 37)};

            //IEnumerable<Persona> consulta=from p in personas where p.Edad>30 select p;

            //foreach (Persona per in consulta) {
            //    Console.WriteLine(per.Nombre+" "+per.Apellido);
            //}

            
            ColegioContextDataContext _db = new ColegioContextDataContext();
            var alumnos = from a in _db.tb_alumno where a.calificacion > 12
                          orderby a.apellidos select a;

            foreach (tb_alumno tb in alumnos) {
                Console.WriteLine(tb.nombres + " " + tb.apellidos);
            }

            Console.ReadKey();
        }
    }
}