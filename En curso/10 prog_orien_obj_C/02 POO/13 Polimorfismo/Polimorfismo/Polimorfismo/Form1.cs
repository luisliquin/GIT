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
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Teacher teacher = new Teacher();
            teacher.SetValues(1);
            string messagetext = teacher.GetValues();
            textBox1.Text=messagetext;
        }

        private void button2_Click(object sender, EventArgs e) {
            Teacher teacher = new Teacher();
            teacher.SetValues(1,"Charles");
            string messagetext = teacher.GetValues();
            textBox1.Text=messagetext;
        }

        private void button3_Click(object sender, EventArgs e) {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Charles",2000);
            string messagetext = teacher.GetValues();
            textBox1.Text=messagetext;
        }

        private void button4_Click(object sender, EventArgs e) {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Charles", 2000,"Teacher");
            string messagetext = teacher.GetValues();
            textBox1.Text=messagetext;
        }

        private void button5_Click(object sender, EventArgs e) {
            Employee2 employee = new Employee2();
            string messagetext = employee.SetValues(1, "Charles", 2000);
            textBox1.Text=messagetext;
        }

        private void button6_Click(object sender, EventArgs e) {
            Teacher2 employee = new Teacher2();
            string messagetext = employee.SetValues(1, "Charles", 2000);
            textBox1.Text=messagetext;
        }
    }
}