using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML {
    public partial class Form1 : Form {
        string RutaArchivo = string.Empty;
        public Form1() {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog{
                InitialDirectory = @"E:\",
                Title = "Buscar Archivo",

                DefaultExt = "xml",
                Filter = "xml files (*.xml)|*xml",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (openFileDialog.ShowDialog()==DialogResult.OK) {
                lblRuta.Text=openFileDialog.FileName;
                RutaArchivo=openFileDialog.FileName;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e) {
            XmlTextReader xtr = new XmlTextReader(RutaArchivo);
            var datos = string.Empty;
            while (xtr.Read()) {
                if(xtr.NodeType == XmlNodeType.Element && xtr.Name == "curso"){
                    string s1 = xtr.ReadElementContentAsString();
                    datos += s1 + Environment.NewLine;
                }            
            }
            txtCarga.Text=datos;
        }

        private void btnMostrarAtributos_Click(object sender, EventArgs e) {
            XmlReader xtr = XmlReader.Create(RutaArchivo);
            var datos = string.Empty;

            while (xtr.Read()) {
                if (xtr.NodeType == XmlNodeType.Element){
                    datos+=$"Nombre del nodo: {xtr.Name} ==== Atributo: {xtr.AttributeCount} {Environment.NewLine}";
                }            
            }
            txtCargaAtributos.Text = datos;
        }

        private void btnCrearArchivoXML_Click(object sender, EventArgs e) {
            var ruta = @"E:\NuevoXML.xml";

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent=true;

            XmlWriter tw = XmlWriter.Create(ruta, settings);

            tw.WriteStartDocument();
            tw.WriteComment("Comentario Archivo!");

            tw.WriteStartElement("Cursos");
            tw.WriteAttributeString("tipo", "Informatica");

            tw.WriteStartElement("Ingenieria");
            tw.WriteStartElement("Nombre");
            tw.WriteString("Matematica Basica 1");
            tw.WriteEndElement();

            tw.WriteStartElement("Activo");
            tw.WriteString("2012");
            tw.WriteEndElement();

            tw.WriteStartElement("Credito");
            tw.WriteString("5");

            tw.WriteEndElement(); // Ingenieria
            tw.WriteEndElement(); // Cursos
            tw.WriteEndElement(); // xml Document

            tw.Close();
        }

        private void btnLeerArchivo_Click(object sender, EventArgs e) {
            XmlTextReader xmlr;
            xmlr=new XmlTextReader(@"E:\NuevoXML.xml");

            xmlr.WhitespaceHandling = WhitespaceHandling.None;
            
            xmlr.Read();
            
            xmlr.Read();

            while (!xmlr.EOF) {
                xmlr.Read();
                if (!xmlr.IsStartElement()) {
                    break;
                }

                if (xmlr.Name =="Ingenieria") {
                    xmlr.Read();

                    var nNombre = xmlr.ReadElementString("Nombre");
                    var nActivo = xmlr.ReadElementString("Activo");
                    var nCreditos = xmlr.ReadElementString("Credito");

                    txtLeerNuevoXML.Text=$"Nombre del curso: {nNombre} {Environment.NewLine} " +
                        $"Fecha de registro: {nActivo} {Environment.NewLine} Creditos: {nCreditos}";
                }
            }
            xmlr.Close();
        }
    }
}