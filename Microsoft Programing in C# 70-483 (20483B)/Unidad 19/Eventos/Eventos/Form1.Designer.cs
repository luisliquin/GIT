namespace Eventos {
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtRetiro = new System.Windows.Forms.TextBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(27, 31);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(27, 71);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(41, 13);
            this.lblCuenta.TabIndex = 1;
            this.lblCuenta.Text = "Cuenta";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(27, 103);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(99, 23);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(203, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(99, 64);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(203, 20);
            this.txtCuenta.TabIndex = 4;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(99, 103);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(203, 20);
            this.txtSaldo.TabIndex = 5;
            // 
            // txtRetiro
            // 
            this.txtRetiro.Location = new System.Drawing.Point(308, 172);
            this.txtRetiro.Name = "txtRetiro";
            this.txtRetiro.Size = new System.Drawing.Size(187, 20);
            this.txtRetiro.TabIndex = 9;
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(99, 172);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(162, 20);
            this.txtDeposito.TabIndex = 8;
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.Location = new System.Drawing.Point(267, 175);
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(35, 13);
            this.lblRetiro.TabIndex = 7;
            this.lblRetiro.Text = "Retiro";
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(27, 175);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(49, 13);
            this.lblDeposito.TabIndex = 6;
            this.lblDeposito.Text = "Deposito";
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(99, 198);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(75, 23);
            this.btnDeposito.TabIndex = 10;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(308, 198);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(75, 23);
            this.btnRetiro.TabIndex = 11;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 254);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.txtRetiro);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.lblRetiro);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.lblCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtRetiro;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnRetiro;
    }
}

