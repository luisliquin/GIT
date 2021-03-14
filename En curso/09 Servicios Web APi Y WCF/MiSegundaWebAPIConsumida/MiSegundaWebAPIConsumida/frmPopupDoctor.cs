using MiSegundaWebAPIConsumida.CapaDatos;
using MiSegundaWebAPIConsumida.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiSegundaWebAPIConsumida {
    public partial class frmPopupDoctor : Form {
        DoctorCLS oDoctorCLS;
        public int iidDoctor { get; set; }
        public frmPopupDoctor() {
            InitializeComponent();
        }

        string nombreArchivo;
        private async void frmPopupDoctor_Load(object sender, EventArgs e) {           
            if (iidDoctor==0) {
                rbMascu.Checked=true;
                this.Text="Agregando Doctor";
            } else {
                this.Text="Editanto Doctor";
                DoctorDAL oDoctorDAL = new DoctorDAL();
                oDoctorCLS = await oDoctorDAL.recuperarDoctor(iidDoctor);
                txtIdDoctor.Text=oDoctorCLS.iidDoctor.ToString();
                txtNombre.Text=oDoctorCLS.nombre;
                txtApPaterno.Text=oDoctorCLS.apPaterno;
                txtApMaterno.Text=oDoctorCLS.apMaterno;
                txtEmail.Text=oDoctorCLS.email;
                dtFechaContrato.Value=oDoctorCLS.fechaContrato;
                //cboEspecialidad.SelectedValue=oDoctorCLS.iidEspecialidad;
                //cboClinica.SelectedValue = oDoctorCLS.iidClinica;
                txtSueldo.Text=oDoctorCLS.sueldo.ToString();

                txtTelefonoCelular.Text=oDoctorCLS.telefonoCelular==null ? "":
                    oDoctorCLS.telefonoCelular.ToString();

                if (oDoctorCLS.iidSexo==1) {
                    rbMascu.Checked=true;
                } else {
                    rbFemenino.Checked=true;
                }

                string foto = oDoctorCLS.archivo;
                nombreArchivo=oDoctorCLS.nombreArchivo;
                if (foto!=null && foto != "") {
                    string extension = Path.GetExtension(nombreArchivo).Substring(1);
                    foto=foto.Replace("data:image/" + extension + ";base64,", "");
                    byte[] fotoArray = Convert.FromBase64String(foto);
                    using (MemoryStream ms = new MemoryStream(fotoArray)) {
                        pbFoto.Image=Image.FromStream(ms);
                    }
                }
            }

            await Task.Run(() => {
                llenarCombo();
            });
        }

        private async void llenarCombo() {
            DoctorDAL oDoctorDAL = new DoctorDAL();
            List<ClinicaCLS> listaClinica = await oDoctorDAL.listarClinica();
            List<EspecialidadCLS> listaEspecialidad = await oDoctorDAL.listarEspecialidad();
            listaClinica.Insert(0, new ClinicaCLS { iidClinica = 0, nombreClinica= "--Seleccione--"});
            listaEspecialidad.Insert(0, new EspecialidadCLS { iidEspecialidad=0, nombreEspecialidad="--Seleccione--" });
            ///
            this.Invoke(new MethodInvoker(() => {
                cboClinica.DataSource=listaClinica;
                cboClinica.DisplayMember="nombreClinica";
                cboClinica.ValueMember="iidClinica";
                //Pintando lo recuperado
                if(iidDoctor !=0) { 
                cboClinica.SelectedValue=oDoctorCLS.iidClinica;
                }

                cboEspecialidad.DataSource=listaEspecialidad;
                cboEspecialidad.DisplayMember="nombreEspecialidad";
                cboEspecialidad.ValueMember="iidEspecialidad";

                if (iidDoctor!=0) {
                //Pintando lo recuperado
                cboEspecialidad.SelectedValue=oDoctorCLS.iidEspecialidad;
                }
            }));
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter="Archivo de imagen |*jpg;*png";

            if (ofd.ShowDialog().Equals(DialogResult.OK)) {
                nombreArchivo=Path.GetFileName(ofd.FileName);
                byte[] buffer = File.ReadAllBytes(ofd.FileName);

                using (MemoryStream ms = new MemoryStream()) {
                    pbFoto.Image=Image.FromStream(ms);
                }
            }
        }
    }
}