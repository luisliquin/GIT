using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cliente {
    class Program {
        static void Main(string[] args) {
            Conectar();
        }

        static void Conectar() {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("192.168.1.7"),80);

            string mensaje;
            byte[] aEnviar;
            
            try {
                socket.Connect(direccion);

                Console.WriteLine("Cliente conectado con exito... ");

                Console.WriteLine("Ingrese mensaje ");
                mensaje = Console.ReadLine();
                aEnviar = Encoding.Default.GetBytes(mensaje);
                socket.Send(aEnviar, 0, aEnviar.Length, 0);

                Console.WriteLine("mensaje enviado");
                socket.Close();
            }
            catch (Exception exc) {
                Console.WriteLine("ERROR "+exc.Message.ToString());
            }

            Console.WriteLine("presione una tecla...");
            Console.ReadKey();
        }
    }
}