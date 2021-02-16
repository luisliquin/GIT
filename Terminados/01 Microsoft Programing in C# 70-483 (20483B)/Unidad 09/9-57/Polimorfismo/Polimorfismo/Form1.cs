using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo {
    public partial class Form1 : Form {
        Calculadora cal;
        Mascota mas = new Gato("tom");
        Mascota mas2 = new Perico("peric");

        Lista<string> lista;

        public Form1() {
            InitializeComponent();
            cal = new Calculadora(23.5,4);
        }

        private void Form1_Load(object sender, EventArgs e) {
            //double r = cal.Sumar(47,45,25);
            //MessageBox.Show(r.ToString());
            //MessageBox.Show(mas.Saludar());
            //MessageBox.Show(mas2.Saludar());

            lista=new Lista<string>(10);
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            lista.AgregarElemento(txtElemento.Text,0);
        }

        private void btnObtener_Click(object sender, EventArgs e) {
            MessageBox.Show(lista.ObtenerElemento(0));
        }
    }
}
