namespace Practica_4._1
{
    partial class frm4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumCta = new System.Windows.Forms.TextBox();
            this.txtNomCta = new System.Windows.Forms.TextBox();
            this.txtSaldoCta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPorcentajeInteres = new System.Windows.Forms.TextBox();
            this.txtComisionChequera = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbDatosCuenta = new System.Windows.Forms.GroupBox();
            this.dtpFecheVencimiento = new System.Windows.Forms.DateTimePicker();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbCheques = new System.Windows.Forms.RadioButton();
            this.rbAhorros = new System.Windows.Forms.RadioButton();
            this.btnCrearCta = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.gbDatosCuenta.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo";
            // 
            // txtNumCta
            // 
            this.txtNumCta.Location = new System.Drawing.Point(141, 26);
            this.txtNumCta.Name = "txtNumCta";
            this.txtNumCta.Size = new System.Drawing.Size(100, 20);
            this.txtNumCta.TabIndex = 5;
            // 
            // txtNomCta
            // 
            this.txtNomCta.Location = new System.Drawing.Point(141, 52);
            this.txtNomCta.Name = "txtNomCta";
            this.txtNomCta.Size = new System.Drawing.Size(100, 20);
            this.txtNomCta.TabIndex = 6;
            // 
            // txtSaldoCta
            // 
            this.txtSaldoCta.Location = new System.Drawing.Point(141, 78);
            this.txtSaldoCta.Name = "txtSaldoCta";
            this.txtSaldoCta.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoCta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Porcentaje de interes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Porcentaje de interes %";
            // 
            // txtPorcentajeInteres
            // 
            this.txtPorcentajeInteres.Location = new System.Drawing.Point(190, 130);
            this.txtPorcentajeInteres.Name = "txtPorcentajeInteres";
            this.txtPorcentajeInteres.Size = new System.Drawing.Size(51, 20);
            this.txtPorcentajeInteres.TabIndex = 11;
            // 
            // txtComisionChequera
            // 
            this.txtComisionChequera.Location = new System.Drawing.Point(190, 156);
            this.txtComisionChequera.Name = "txtComisionChequera";
            this.txtComisionChequera.Size = new System.Drawing.Size(51, 20);
            this.txtComisionChequera.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Comision por uso de chequera %";
            // 
            // gbDatosCuenta
            // 
            this.gbDatosCuenta.Controls.Add(this.dtpFecheVencimiento);
            this.gbDatosCuenta.Controls.Add(this.txtPorcentajeInteres);
            this.gbDatosCuenta.Controls.Add(this.label1);
            this.gbDatosCuenta.Controls.Add(this.txtComisionChequera);
            this.gbDatosCuenta.Controls.Add(this.label2);
            this.gbDatosCuenta.Controls.Add(this.label7);
            this.gbDatosCuenta.Controls.Add(this.label3);
            this.gbDatosCuenta.Controls.Add(this.txtNumCta);
            this.gbDatosCuenta.Controls.Add(this.label6);
            this.gbDatosCuenta.Controls.Add(this.txtNomCta);
            this.gbDatosCuenta.Controls.Add(this.label5);
            this.gbDatosCuenta.Controls.Add(this.txtSaldoCta);
            this.gbDatosCuenta.Controls.Add(this.label4);
            this.gbDatosCuenta.Location = new System.Drawing.Point(12, 86);
            this.gbDatosCuenta.Name = "gbDatosCuenta";
            this.gbDatosCuenta.Size = new System.Drawing.Size(362, 205);
            this.gbDatosCuenta.TabIndex = 14;
            this.gbDatosCuenta.TabStop = false;
            this.gbDatosCuenta.Text = "Daots de la cuenta";
            // 
            // dtpFecheVencimiento
            // 
            this.dtpFecheVencimiento.Location = new System.Drawing.Point(141, 104);
            this.dtpFecheVencimiento.Name = "dtpFecheVencimiento";
            this.dtpFecheVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFecheVencimiento.TabIndex = 0;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbAhorros);
            this.gbTipo.Controls.Add(this.rbCheques);
            this.gbTipo.Location = new System.Drawing.Point(12, 12);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(362, 68);
            this.gbTipo.TabIndex = 14;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo de cuenta";
            // 
            // rbCheques
            // 
            this.rbCheques.AutoSize = true;
            this.rbCheques.Location = new System.Drawing.Point(179, 32);
            this.rbCheques.Name = "rbCheques";
            this.rbCheques.Size = new System.Drawing.Size(119, 17);
            this.rbCheques.TabIndex = 15;
            this.rbCheques.TabStop = true;
            this.rbCheques.Text = "Cuenta de Cheques";
            this.rbCheques.UseVisualStyleBackColor = true;
            this.rbCheques.CheckedChanged += new System.EventHandler(this.rbCheques_CheckedChanged);
            // 
            // rbAhorros
            // 
            this.rbAhorros.AutoSize = true;
            this.rbAhorros.Location = new System.Drawing.Point(26, 32);
            this.rbAhorros.Name = "rbAhorros";
            this.rbAhorros.Size = new System.Drawing.Size(113, 17);
            this.rbAhorros.TabIndex = 16;
            this.rbAhorros.TabStop = true;
            this.rbAhorros.Text = "Cuenta de Ahorros";
            this.rbAhorros.UseVisualStyleBackColor = true;
            this.rbAhorros.CheckedChanged += new System.EventHandler(this.rbAhorros_CheckedChanged);
            // 
            // btnCrearCta
            // 
            this.btnCrearCta.Location = new System.Drawing.Point(396, 105);
            this.btnCrearCta.Name = "btnCrearCta";
            this.btnCrearCta.Size = new System.Drawing.Size(96, 23);
            this.btnCrearCta.TabIndex = 15;
            this.btnCrearCta.Text = "Crear cuenta";
            this.btnCrearCta.UseVisualStyleBackColor = true;
            this.btnCrearCta.Click += new System.EventHandler(this.btnCrearCta_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(398, 141);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(96, 23);
            this.btnDepositar.TabIndex = 16;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(396, 179);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(96, 23);
            this.btnRetirar.TabIndex = 17;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(396, 212);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(96, 23);
            this.btnMostrar.TabIndex = 18;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(394, 60);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 15;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(527, 60);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha";
            // 
            // frm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnCrearCta);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.gbDatosCuenta);
            this.Name = "frm4";
            this.Text = "Ejecicio 4 - Cuentas de banco";
            this.Load += new System.EventHandler(this.frm4_Load);
            this.gbDatosCuenta.ResumeLayout(false);
            this.gbDatosCuenta.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumCta;
        private System.Windows.Forms.TextBox txtNomCta;
        private System.Windows.Forms.TextBox txtSaldoCta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPorcentajeInteres;
        private System.Windows.Forms.TextBox txtComisionChequera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbDatosCuenta;
        private System.Windows.Forms.DateTimePicker dtpFecheVencimiento;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbAhorros;
        private System.Windows.Forms.RadioButton rbCheques;
        private System.Windows.Forms.Button btnCrearCta;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label9;
    }
}