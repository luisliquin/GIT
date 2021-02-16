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

namespace XMLDOM {
    public partial class Form1 : Form {
        string rutaArchivo = string.Empty;
        XmlDocument doc;
        XmlNodeList Nodos;

        public Form1() {
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

        private void btnCargar_Click(object sender, EventArgs e) {
            CargarArchivoXml(rutaArchivo, txtCarga);

            doc=new XmlDocument();
            doc.Load(rutaArchivo);
        }

        private void CargarArchivoXml(string archivo, TextBox txtNombre) {
            FileStream fich;
            fich=new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader str = new StreamReader(fich);

            str.BaseStream.Seek(0, SeekOrigin.Begin);

            txtNombre.Text=str.ReadToEnd();
            str.Close();
         }

        private void btnBuscarNodo_Click(object sender, EventArgs e) {
            Nodos=doc.GetElementsByTagName(txtBuscarNodo.Text);
            foreach (XmlNode unNodo in Nodos) {
                lstBusquedaNodo.Items.Add(unNodo.Attributes["tipo"].Value);
            }
        }

        private void btnModificarNodo_Click(object sender, EventArgs e) {
            Nodos=doc.GetElementsByTagName("informatica");
            XmlAttribute att;

            foreach (XmlNode unNodo in Nodos) {
                if (unNodo.Attributes["tipo"].Value=="presencial") {
                    att=doc.CreateAttribute("codigo");
                    att.Value="A001";
                    unNodo.Attributes.Append(att);
                }

                if (unNodo.Attributes["tipo"].Value=="online") {
                    att=doc.CreateAttribute("codigo");
                    att.Value="B001";
                    unNodo.Attributes.Append(att);
                }
            }

            var rutaNuevoArchivo = @"E:\curso2.xml";
            doc.Save(rutaNuevoArchivo);

            CargarArchivoXml(rutaNuevoArchivo, txtCargaNuevaModificacion);

            doc=new XmlDocument();
            doc.Load(rutaNuevoArchivo);
        }

        private void btnAddNodos_Click(object sender, EventArgs e) {
            Nodos=doc.GetElementsByTagName("informatica");

            foreach (XmlElement unMenu in Nodos) {
                if (unMenu.Attributes["tipo"].Value=="presencial") {
                    XmlNode N1;
                    XmlNode N2;
                    XmlNode N3;

                    N1=doc.CreateNode(XmlNodeType.Element, "seguridad", "");
                    N2=doc.CreateNode(XmlNodeType.Element, "curso", "");
                    N3=doc.CreateNode(XmlNodeType.Text, "", "");
                    N3.Value="Seguridad Informatica";
                    N2.AppendChild(N3);
                    N1.AppendChild(N2);
                    unMenu.AppendChild(N1);
                }
            }
            var rutaNuevoArchivo = @"D:\curso3.xml";
            doc.Save(rutaNuevoArchivo);

            CargarArchivoXml(rutaNuevoArchivo, txtAddNodos);
        }
    }
}