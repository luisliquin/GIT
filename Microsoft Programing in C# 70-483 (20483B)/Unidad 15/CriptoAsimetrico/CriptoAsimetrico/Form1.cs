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
using System.IO;
using System.Data.Odbc;

namespace CriptoAsimetrico {
    public partial class frmEncriptado : Form {
        public frmEncriptado() {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e) {
            ClaseEncriptacion crypto = new ClaseEncriptacion();
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog()==System.Windows.Forms.DialogResult.OK) {
                string carpeta = f.SelectedPath;
                FileStream fichero = new FileStream(Path.Combine(carpeta, "clavePublic.xml"), FileMode.Create, FileAccess.Write);
                byte[] clavepublica = crypto.CrearClavesPublicas();
                fichero.Write(clavepublica, 0, clavepublica.Length);
                fichero.Close();
                fichero=new FileStream(Path.Combine(carpeta, "ClavePrivate.xml"), FileMode.Create, FileAccess.Write);
                byte[] claveprivada = crypto.CrearClavesPrivadas();
                fichero.Write(claveprivada, 0, claveprivada.Length);
                fichero.Close();
                MessageBox.Show("claves almacenadas correctamente");
            }
        }

        private void btnEncriptar_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter="Claves publicas (*.xml)|*.xml";
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK) {
                Stream temporal = ofd.OpenFile();
                string clavespublicasxml = new StreamReader(temporal).ReadToEnd();
                byte[] datosencriptados = ClaseEncriptacion.EncriptarTexto(this.txtMensaje.Text, clavespublicasxml);
                this.txtResultado.Text=Convert.ToBase64String(datosencriptados);
                this.txtMensaje.Text=this.txtResultado.Text;
                this.txtResultado.Clear();
            }

        }

        private void btnDesencriptar_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter="Claves privadas (*.xml)|*.xml";
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK) {
                Stream temporal = ofd.OpenFile();
                string claveprivadaxml = new StreamReader(temporal).ReadToEnd();
                byte[] datosdescifrados = ClaseEncriptacion.DesencriptarTexto(this.txtMensaje.Text, claveprivadaxml);
                this.txtResultado.Text=Encoding.ASCII.GetString(datosdescifrados);
            }
        }
    }
}