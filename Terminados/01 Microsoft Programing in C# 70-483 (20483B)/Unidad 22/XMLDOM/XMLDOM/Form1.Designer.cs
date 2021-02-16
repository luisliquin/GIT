namespace XMLDOM {
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
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnBuscarNodo = new System.Windows.Forms.Button();
            this.txtBuscarNodo = new System.Windows.Forms.TextBox();
            this.lstBusquedaNodo = new System.Windows.Forms.ListBox();
            this.btnModificarNodo = new System.Windows.Forms.Button();
            this.txtCargaNuevaModificacion = new System.Windows.Forms.TextBox();
            this.txtAddNodos = new System.Windows.Forms.TextBox();
            this.btnAddNodos = new System.Windows.Forms.Button();
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
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(12, 79);
            this.txtCarga.Multiline = true;
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(261, 359);
            this.txtCarga.TabIndex = 2;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(93, 17);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(54, 13);
            this.lblRuta.TabIndex = 3;
            this.lblRuta.Text = "Ruta: ------";
            // 
            // btnBuscarNodo
            // 
            this.btnBuscarNodo.Location = new System.Drawing.Point(280, 12);
            this.btnBuscarNodo.Name = "btnBuscarNodo";
            this.btnBuscarNodo.Size = new System.Drawing.Size(96, 23);
            this.btnBuscarNodo.TabIndex = 4;
            this.btnBuscarNodo.Text = "Buscar Nodo";
            this.btnBuscarNodo.UseVisualStyleBackColor = true;
            this.btnBuscarNodo.Click += new System.EventHandler(this.btnBuscarNodo_Click);
            // 
            // txtBuscarNodo
            // 
            this.txtBuscarNodo.Location = new System.Drawing.Point(396, 15);
            this.txtBuscarNodo.Name = "txtBuscarNodo";
            this.txtBuscarNodo.Size = new System.Drawing.Size(189, 20);
            this.txtBuscarNodo.TabIndex = 5;
            // 
            // lstBusquedaNodo
            // 
            this.lstBusquedaNodo.FormattingEnabled = true;
            this.lstBusquedaNodo.Location = new System.Drawing.Point(280, 41);
            this.lstBusquedaNodo.Name = "lstBusquedaNodo";
            this.lstBusquedaNodo.Size = new System.Drawing.Size(305, 56);
            this.lstBusquedaNodo.TabIndex = 6;
            // 
            // btnModificarNodo
            // 
            this.btnModificarNodo.Location = new System.Drawing.Point(280, 103);
            this.btnModificarNodo.Name = "btnModificarNodo";
            this.btnModificarNodo.Size = new System.Drawing.Size(305, 23);
            this.btnModificarNodo.TabIndex = 7;
            this.btnModificarNodo.Text = "Modificar Nodo";
            this.btnModificarNodo.UseVisualStyleBackColor = true;
            this.btnModificarNodo.Click += new System.EventHandler(this.btnModificarNodo_Click);
            // 
            // txtCargaNuevaModificacion
            // 
            this.txtCargaNuevaModificacion.Location = new System.Drawing.Point(280, 132);
            this.txtCargaNuevaModificacion.Multiline = true;
            this.txtCargaNuevaModificacion.Name = "txtCargaNuevaModificacion";
            this.txtCargaNuevaModificacion.Size = new System.Drawing.Size(305, 306);
            this.txtCargaNuevaModificacion.TabIndex = 8;
            // 
            // txtAddNodos
            // 
            this.txtAddNodos.Location = new System.Drawing.Point(591, 41);
            this.txtAddNodos.Multiline = true;
            this.txtAddNodos.Name = "txtAddNodos";
            this.txtAddNodos.Size = new System.Drawing.Size(305, 397);
            this.txtAddNodos.TabIndex = 10;
            // 
            // btnAddNodos
            // 
            this.btnAddNodos.Location = new System.Drawing.Point(591, 12);
            this.btnAddNodos.Name = "btnAddNodos";
            this.btnAddNodos.Size = new System.Drawing.Size(305, 23);
            this.btnAddNodos.TabIndex = 9;
            this.btnAddNodos.Text = "Añador Nodo";
            this.btnAddNodos.UseVisualStyleBackColor = true;
            this.btnAddNodos.Click += new System.EventHandler(this.btnAddNodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 447);
            this.Controls.Add(this.txtAddNodos);
            this.Controls.Add(this.btnAddNodos);
            this.Controls.Add(this.txtCargaNuevaModificacion);
            this.Controls.Add(this.btnModificarNodo);
            this.Controls.Add(this.lstBusquedaNodo);
            this.Controls.Add(this.txtBuscarNodo);
            this.Controls.Add(this.btnBuscarNodo);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtCarga);
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
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnBuscarNodo;
        private System.Windows.Forms.TextBox txtBuscarNodo;
        private System.Windows.Forms.ListBox lstBusquedaNodo;
        private System.Windows.Forms.Button btnModificarNodo;
        private System.Windows.Forms.TextBox txtCargaNuevaModificacion;
        private System.Windows.Forms.TextBox txtAddNodos;
        private System.Windows.Forms.Button btnAddNodos;
    }
}

