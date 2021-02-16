using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Aplicacion {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e) {
            Thread hilo = new Thread(new ThreadStart(CorrerProceso));
            hilo.Start();            
        }

        delegate void DelegadoCambiarProgreso(int valor);

        private void CambiarProgreso(int valor) {
            if (this.InvokeRequired) {
                DelegadoCambiarProgreso delegado = new DelegadoCambiarProgreso(CambiarProgreso);
                object[] parametros = new object[]{valor};
                this.Invoke(delegado, parametros);
            }
            else {
                progressBar.Value=valor;
            }            
        }

        private void CorrerProceso() {
            
            for (int c = 1; c <= progressBar.Maximum; c++) {
                Thread.Sleep(1000);
                CambiarProgreso(c);
            }
            Console.WriteLine("proceso finalizado");
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnMensaje_Click(object sender, EventArgs e) {
            MessageBox.Show("mensaje |||");
        }
    }

    

}
