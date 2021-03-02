using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento;

namespace MiSegundoServicioWCFConsumidoEnWindows {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            listar();
        }

        private void listar() {
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(remove);
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            oMedicamentosClient.ClientCredentials.UserName.UserName = "lhurol";
            oMedicamentosClient.ClientCredentials.UserName.Password = "1234";
            List<MedicamentoCLS> lista = oMedicamentosClient.listarMedicamentos().Where(p => p.bhabilitado==1).ToList();
            dgvMedicamento.DataSource=lista;
            dgvMedicamento.Columns["iidformafarmaceutica"].Visible = false;
            dgvMedicamento.Columns["bhabilitado"].Visible = false;
        }
        
        private bool remove(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) {
            return true;
        }
        
        private void toolStripNuevo_Click(object sender, EventArgs e) {
            frmPopupMedicamento ofrmPopupMedicamento = new frmPopupMedicamento();
            ofrmPopupMedicamento.iidmedicamento=0;
            ofrmPopupMedicamento.ShowDialog();

            if (ofrmPopupMedicamento.DialogResult.Equals(DialogResult.OK)) {
                listar();
            }
        }

        private void toolStripEditar_Click(object sender, EventArgs e) {
            frmPopupMedicamento ofrmPopupMedicamento = new frmPopupMedicamento();
            
            int idMedicamento = (int)dgvMedicamento.CurrentRow.Cells[0].Value;
            ofrmPopupMedicamento.iidmedicamento=idMedicamento;
            ofrmPopupMedicamento.ShowDialog();

            if (ofrmPopupMedicamento.DialogResult.Equals(DialogResult.OK)) {
                listar();
            }
        }

        private void toolStripEliminar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta seguro de eliminar?", "Confirmacion",
                MessageBoxButtons.YesNo).Equals(DialogResult.Yes)) {
                    int idMedicamento = (int)dgvMedicamento.CurrentRow.Cells[0].Value;
                    
                    MedicamentosClient oMedicamentosClient = new MedicamentosClient();
                    oMedicamentosClient.ClientCredentials.UserName.UserName="lhurol";
                    oMedicamentosClient.ClientCredentials.UserName.Password="1234";
                    
                    int rpta = oMedicamentosClient.eliminarMedicamento(idMedicamento);

                if (rpta==1) {
                    listar();
                    MessageBox.Show("Se elimino correctamente");
                } else {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }

        private void toolStripSalir_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}