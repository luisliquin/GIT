namespace XMLDOM {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarNodo = new System.Windows.Forms.TextBox();
            this.btnBuscarNodo = new System.Windows.Forms.Button();
            this.txtCarga2 = new System.Windows.Forms.TextBox();
            this.txtBusquedaCurso = new System.Windows.Forms.TextBox();
            this.btnBuscarCurso = new System.Windows.Forms.Button();
            this.txtAddNodo = new System.Windows.Forms.TextBox();
            this.btnAddNodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(93, 17);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(54, 13);
            this.lblRuta.TabIndex = 7;
            this.lblRuta.Text = "Ruta: ------";
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(12, 79);
            this.txtCarga.Multiline = true;
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(226, 359);
            this.txtCarga.TabIndex = 6;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 50);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarNodo
            // 
            this.txtBuscarNodo.Location = new System.Drawing.Point(339, 20);
            this.txtBuscarNodo.Name = "txtBuscarNodo";
            this.txtBuscarNodo.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarNodo.TabIndex = 9;
            // 
            // btnBuscarNodo
            // 
            this.btnBuscarNodo.Location = new System.Drawing.Point(256, 17);
            this.btnBuscarNodo.Name = "btnBuscarNodo";
            this.btnBuscarNodo.Size = new System.Drawing.Size(82, 23);
            this.btnBuscarNodo.TabIndex = 8;
            this.btnBuscarNodo.Text = "Buscar Nodo";
            this.btnBuscarNodo.UseVisualStyleBackColor = true;
            this.btnBuscarNodo.Click += new System.EventHandler(this.btnBuscarNodo_Click);
            // 
            // txtCarga2
            // 
            this.txtCarga2.Location = new System.Drawing.Point(256, 54);
            this.txtCarga2.Multiline = true;
            this.txtCarga2.Name = "txtCarga2";
            this.txtCarga2.Size = new System.Drawing.Size(258, 129);
            this.txtCarga2.TabIndex = 10;
            // 
            // txtBusquedaCurso
            // 
            this.txtBusquedaCurso.Location = new System.Drawing.Point(256, 218);
            this.txtBusquedaCurso.Multiline = true;
            this.txtBusquedaCurso.Name = "txtBusquedaCurso";
            this.txtBusquedaCurso.Size = new System.Drawing.Size(258, 220);
            this.txtBusquedaCurso.TabIndex = 12;
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.Location = new System.Drawing.Point(256, 189);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(82, 23);
            this.btnBuscarCurso.TabIndex = 11;
            this.btnBuscarCurso.Text = "Buscar Curso";
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            this.btnBuscarCurso.Click += new System.EventHandler(this.btnBuscarCurso_Click);
            // 
            // txtAddNodo
            // 
            this.txtAddNodo.Location = new System.Drawing.Point(530, 50);
            this.txtAddNodo.Multiline = true;
            this.txtAddNodo.Name = "txtAddNodo";
            this.txtAddNodo.Size = new System.Drawing.Size(258, 388);
            this.txtAddNodo.TabIndex = 14;
            // 
            // btnAddNodo
            // 
            this.btnAddNodo.Location = new System.Drawing.Point(530, 21);
            this.btnAddNodo.Name = "btnAddNodo";
            this.btnAddNodo.Size = new System.Drawing.Size(82, 23);
            this.btnAddNodo.TabIndex = 13;
            this.btnAddNodo.Text = "Add Nodo";
            this.btnAddNodo.UseVisualStyleBackColor = true;
            this.btnAddNodo.Click += new System.EventHandler(this.btnAddNodo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAddNodo);
            this.Controls.Add(this.btnAddNodo);
            this.Controls.Add(this.txtBusquedaCurso);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.txtCarga2);
            this.Controls.Add(this.txtBuscarNodo);
            this.Controls.Add(this.btnBuscarNodo);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarNodo;
        private System.Windows.Forms.Button btnBuscarNodo;
        private System.Windows.Forms.TextBox txtCarga2;
        private System.Windows.Forms.TextBox txtBusquedaCurso;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.TextBox txtAddNodo;
        private System.Windows.Forms.Button btnAddNodo;
    }
}