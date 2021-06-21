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

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        public delegate void fillTextBox(int x);
        string textvalue = "";

        public void FillMathNote(int ExaNote) {
            textvalue+="Your Math Note is: "+ExaNote+Environment.NewLine;
        }
        public void FillChemistryNote(int ExaNote) {
            textvalue+="Your Chemistry Note is: "+ExaNote+Environment.NewLine;
        }
        private void Form1_Load(object sender, EventArgs e) {

        }
        public void ShowInTextBox() {
            textBox1.Text=textvalue;
        }
        private void button1_Click(object sender, EventArgs e) {
            fillTextBox fillText = new fillTextBox(FillMathNote);
            fillText+= FillChemistryNote;
            fillText(80);
            fillText-=FillMathNote;
            fillText(60);
            ShowInTextBox();
        }
    }
}
