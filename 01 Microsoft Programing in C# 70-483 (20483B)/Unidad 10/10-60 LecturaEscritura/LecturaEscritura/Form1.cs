using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LecturaEscritura {
    public partial class Form1 : Form {

        string ruta = Application.StartupPath + @"\archivo.txt";
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //Stream st = File.OpenRead(ruta);
            //BufferedStream buf = new BufferedStream(st);
            //byte[] b = new byte[128];        
            //buf.Read(b,0,128);            
            //MessageBox.Show("el arreglo contiene " + Encoding.ASCII.GetString(b));

            StreamWriter wri = File.AppendText(ruta);
            wri.Write("Mas texto");
            wri.Close();

            StreamReader re = new StreamReader(ruta);
            textBox1.Text = re.ReadToEnd();
            re.Close();
        }
    }
}
