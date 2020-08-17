using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            int dividendo = 0;  int divisor = 0; int resultado = 0;
            try {
                dividendo=Convert.ToInt32(txt1.Text);
                divisor=Convert.ToInt32(txt2.Text);
                resultado= CalcularDivision(dividendo,divisor);
            }
            catch (DivideByZeroException ex) {
                MessageBox.Show("Error "+ex.Message);
            }
            finally {
                txtResultado.Text=resultado.ToString();
            }
        }
        private int CalcularDivision(int dividendo, int divisor) {
            if (divisor==0) {
                throw new DivideByZeroException("El divisor no debe ser 0");
            }
            else {
                return dividendo/divisor;
            }
        }
    }
}