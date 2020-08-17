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
using System.Xml;
using System.Xml.XPath;

namespace XMLDOM {
    public partial class Form2 : Form {
        string rutaArchivo = string.Empty;
        XmlDocument doc;
        XPathNavigator navegador;
        public Form2() {            
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog{
                InitialDirectory = @"E:\",
                Title = "Buscar Archivos",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xml",
                Filter = "xml files (*.xml)|*.xml",
                FilterIndex = 2,
            };

            if (openFileDialog.ShowDialog()==DialogResult.OK) {
                lblRuta.Text=openFileDialog.FileName;
                rutaArchivo=openFileDialog.FileName;
            }
        }

        private void CargarArchivoXml(string archivo, TextBox txtNombre) {
            System.IO.FileStream fich;
            fich=new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader str = new StreamReader(fich);

            str.BaseStream.Seek(0, SeekOrigin.Begin);

            txtNombre.Text=str.ReadToEnd();
            str.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e) {
            CargarArchivoXml(rutaArchivo, txtCarga);
            
            doc=new XmlDocument();
            doc.Load(rutaArchivo);

            navegador=doc.CreateNavigator();
        }

        private void btnBuscarNodo_Click(object sender, EventArgs e) {
            string datos = string.Empty;
            XPathNodeIterator nodos = navegador.Select(txtBuscarNodo.Text);
            while (nodos.MoveNext()) {
                datos+=nodos.Current.OuterXml+Environment.NewLine;
            }
            txtCarga2.Text=datos;
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e) {
            string datos = string.Empty;
            XPathNodeIterator nodos = navegador.Select(
            "/curso/informatica[@tipo='presencial']/programacion/curso[@hora = 'dia']");

            while (nodos.MoveNext()) {
                datos+=nodos.Current.OuterXml+Environment.NewLine;
            }
            txtBusquedaCurso.Text=datos;
        }

        private void btnAddNodo_Click(object sender, EventArgs e) {
            XPathNodeIterator nodos = navegador.Select(
            "/curso/informatica[@tipo='presencial']/datos");
            nodos.MoveNext();
            nodos.Current.AppendChild("<curso hora='noche'>SQL SERVER</curso>");

            var rutaNuevoArchivo = @"D:\curso4.xml";
            doc.Save(rutaNuevoArchivo);

            CargarArchivoXml(rutaNuevoArchivo, txtAddNodo);
        }
    }
}
