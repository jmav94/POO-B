namespace EjercicioVariosTodos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSucursal = new System.Windows.Forms.GroupBox();
            this.gbEmpleado = new System.Windows.Forms.GroupBox();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCapturarSucursal = new System.Windows.Forms.Button();
            this.btnCapturarEmpleado = new System.Windows.Forms.Button();
            this.lbSucursales = new System.Windows.Forms.ListBox();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.btnContarEmpleadosSucursal = new System.Windows.Forms.Button();
            this.btnSumarSueldosCorporativo = new System.Windows.Forms.Button();
            this.btnEmpleadosCorporativo = new System.Windows.Forms.Button();
            this.btnSueldosSucursal = new System.Windows.Forms.Button();
            this.btnEmpleadoSueldoMayorSucursal = new System.Windows.Forms.Button();
            this.btnEmpleadoSueldoMayorCorporativo = new System.Windows.Forms.Button();
            this.btnSucursalMenorSueldo = new System.Windows.Forms.Button();
            this.btnSucursalMenosEmpleados = new System.Windows.Forms.Button();
            this.btnPromedioSueldoCorporativo = new System.Windows.Forms.Button();
            this.btnPromedioEmpleadosSucursal = new System.Windows.Forms.Button();
            this.gbSucursal.SuspendLayout();
            this.gbEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSucursal
            // 
            this.gbSucursal.Controls.Add(this.btnCapturarSucursal);
            this.gbSucursal.Controls.Add(this.label2);
            this.gbSucursal.Controls.Add(this.label1);
            this.gbSucursal.Controls.Add(this.txtDireccion);
            this.gbSucursal.Controls.Add(this.txtNombreSucursal);
            this.gbSucursal.Location = new System.Drawing.Point(21, 21);
            this.gbSucursal.Name = "gbSucursal";
            this.gbSucursal.Size = new System.Drawing.Size(198, 127);
            this.gbSucursal.TabIndex = 0;
            this.gbSucursal.TabStop = false;
            this.gbSucursal.Text = "Datos de la Sucursal";
            // 
            // gbEmpleado
            // 
            this.gbEmpleado.Controls.Add(this.btnCapturarEmpleado);
            this.gbEmpleado.Controls.Add(this.label5);
            this.gbEmpleado.Controls.Add(this.label4);
            this.gbEmpleado.Controls.Add(this.label3);
            this.gbEmpleado.Controls.Add(this.txtSueldo);
            this.gbEmpleado.Controls.Add(this.txtNumero);
            this.gbEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.gbEmpleado.Location = new System.Drawing.Point(21, 154);
            this.gbEmpleado.Name = "gbEmpleado";
            this.gbEmpleado.Size = new System.Drawing.Size(198, 161);
            this.gbEmpleado.TabIndex = 1;
            this.gbEmpleado.TabStop = false;
            this.gbEmpleado.Text = "Datos del Empleado";
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(82, 23);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSucursal.TabIndex = 0;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(79, 49);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(59, 55);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmpleado.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(59, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(38, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(59, 81);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(61, 20);
            this.txtSueldo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dirección: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sueldo:";
            // 
            // btnCapturarSucursal
            // 
            this.btnCapturarSucursal.Location = new System.Drawing.Point(59, 93);
            this.btnCapturarSucursal.Name = "btnCapturarSucursal";
            this.btnCapturarSucursal.Size = new System.Drawing.Size(75, 23);
            this.btnCapturarSucursal.TabIndex = 4;
            this.btnCapturarSucursal.Text = "Capturar Sucursal";
            this.btnCapturarSucursal.UseVisualStyleBackColor = true;
            this.btnCapturarSucursal.Click += new System.EventHandler(this.btnCapturarSucursal_Click);
            // 
            // btnCapturarEmpleado
            // 
            this.btnCapturarEmpleado.Location = new System.Drawing.Point(45, 119);
            this.btnCapturarEmpleado.Name = "btnCapturarEmpleado";
            this.btnCapturarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnCapturarEmpleado.TabIndex = 5;
            this.btnCapturarEmpleado.Text = "Capturar";
            this.btnCapturarEmpleado.UseVisualStyleBackColor = true;
            this.btnCapturarEmpleado.Click += new System.EventHandler(this.btnCapturarEmpleado_Click);
            // 
            // lbSucursales
            // 
            this.lbSucursales.FormattingEnabled = true;
            this.lbSucursales.Location = new System.Drawing.Point(225, 27);
            this.lbSucursales.Name = "lbSucursales";
            this.lbSucursales.Size = new System.Drawing.Size(240, 121);
            this.lbSucursales.TabIndex = 7;
            this.lbSucursales.Click += new System.EventHandler(this.lbSucursales_Click);
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Location = new System.Drawing.Point(225, 154);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.Size = new System.Drawing.Size(240, 161);
            this.dgEmpleados.TabIndex = 8;
            this.dgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellContentClick);
            // 
            // btnContarEmpleadosSucursal
            // 
            this.btnContarEmpleadosSucursal.Location = new System.Drawing.Point(471, 29);
            this.btnContarEmpleadosSucursal.Name = "btnContarEmpleadosSucursal";
            this.btnContarEmpleadosSucursal.Size = new System.Drawing.Size(223, 23);
            this.btnContarEmpleadosSucursal.TabIndex = 9;
            this.btnContarEmpleadosSucursal.Text = "Contar empleados de la sucursal";
            this.btnContarEmpleadosSucursal.UseVisualStyleBackColor = true;
            this.btnContarEmpleadosSucursal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSumarSueldosCorporativo
            // 
            this.btnSumarSueldosCorporativo.Location = new System.Drawing.Point(471, 114);
            this.btnSumarSueldosCorporativo.Name = "btnSumarSueldosCorporativo";
            this.btnSumarSueldosCorporativo.Size = new System.Drawing.Size(223, 23);
            this.btnSumarSueldosCorporativo.TabIndex = 10;
            this.btnSumarSueldosCorporativo.Text = "Sumar sueldos del Corporativo";
            this.btnSumarSueldosCorporativo.UseVisualStyleBackColor = true;
            this.btnSumarSueldosCorporativo.Click += new System.EventHandler(this.btnSumarSueldosCorporativo_Click);
            // 
            // btnEmpleadosCorporativo
            // 
            this.btnEmpleadosCorporativo.Location = new System.Drawing.Point(471, 58);
            this.btnEmpleadosCorporativo.Name = "btnEmpleadosCorporativo";
            this.btnEmpleadosCorporativo.Size = new System.Drawing.Size(223, 23);
            this.btnEmpleadosCorporativo.TabIndex = 11;
            this.btnEmpleadosCorporativo.Text = "Contar empleados del Corporativo";
            this.btnEmpleadosCorporativo.UseVisualStyleBackColor = true;
            this.btnEmpleadosCorporativo.Click += new System.EventHandler(this.btnEmpleadosCorporativo_Click);
            // 
            // btnSueldosSucursal
            // 
            this.btnSueldosSucursal.Location = new System.Drawing.Point(471, 87);
            this.btnSueldosSucursal.Name = "btnSueldosSucursal";
            this.btnSueldosSucursal.Size = new System.Drawing.Size(223, 23);
            this.btnSueldosSucursal.TabIndex = 12;
            this.btnSueldosSucursal.Text = "Sumar sueldos de la Sucursal";
            this.btnSueldosSucursal.UseVisualStyleBackColor = true;
            this.btnSueldosSucursal.Click += new System.EventHandler(this.btnSueldosSucursal_Click);
            // 
            // btnEmpleadoSueldoMayorSucursal
            // 
            this.btnEmpleadoSueldoMayorSucursal.Location = new System.Drawing.Point(471, 143);
            this.btnEmpleadoSueldoMayorSucursal.Name = "btnEmpleadoSueldoMayorSucursal";
            this.btnEmpleadoSueldoMayorSucursal.Size = new System.Drawing.Size(223, 23);
            this.btnEmpleadoSueldoMayorSucursal.TabIndex = 13;
            this.btnEmpleadoSueldoMayorSucursal.Text = "Empleado con mayor sueldo de la Sucursal";
            this.btnEmpleadoSueldoMayorSucursal.UseVisualStyleBackColor = true;
            this.btnEmpleadoSueldoMayorSucursal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEmpleadoSueldoMayorCorporativo
            // 
            this.btnEmpleadoSueldoMayorCorporativo.Location = new System.Drawing.Point(471, 172);
            this.btnEmpleadoSueldoMayorCorporativo.Name = "btnEmpleadoSueldoMayorCorporativo";
            this.btnEmpleadoSueldoMayorCorporativo.Size = new System.Drawing.Size(223, 23);
            this.btnEmpleadoSueldoMayorCorporativo.TabIndex = 14;
            this.btnEmpleadoSueldoMayorCorporativo.Text = "Empleado con mayor sueldo del Corporativo";
            this.btnEmpleadoSueldoMayorCorporativo.UseVisualStyleBackColor = true;
            this.btnEmpleadoSueldoMayorCorporativo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSucursalMenorSueldo
            // 
            this.btnSucursalMenorSueldo.Location = new System.Drawing.Point(471, 201);
            this.btnSucursalMenorSueldo.Name = "btnSucursalMenorSueldo";
            this.btnSucursalMenorSueldo.Size = new System.Drawing.Size(223, 23);
            this.btnSucursalMenorSueldo.TabIndex = 15;
            this.btnSucursalMenorSueldo.Text = "Sucursal con menor suma de Sueldos";
            this.btnSucursalMenorSueldo.UseVisualStyleBackColor = true;
            this.btnSucursalMenorSueldo.Click += new System.EventHandler(this.btnSucursalMenorSueldo_Click);
            // 
            // btnSucursalMenosEmpleados
            // 
            this.btnSucursalMenosEmpleados.Location = new System.Drawing.Point(471, 230);
            this.btnSucursalMenosEmpleados.Name = "btnSucursalMenosEmpleados";
            this.btnSucursalMenosEmpleados.Size = new System.Drawing.Size(223, 23);
            this.btnSucursalMenosEmpleados.TabIndex = 16;
            this.btnSucursalMenosEmpleados.Text = "Sucursal con menos Empleados";
            this.btnSucursalMenosEmpleados.UseVisualStyleBackColor = true;
            this.btnSucursalMenosEmpleados.Click += new System.EventHandler(this.btnSucursalMenosEmpleados_Click);
            // 
            // btnPromedioSueldoCorporativo
            // 
            this.btnPromedioSueldoCorporativo.Location = new System.Drawing.Point(471, 259);
            this.btnPromedioSueldoCorporativo.Name = "btnPromedioSueldoCorporativo";
            this.btnPromedioSueldoCorporativo.Size = new System.Drawing.Size(223, 23);
            this.btnPromedioSueldoCorporativo.TabIndex = 17;
            this.btnPromedioSueldoCorporativo.Text = "Promedio de sueldo en el Corporativo";
            this.btnPromedioSueldoCorporativo.UseVisualStyleBackColor = true;
            this.btnPromedioSueldoCorporativo.Click += new System.EventHandler(this.btnPromedioSueldoCorporativo_Click);
            // 
            // btnPromedioEmpleadosSucursal
            // 
            this.btnPromedioEmpleadosSucursal.Location = new System.Drawing.Point(471, 288);
            this.btnPromedioEmpleadosSucursal.Name = "btnPromedioEmpleadosSucursal";
            this.btnPromedioEmpleadosSucursal.Size = new System.Drawing.Size(223, 23);
            this.btnPromedioEmpleadosSucursal.TabIndex = 18;
            this.btnPromedioEmpleadosSucursal.Text = "Promedio de Empleados por Sucursal";
            this.btnPromedioEmpleadosSucursal.UseVisualStyleBackColor = true;
            this.btnPromedioEmpleadosSucursal.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 327);
            this.Controls.Add(this.btnPromedioEmpleadosSucursal);
            this.Controls.Add(this.btnPromedioSueldoCorporativo);
            this.Controls.Add(this.btnSucursalMenosEmpleados);
            this.Controls.Add(this.btnSucursalMenorSueldo);
            this.Controls.Add(this.btnEmpleadoSueldoMayorCorporativo);
            this.Controls.Add(this.btnEmpleadoSueldoMayorSucursal);
            this.Controls.Add(this.btnSueldosSucursal);
            this.Controls.Add(this.btnEmpleadosCorporativo);
            this.Controls.Add(this.btnSumarSueldosCorporativo);
            this.Controls.Add(this.btnContarEmpleadosSucursal);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.lbSucursales);
            this.Controls.Add(this.gbEmpleado);
            this.Controls.Add(this.gbSucursal);
            this.Name = "Form1";
            this.Text = "Grupo Corporativo Empresarial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSucursal.ResumeLayout(false);
            this.gbSucursal.PerformLayout();
            this.gbEmpleado.ResumeLayout(false);
            this.gbEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSucursal;
        private System.Windows.Forms.Button btnCapturarSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.GroupBox gbEmpleado;
        private System.Windows.Forms.Button btnCapturarEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.ListBox lbSucursales;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.Button btnContarEmpleadosSucursal;
        private System.Windows.Forms.Button btnSumarSueldosCorporativo;
        private System.Windows.Forms.Button btnEmpleadosCorporativo;
        private System.Windows.Forms.Button btnSueldosSucursal;
        private System.Windows.Forms.Button btnEmpleadoSueldoMayorSucursal;
        private System.Windows.Forms.Button btnEmpleadoSueldoMayorCorporativo;
        private System.Windows.Forms.Button btnSucursalMenorSueldo;
        private System.Windows.Forms.Button btnSucursalMenosEmpleados;
        private System.Windows.Forms.Button btnPromedioSueldoCorporativo;
        private System.Windows.Forms.Button btnPromedioEmpleadosSucursal;
    }
}

