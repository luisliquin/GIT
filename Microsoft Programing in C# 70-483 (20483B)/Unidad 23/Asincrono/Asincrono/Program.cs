using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asincrono {
    class Program {
        public static async void MetodoAsincrono() {
            Task<string>tarea = RetrasoAsincrono ();
            try{
                var resultado = await tarea;
                Console.WriteLine("Resultado {0}", resultado);
            }
            catch (Exception e) {
                Console.WriteLine("Resultado {0}", e.Message);
            }
        
            Console.WriteLine("La tarea fue cancelada {0}", tarea.IsCanceled.ToString());
            Console.WriteLine("La tarea fallo {0}", tarea.IsFaulted.ToString());

            if (tarea.Exception!=null) {
                Console.WriteLine("Mensaje de excepcion {0}", tarea.Exception.Message);
                Console.WriteLine("Mensaje de excepcion Anidada {0}", tarea.Exception.InnerException.Message);
            }
        }

        public static async Task<string> RetrasoAsincrono() {
            await Task.Delay(100);
            //throw new OperationCanceledException("cancelando...");
            throw new Exception("Ocurrio un problema...");
            //return "Tarea completada";
        }

        static void Main(string[] args) {
            //Task tarea = new Task(MetodoAsincrono);
            //tarea.Start();
            //tarea.Wait();


            try {
                int edad = 140;
                if (edad > 100) {
                    throw new EdadException(edad);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
            finally {
                Console.WriteLine(3+5);
            }
            Console.ReadLine();
        }
    }
}