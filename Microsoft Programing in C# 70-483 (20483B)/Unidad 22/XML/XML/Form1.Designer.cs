namespace XML {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.txtCargaAtributos = new System.Windows.Forms.TextBox();
            this.btnMostrarAtributos = new System.Windows.Forms.Button();
            this.lblCrearArchivoXML = new System.Windows.Forms.Label();
            this.btnCrearArchivoXML = new System.Windows.Forms.Button();
            this.txtLeerNuevoXML = new System.Windows.Forms.TextBox();
            this.btnLeerArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 50);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(106, 21);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(60, 13);
            this.lblRuta.TabIndex = 2;
            this.lblRuta.Text = "Ruta: --------";
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(12, 79);
            this.txtCarga.Multiline = true;
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(236, 150);
            this.txtCarga.TabIndex = 3;
            // 
            // txtCargaAtributos
            // 
            this.txtCargaAtributos.Location = new System.Drawing.Point(12, 264);
            this.txtCargaAtributos.Multiline = true;
            this.txtCargaAtributos.Name = "txtCargaAtributos";
            this.txtCargaAtributos.Size = new System.Drawing.Size(236, 174);
            this.txtCargaAtributos.TabIndex = 5;
            // 
            // btnMostrarAtributos
            // 
            this.btnMostrarAtributos.Location = new System.Drawing.Point(12, 235);
            this.btnMostrarAtributos.Name = "btnMostrarAtributos";
            this.btnMostrarAtributos.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarAtributos.TabIndex = 4;
            this.btnMostrarAtributos.Text = "Mostrar";
            this.btnMostrarAtributos.UseVisualStyleBackColor = true;
            this.btnMostrarAtributos.Click += new System.EventHandler(this.btnMostrarAtributos_Click);
            // 
            // lblCrearArchivoXML
            // 
            this.lblCrearArchivoXML.AutoSize = true;
            this.lblCrearArchivoXML.Location = new System.Drawing.Point(287, 12);
            this.lblCrearArchivoXML.Name = "lblCrearArchivoXML";
            this.lblCrearArchivoXML.Size = new System.Drawing.Size(96, 13);
            this.lblCrearArchivoXML.TabIndex = 7;
            this.lblCrearArchivoXML.Text = "Crear Archivo XML";
            // 
            // btnCrearArchivoXML
            // 
            this.btnCrearArchivoXML.Location = new System.Drawing.Point(290, 38);
            this.btnCrearArchivoXML.Name = "btnCrearArchivoXML";
            this.btnCrearArchivoXML.Size = new System.Drawing.Size(150, 23);
            this.btnCrearArchivoXML.TabIndex = 6;
            this.btnCrearArchivoXML.Text = "Crear Archivo XML";
            this.btnCrearArchivoXML.UseVisualStyleBackColor = true;
            this.btnCrearArchivoXML.Click += new System.EventHandler(this.btnCrearArchivoXML_Click);
            // 
            // txtLeerNuevoXML
            // 
            this.txtLeerNuevoXML.Location = new System.Drawing.Point(290, 108);
            this.txtLeerNuevoXML.Multiline = true;
            this.txtLeerNuevoXML.Name = "txtLeerNuevoXML";
            this.txtLeerNuevoXML.Size = new System.Drawing.Size(269, 330);
            this.txtLeerNuevoXML.TabIndex = 9;
            // 
            // btnLeerArchivo
            // 
            this.btnLeerArchivo.Location = new System.Drawing.Point(290, 79);
            this.btnLeerArchivo.Name = "btnLeerArchivo";
            this.btnLeerArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnLeerArchivo.TabIndex = 8;
            this.btnLeerArchivo.Text = "Leer Archivo XML";
            this.btnLeerArchivo.UseVisualStyleBackColor = true;
            this.btnLeerArchivo.Click += new System.EventHandler(this.btnLeerArchivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.txtLeerNuevoXML);
            this.Controls.Add(this.btnLeerArchivo);
            this.Controls.Add(this.lblCrearArchivoXML);
            this.Controls.Add(this.btnCrearArchivoXML);
            this.Controls.Add(this.txtCargaAtributos);
            this.Controls.Add(this.btnMostrarAtributos);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.TextBox txtCargaAtributos;
        private System.Windows.Forms.Button btnMostrarAtributos;
        private System.Windows.Forms.Label lblCrearArchivoXML;
        private System.Windows.Forms.Button btnCrearArchivoXML;
        private System.Windows.Forms.TextBox txtLeerNuevoXML;
        private System.Windows.Forms.Button btnLeerArchivo;
    }
}

