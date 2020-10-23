namespace Practica_3._2
{
    partial class frmE1
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbEmpresa = new System.Windows.Forms.GroupBox();
            this.gbDepartamento = new System.Windows.Forms.GroupBox();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtGerente = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCapturarEmpresa = new System.Windows.Forms.Button();
            this.btnInsertarDepartamento = new System.Windows.Forms.Button();
            this.dgDepartamentos = new System.Windows.Forms.DataGridView();
            this.btnEliminarDepartamento = new System.Windows.Forms.Button();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.btnElminarEmpleado = new System.Windows.Forms.Button();
            this.gbEmpleados = new System.Windows.Forms.GroupBox();
            this.btnInsertarEmpleado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSueldoEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.gbEmpresa.SuspendLayout();
            this.gbDepartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.gbEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(399, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbEmpresa
            // 
            this.gbEmpresa.Controls.Add(this.btnCapturarEmpresa);
            this.gbEmpresa.Controls.Add(this.label3);
            this.gbEmpresa.Controls.Add(this.label2);
            this.gbEmpresa.Controls.Add(this.label1);
            this.gbEmpresa.Controls.Add(this.txtGerente);
            this.gbEmpresa.Controls.Add(this.txtRazonSocial);
            this.gbEmpresa.Controls.Add(this.txtRfc);
            this.gbEmpresa.Location = new System.Drawing.Point(12, 12);
            this.gbEmpresa.Name = "gbEmpresa";
            this.gbEmpresa.Size = new System.Drawing.Size(276, 115);
            this.gbEmpresa.TabIndex = 1;
            this.gbEmpresa.TabStop = false;
            this.gbEmpresa.Text = "Datos de la empresa";
            this.gbEmpresa.Enter += new System.EventHandler(this.gbEmpresa_Enter);
            // 
            // gbDepartamento
            // 
            this.gbDepartamento.Controls.Add(this.btnInsertarDepartamento);
            this.gbDepartamento.Controls.Add(this.label6);
            this.gbDepartamento.Controls.Add(this.label5);
            this.gbDepartamento.Controls.Add(this.label4);
            this.gbDepartamento.Controls.Add(this.txtJefe);
            this.gbDepartamento.Controls.Add(this.txtNombre);
            this.gbDepartamento.Controls.Add(this.txtNumero);
            this.gbDepartamento.Location = new System.Drawing.Point(12, 133);
            this.gbDepartamento.Name = "gbDepartamento";
            this.gbDepartamento.Size = new System.Drawing.Size(276, 108);
            this.gbDepartamento.TabIndex = 2;
            this.gbDepartamento.TabStop = false;
            this.gbDepartamento.Text = "Datos de departamento";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(40, 19);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(140, 20);
            this.txtRfc.TabIndex = 0;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(80, 50);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(100, 20);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // txtGerente
            // 
            this.txtGerente.Location = new System.Drawing.Point(57, 81);
            this.txtGerente.Name = "txtGerente";
            this.txtGerente.Size = new System.Drawing.Size(123, 20);
            this.txtGerente.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(57, 19);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(42, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(57, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtJefe
            // 
            this.txtJefe.Location = new System.Drawing.Point(39, 71);
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.Size = new System.Drawing.Size(118, 20);
            this.txtJefe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RFC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Razón social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gerente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jefe";
            // 
            // btnCapturarEmpresa
            // 
            this.btnCapturarEmpresa.Location = new System.Drawing.Point(195, 52);
            this.btnCapturarEmpresa.Name = "btnCapturarEmpresa";
            this.btnCapturarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnCapturarEmpresa.TabIndex = 3;
            this.btnCapturarEmpresa.Text = "Capturar";
            this.btnCapturarEmpresa.UseVisualStyleBackColor = true;
            this.btnCapturarEmpresa.Click += new System.EventHandler(this.btnCapturarEmpresa_Click);
            // 
            // btnInsertarDepartamento
            // 
            this.btnInsertarDepartamento.Location = new System.Drawing.Point(195, 48);
            this.btnInsertarDepartamento.Name = "btnInsertarDepartamento";
            this.btnInsertarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarDepartamento.TabIndex = 6;
            this.btnInsertarDepartamento.Text = "Insertar";
            this.btnInsertarDepartamento.UseVisualStyleBackColor = true;
            this.btnInsertarDepartamento.Click += new System.EventHandler(this.btnInsertarDepartamento_Click);
            // 
            // dgDepartamentos
            // 
            this.dgDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartamentos.Location = new System.Drawing.Point(306, 12);
            this.dgDepartamentos.Name = "dgDepartamentos";
            this.dgDepartamentos.Size = new System.Drawing.Size(276, 229);
            this.dgDepartamentos.TabIndex = 3;
            this.dgDepartamentos.SelectionChanged += new System.EventHandler(this.dgDepartamentos_SelectionChanged);
            this.dgDepartamentos.Click += new System.EventHandler(this.dgDepartamentos_Click);
            // 
            // btnEliminarDepartamento
            // 
            this.btnEliminarDepartamento.Location = new System.Drawing.Point(377, 247);
            this.btnEliminarDepartamento.Name = "btnEliminarDepartamento";
            this.btnEliminarDepartamento.Size = new System.Drawing.Size(138, 23);
            this.btnEliminarDepartamento.TabIndex = 4;
            this.btnEliminarDepartamento.Text = "Eliminar departamento";
            this.btnEliminarDepartamento.UseVisualStyleBackColor = true;
            this.btnEliminarDepartamento.Click += new System.EventHandler(this.btnEliminarDepartamento_Click);
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Location = new System.Drawing.Point(599, 12);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.Size = new System.Drawing.Size(276, 229);
            this.dgEmpleados.TabIndex = 5;
            // 
            // btnElminarEmpleado
            // 
            this.btnElminarEmpleado.Location = new System.Drawing.Point(672, 247);
            this.btnElminarEmpleado.Name = "btnElminarEmpleado";
            this.btnElminarEmpleado.Size = new System.Drawing.Size(138, 23);
            this.btnElminarEmpleado.TabIndex = 6;
            this.btnElminarEmpleado.Text = "Eliminar empleado";
            this.btnElminarEmpleado.UseVisualStyleBackColor = true;
            this.btnElminarEmpleado.Click += new System.EventHandler(this.btnElminarEmpleado_Click);
            // 
            // gbEmpleados
            // 
            this.gbEmpleados.Controls.Add(this.btnInsertarEmpleado);
            this.gbEmpleados.Controls.Add(this.label7);
            this.gbEmpleados.Controls.Add(this.label8);
            this.gbEmpleados.Controls.Add(this.label9);
            this.gbEmpleados.Controls.Add(this.txtSueldoEmpleado);
            this.gbEmpleados.Controls.Add(this.txtNombreEmpleado);
            this.gbEmpleados.Controls.Add(this.txtNumeroEmpleado);
            this.gbEmpleados.Location = new System.Drawing.Point(12, 247);
            this.gbEmpleados.Name = "gbEmpleados";
            this.gbEmpleados.Size = new System.Drawing.Size(276, 108);
            this.gbEmpleados.TabIndex = 9;
            this.gbEmpleados.TabStop = false;
            this.gbEmpleados.Text = "Datos de empleado";
            // 
            // btnInsertarEmpleado
            // 
            this.btnInsertarEmpleado.Location = new System.Drawing.Point(195, 48);
            this.btnInsertarEmpleado.Name = "btnInsertarEmpleado";
            this.btnInsertarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarEmpleado.TabIndex = 6;
            this.btnInsertarEmpleado.Text = "Insertar";
            this.btnInsertarEmpleado.UseVisualStyleBackColor = true;
            this.btnInsertarEmpleado.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sueldo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Numero";
            // 
            // txtSueldoEmpleado
            // 
            this.txtSueldoEmpleado.Location = new System.Drawing.Point(57, 71);
            this.txtSueldoEmpleado.Name = "txtSueldoEmpleado";
            this.txtSueldoEmpleado.Size = new System.Drawing.Size(61, 20);
            this.txtSueldoEmpleado.TabIndex = 3;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(57, 45);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmpleado.TabIndex = 2;
            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Location = new System.Drawing.Point(57, 19);
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(42, 20);
            this.txtNumeroEmpleado.TabIndex = 1;
            // 
            // frmE1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.gbEmpleados);
            this.Controls.Add(this.btnElminarEmpleado);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.btnEliminarDepartamento);
            this.Controls.Add(this.dgDepartamentos);
            this.Controls.Add(this.gbDepartamento);
            this.Controls.Add(this.gbEmpresa);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmE1";
            this.Text = "Ejercicio 1 - 3";
            this.Load += new System.EventHandler(this.frmE1_Load);
            this.gbEmpresa.ResumeLayout(false);
            this.gbEmpresa.PerformLayout();
            this.gbDepartamento.ResumeLayout(false);
            this.gbDepartamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.gbEmpleados.ResumeLayout(false);
            this.gbEmpleados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbEmpresa;
        private System.Windows.Forms.Button btnCapturarEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGerente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.GroupBox gbDepartamento;
        private System.Windows.Forms.Button btnInsertarDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJefe;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DataGridView dgDepartamentos;
        private System.Windows.Forms.Button btnEliminarDepartamento;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.Button btnElminarEmpleado;
        private System.Windows.Forms.GroupBox gbEmpleados;
        private System.Windows.Forms.Button btnInsertarEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSueldoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtNumeroEmpleado;
    }
}