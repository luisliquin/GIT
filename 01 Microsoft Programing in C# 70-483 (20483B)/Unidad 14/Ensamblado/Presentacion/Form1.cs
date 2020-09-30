using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;
using System.Reflection;

namespace Presentacion {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            /*
                Assembly ensamblado = Assembly.LoadFile(Application.StartupPath + "\\Libreria.dll");

                Type[] tipos = ensamblado.GetTypes();
                foreach (Type tipo in tipos) {
                    if (tipo.IsClass) {
                        lstClases.Items.Add(tipo.Name);
                    }
                }

                FieldInfo[] atributos = tipos[0].GetFields();
                foreach (FieldInfo campo in atributos) {
                    lstAtributos.Items.Add(campo.Name);
                }

                MethodInfo[] metodos = tipos[0].GetMethods();
                foreach (MethodInfo metodo in metodos) {
                    lstMetodos.Items.Add(metodo.Name);
                }

                string[] nombres = new string[] {"Nombre1"};
                object obj = Activator.CreateInstance(tipos[0], nombres);
                object[] parametros = null;
                metodos[0].Invoke(obj, parametros);*/

            Type tipo = Type.GetType("System.String");

            DateTime fecha = DateTime.Now;
            Type tip = fecha.GetType();
        }
    }
}