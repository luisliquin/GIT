namespace Presentacion {
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
            this.lstClases = new System.Windows.Forms.ListBox();
            this.lstAtributos = new System.Windows.Forms.ListBox();
            this.lstMetodos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstClases
            // 
            this.lstClases.FormattingEnabled = true;
            this.lstClases.Location = new System.Drawing.Point(34, 34);
            this.lstClases.Name = "lstClases";
            this.lstClases.Size = new System.Drawing.Size(161, 238);
            this.lstClases.TabIndex = 0;
            // 
            // lstAtributos
            // 
            this.lstAtributos.FormattingEnabled = true;
            this.lstAtributos.Location = new System.Drawing.Point(231, 34);
            this.lstAtributos.Name = "lstAtributos";
            this.lstAtributos.Size = new System.Drawing.Size(161, 238);
            this.lstAtributos.TabIndex = 1;
            // 
            // lstMetodos
            // 
            this.lstMetodos.FormattingEnabled = true;
            this.lstMetodos.Location = new System.Drawing.Point(443, 34);
            this.lstMetodos.Name = "lstMetodos";
            this.lstMetodos.Size = new System.Drawing.Size(161, 238);
            this.lstMetodos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 320);
            this.Controls.Add(this.lstMetodos);
            this.Controls.Add(this.lstAtributos);
            this.Controls.Add(this.lstClases);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstClases;
        private System.Windows.Forms.ListBox lstAtributos;
        private System.Windows.Forms.ListBox lstMetodos;
    }
}

