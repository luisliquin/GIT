using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CriptoSimetrico {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e) {
            string mensaje = this.txtMensaje.Text;
            string password = this.txtClave.Text;
            string resultado = this.EncriptarTexto(mensaje, (new PasswordDeriveBytes(password, null)).GetBytes(32));
            this.txtResultado.Text=resultado;
        }

        private string EncriptarTexto(string _mensaje, byte[] byteclave){
            Rijndael cifradoRijn = Rijndael.Create();

            byte[] bytesEncriptado = null;
            byte[] byteSalida   = null;

            try {
                cifradoRijn.Key=byteclave;
                cifradoRijn.GenerateIV();

                byte[] byteEntrada = System.Text.Encoding.UTF8.GetBytes(_mensaje);
                bytesEncriptado=cifradoRijn.CreateEncryptor().TransformFinalBlock(byteEntrada, 0, byteEntrada.Length);
                byteSalida=new byte[cifradoRijn.IV.Length+bytesEncriptado.Length];
                cifradoRijn.IV.CopyTo(byteSalida, 0);
                bytesEncriptado.CopyTo(byteSalida, cifradoRijn.IV.Length);
            }
            catch (Exception esc) {
                Console.WriteLine(esc.Message);
            }
            finally {
                cifradoRijn.Clear();
            }
            string textosalida = Encoding.Default.GetString(byteSalida);
            return textosalida;
        }

        private string DesencriptarTexto(byte[] byteDatosCifrados, byte[] byteClave) {
            Rijndael cifradoRijn = Rijndael.Create();
            byte[] arrayTemporal = new byte[cifradoRijn.IV.Length];
            byte[] byteEncriptado = new byte[byteDatosCifrados.Length - cifradoRijn.IV.Length];
            string textoDescifrado = string.Empty;

            try {
                cifradoRijn.Key=byteClave;
                Array.Copy(byteDatosCifrados, arrayTemporal, arrayTemporal.Length);
                Array.Copy(byteDatosCifrados, arrayTemporal.Length, byteEncriptado, 0, byteEncriptado.Length);
                cifradoRijn.IV=arrayTemporal;

                textoDescifrado=System.Text.Encoding.UTF8.GetString((cifradoRijn.CreateDecryptor()).TransformFinalBlock(byteEncriptado,0,byteEncriptado.Length));
            }
            catch (Exception esc) {
                Console.WriteLine(esc.Message);
            }
            finally {
                cifradoRijn.Clear();
            }
            return textoDescifrado;
        }

        private void btnDesencriptar_Click(object sender, EventArgs e) {
            string mensajeDescifrado = this.txtResultado.Text;
            string password = this.txtClave.Text;
            byte[] textoByte;
            textoByte=Encoding.Default.GetBytes(mensajeDescifrado);
            string resultado = DesencriptarTexto(textoByte, (new PasswordDeriveBytes(password, null)).GetBytes(32));
            this.txtMensaje.Text=resultado;
        }
    }
}