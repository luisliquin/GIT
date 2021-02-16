using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace CriptoAsimetrico {
    public class ClaseEncriptacion {
        public RSACryptoServiceProvider RSA { get; set;}

        public ClaseEncriptacion() {
            this.RSA=new RSACryptoServiceProvider();
        }

        public byte[] CrearClavesPublicas() {
            string clavexmlpublica = this.RSA.ToXmlString(false);
            return Encoding.ASCII.GetBytes(clavexmlpublica);
        }
        public byte[] CrearClavesPrivadas() {
            string clavexmlprivada = this.RSA.ToXmlString(true);
            return Encoding.ASCII.GetBytes(clavexmlprivada);
        }

        public static byte[] EncriptarTexto(string mensaje, string clavepublica) {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1824);
            rsa.FromXmlString(clavepublica);
            byte[] datosencriptados = rsa.Encrypt(Encoding.ASCII.GetBytes(mensaje), false);
            return datosencriptados;
        }

        public static byte[] DesencriptarTexto(string mensajeencriptado, string claveprivada) {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1824);
            rsa.FromXmlString(claveprivada);
            byte[] datosdescifrados = rsa.Decrypt(Convert.FromBase64String(mensajeencriptado),false);
            return datosdescifrados;
        }
    }
}