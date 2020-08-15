using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Servidor {
    class Program {
        static void Main(string[] args) {
            Conectar();
        }
        static void Conectar() {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("192.168.1.7"),80);

            byte[] rec = new byte[255];

            try {
                socket.Bind(direccion);
                socket.Listen(1);

                Console.WriteLine("Escuchando... ");
                Socket escucha = socket.Accept();

                Console.WriteLine("Conexion exitosa... ");

                int x = escucha.Receive(rec, 0, rec.Length,0);

                Array.Resize(ref rec, x);

                Console.WriteLine("El cliente dice " + Encoding.Default.GetString(rec));
                
                socket.Close();
            }
            catch (Exception exc) {
                Console.WriteLine("ERROR " + exc.Message.ToString());
            }
            
            Console.WriteLine("presione una tecla...");
            Console.ReadKey();
        }
    }
}