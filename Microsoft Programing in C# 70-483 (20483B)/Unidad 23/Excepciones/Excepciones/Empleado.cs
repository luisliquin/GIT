using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones {
    public partial class Empleado : Form {
        public Empleado() {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            EmpleadoEx empleado = new EmpleadoEx();

            try {
                empleado.Nombre=txtEdad.Text;
                empleado.Edad=Convert.ToInt32(txtEdad.Text);
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message);
                return;
            }
        }
    }
}
