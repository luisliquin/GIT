using MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiSegundoServicioWCFConsumidoEnWindows {
    public partial class frmPopupMedicamento : Form {
        public int iidmedicamento { get; set; }
        public frmPopupMedicamento() {
            InitializeComponent();
        }

        private void frmPopupMedicamento_Load(object sender, EventArgs e) {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            oMedicamentosClient.ClientCredentials.UserName.UserName="lhurol";
            oMedicamentosClient.ClientCredentials.UserName.Password="1234";
            List<FormaFarmaceuticaCLS> listaForma = oMedicamentosClient.listarFormaFarmaceutica();
            listaForma.Insert(0, new FormaFarmaceuticaCLS { iidformafarmaceutica=0, nombreFormaFarmaceutica="--Seleccione" });
            cboFormaFarmaceutica.DataSource=listaForma;
            cboFormaFarmaceutica.DisplayMember="nombreFormaFarmaceutica";
            cboFormaFarmaceutica.ValueMember="iidFormaFarmaceutica";

            //Todo bien
            if (iidmedicamento==0) {
                this.Text="Agregar Medicamento";
                //Complemtamos la informacion
            } else {
                this.Text="Editando Medicamento";
                MedicamentosClient omedicamentosClientEditar = new MedicamentosClient();
                omedicamentosClientEditar.ClientCredentials.UserName.UserName="lhurol";
                omedicamentosClientEditar.ClientCredentials.UserName.Password="1234";
                MedicamentoCLS omedicamentoCLS = omedicamentosClientEditar.recuperarMedicamento(iidmedicamento);
                txtIdMedicamento.Text=omedicamentoCLS.iidmedicamento.ToString();
                txtNombre.Text=omedicamentoCLS.nombre;
                txtPrecio.Text=omedicamentoCLS.precio.ToString();
                txtStock.Text=omedicamentoCLS.stock.ToString();
                txtPresentacion.Text=omedicamentoCLS.presentacion;
                txtConcentracion.Text=omedicamentoCLS.concentracion;
                cboFormaFarmaceutica.SelectedValue=omedicamentoCLS.iidformafarmaceutica;
            }
        }

        private void solonumeros(object sender, KeyPressEventArgs e) {
            if (Char.IsDigit(e.KeyChar)) {
                e.Handled=false;
            } else if (Char.IsControl(e.KeyChar)) {
                e.Handled=false;
            } else {
                e.Handled=true;
            }
        }

        private void soloDecimales(object sender, KeyPressEventArgs e) {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar=='.' ||e.KeyChar==',') {
                e.Handled=false;
            } else if (Char.IsControl(e.KeyChar)) {
                e.Handled=false;
            } else {
                e.Handled=true;
            }
        }
    }
}
