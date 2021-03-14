using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiSegundaWebAPIConsumida.CapaDatos;
using MiSegundaWebAPIConsumida.Clases;

namespace MiSegundaWebAPIConsumida {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            listarDoctor();
        }

        public async void listarDoctor() {
            DoctorDAL oDoctorDal = new DoctorDAL();
            List<DoctorCLS> listaDoctor =  await oDoctorDal.ListarDoctor();
            dgvDoctor.DataSource=listaDoctor;
            for (int i = 6; i < dgvDoctor.Columns.Count; i++) {
                dgvDoctor.Columns[i].Visible=false;            
            }
        }

        private async void toolStripEliminar_Click(object sender, EventArgs e) {
            int iidDoctor = (int)dgvDoctor.CurrentRow.Cells[0].Value;
            DoctorDAL oDoctorDal = new DoctorDAL();
            int rpta = await oDoctorDal.eliminarDoctor(iidDoctor);
            if (rpta==1) {
                MessageBox.Show("Se elimino correctamente");
                listarDoctor();
            } else {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void toolStripNuevo_Click(object sender, EventArgs e) {
            frmPopupDoctor ofrmPopupDoctor = new frmPopupDoctor();
            ofrmPopupDoctor.iidDoctor=0;
            ofrmPopupDoctor.ShowDialog();
        }

        private void toolStripEditar_Click(object sender, EventArgs e) {
            frmPopupDoctor ofrmPopupDoctor = new frmPopupDoctor();
            int iidDoctor = (int)dgvDoctor.CurrentRow.Cells[0].Value;
            ofrmPopupDoctor.iidDoctor=iidDoctor;
            ofrmPopupDoctor.ShowDialog();
        }
    }
}