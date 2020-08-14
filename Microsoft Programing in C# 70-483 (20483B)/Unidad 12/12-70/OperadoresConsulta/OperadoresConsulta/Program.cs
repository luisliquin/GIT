using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresConsulta {
    class Program {
        static void Main(string[] args) {
            ColegioDataContext _db = new ColegioDataContext();
            
            string primerApellido = (from a in _db.tb_alumno select a.apellidos).First();

            IQueryable<tb_alumno> lista = (from a in _db.tb_alumno select a).OrderByDescending(l => l.nombres            );

            IEnumerable<string> apellidos = lista.Select(m => m.apellidos);

            //foreach (tb_alumno t in lista) {
            //    Console.WriteLine("{0} {1}", t.nombres, t.apellidos);
            //}

            var union = from a in _db.tb_alumno
                        join g in _db.tb_grado on a.idgrado equals g.id
                        select new {
                            Nombres = a.nombres,
                            Apellidos = a.apellidos,
                            Grado = g.nombre,
                            Seccion = g.seccion,
                            Capacidad = g.capacidad
                        };

            foreach (var r in union) {
                Console.WriteLine("{0} {1} - {2} {3} {4}",r.Nombres, r.Apellidos, r.Grado, r.Seccion, r.Capacidad);
            }

            double promedio = (double)(from a in _db.tb_alumno select a.calificacion).Average();

            Console.WriteLine("el promedio es " + promedio);

            //foreach (string t in apellidos) {
            //    Console.WriteLine("{0}", t);
            //}

            //Console.WriteLine(primerApellido);
            Console.ReadKey();
        }
    }
}