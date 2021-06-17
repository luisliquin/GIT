using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Employee employeeDetails = new Employee();
            employeeDetails.EmployeeName=txtEmployeeName.Text;
            employeeDetails.EmployeeAge=Convert.ToInt32(txtEmployeeAge.Text);
            employeeDetails.EmployeePosition=txtEmployeePosition.Text;
            FormEmployeeDetails frm = new FormEmployeeDetails();
            frm.label2.Text=employeeDetails.EmployeeName;
            frm.label3.Text=employeeDetails.EmployeeAge.ToString();
            frm.label4.Text=employeeDetails.EmployeePosition;
            frm.ShowDialog();
        }
    }
}