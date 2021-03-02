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

        private void btnAceptar_Click(object sender, EventArgs e) {
            var exito = true;
            if (txtNombre.Text=="") {
                errorDatos.SetError(txtNombre, "Ingrese nombre");
                exito=false;
            } else {
                errorDatos.SetError(txtNombre, "");
            }

            if (txtPrecio.Text=="") {
                errorDatos.SetError(txtPrecio, "Ingrese precio");
                exito=false;
            } else {
                errorDatos.SetError(txtPrecio, "");
            }

            if (txtStock.Text=="") {
                errorDatos.SetError(txtStock, "Ingrese stock");
                exito=false;
            } else {
                errorDatos.SetError(txtStock, "");
            }

            if (txtPresentacion.Text=="") {
                errorDatos.SetError(txtPresentacion, "Ingrese presentacion");
                exito=false;
            } else {
                errorDatos.SetError(txtPresentacion, "");
            }

            if (txtPresentacion.Text=="") {
                errorDatos.SetError(txtPresentacion, "Ingrese presentacion");
                exito=false;
            } else {
                errorDatos.SetError(txtPresentacion, "");
            }

            if (txtConcentracion.Text=="") {
                errorDatos.SetError(txtConcentracion, "Ingrese concentracion");
                exito=false;
            } else {
                errorDatos.SetError(txtConcentracion, "");
            }

            if ((int)cboFormaFarmaceutica.SelectedValue == 0) {
                errorDatos.SetError(cboFormaFarmaceutica, "Seleccione forma farmaceutica");
                exito=false;
            } else {
                errorDatos.SetError(cboFormaFarmaceutica, "");
            }

            if (exito==false) {
                this.DialogResult=DialogResult.None;
                return;
            } else {
                MedicamentoCLS oMedicamentoCLS = new MedicamentoCLS();
                oMedicamentoCLS.iidmedicamento=int.Parse(txtIdMedicamento.Text);
                oMedicamentoCLS.nombre=txtNombre.Text;
                oMedicamentoCLS.precio=decimal.Parse(txtPrecio.Text);
                oMedicamentoCLS.presentacion=txtPresentacion.Text;
                oMedicamentoCLS.iidformafarmaceutica=(int)cboFormaFarmaceutica.SelectedValue;
                oMedicamentoCLS.stock=int.Parse(txtStock.Text);
                oMedicamentoCLS.concentracion=txtConcentracion.Text;
                oMedicamentoCLS.bhabilitado=1;
                MedicamentosClient omedicamentosClient = new MedicamentosClient();
                omedicamentosClient.ClientCredentials.UserName.UserName="lhurol";
                omedicamentosClient.ClientCredentials.UserName.Password="1234";
                int rpta = omedicamentosClient.registrarYActualizarMedicamentos(oMedicamentoCLS);

                if (rpta == 1) {
                    MessageBox.Show("Se ejecuto correctamente");
                    this.DialogResult=DialogResult.OK;
                } else {
                    MessageBox.Show("Ocurrio un error");
                    this.DialogResult=DialogResult.None;
                }
            }
        }
    }
}
