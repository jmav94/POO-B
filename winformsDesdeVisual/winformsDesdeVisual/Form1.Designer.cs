namespace winformsDesdeVisual
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.chkInt = new System.Windows.Forms.CheckBox();
            this.chkDouble = new System.Windows.Forms.CheckBox();
            this.chkBool = new System.Windows.Forms.CheckBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.lsbPlatillos = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPlatillo = new System.Windows.Forms.TextBox();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnRecorrerDg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(699, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(44, 19);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dato";
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(150, 17);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 3;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // chkInt
            // 
            this.chkInt.AutoSize = true;
            this.chkInt.Location = new System.Drawing.Point(44, 57);
            this.chkInt.Name = "chkInt";
            this.chkInt.Size = new System.Drawing.Size(80, 17);
            this.chkInt.TabIndex = 4;
            this.chkInt.Text = "Parse to Int";
            this.chkInt.UseVisualStyleBackColor = true;
            // 
            // chkDouble
            // 
            this.chkDouble.AutoSize = true;
            this.chkDouble.Location = new System.Drawing.Point(44, 80);
            this.chkDouble.Name = "chkDouble";
            this.chkDouble.Size = new System.Drawing.Size(102, 17);
            this.chkDouble.TabIndex = 5;
            this.chkDouble.Text = "Parse to Double";
            this.chkDouble.UseVisualStyleBackColor = true;
            // 
            // chkBool
            // 
            this.chkBool.AutoSize = true;
            this.chkBool.Location = new System.Drawing.Point(44, 103);
            this.chkBool.Name = "chkBool";
            this.chkBool.Size = new System.Drawing.Size(107, 17);
            this.chkBool.TabIndex = 6;
            this.chkBool.Text = "Parse to Boolean";
            this.chkBool.UseVisualStyleBackColor = true;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(152, 76);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 7;
            this.btnParse.Text = "&Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lsbPlatillos
            // 
            this.lsbPlatillos.FormattingEnabled = true;
            this.lsbPlatillos.Location = new System.Drawing.Point(8, 60);
            this.lsbPlatillos.Name = "lsbPlatillos";
            this.lsbPlatillos.Size = new System.Drawing.Size(120, 95);
            this.lsbPlatillos.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(114, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar Platillo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPlatillo
            // 
            this.txtPlatillo.Location = new System.Drawing.Point(8, 22);
            this.txtPlatillo.Name = "txtPlatillo";
            this.txtPlatillo.Size = new System.Drawing.Size(100, 20);
            this.txtPlatillo.TabIndex = 10;
            this.txtPlatillo.TextChanged += new System.EventHandler(this.txtPlatillo_TextChanged);
            this.txtPlatillo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlatillo_KeyPress_1);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(130, 86);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(97, 23);
            this.btnRecorrer.TabIndex = 11;
            this.btnRecorrer.Text = "Recorrer Lista";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDato);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.chkInt);
            this.groupBox1.Controls.Add(this.chkDouble);
            this.groupBox1.Controls.Add(this.btnParse);
            this.groupBox1.Controls.Add(this.chkBool);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 136);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.lsbPlatillos);
            this.groupBox2.Controls.Add(this.btnRecorrer);
            this.groupBox2.Controls.Add(this.txtPlatillo);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 175);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero});
            this.dgEmpleados.Location = new System.Drawing.Point(291, 88);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.Size = new System.Drawing.Size(442, 150);
            this.dgEmpleados.TabIndex = 14;
            this.dgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.Frozen = true;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(290, 62);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(42, 20);
            this.txtNum.TabIndex = 8;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(359, 62);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 15;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(465, 62);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sueldo";
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(571, 60);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(65, 23);
            this.btnAgregarEmpleado.TabIndex = 12;
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnRecorrerDg
            // 
            this.btnRecorrerDg.Location = new System.Drawing.Point(642, 60);
            this.btnRecorrerDg.Name = "btnRecorrerDg";
            this.btnRecorrerDg.Size = new System.Drawing.Size(82, 23);
            this.btnRecorrerDg.TabIndex = 19;
            this.btnRecorrerDg.Text = "Recorrer";
            this.btnRecorrerDg.UseVisualStyleBackColor = true;
            this.btnRecorrerDg.Click += new System.EventHandler(this.btnRecorrerDg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.btnRecorrerDg);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "w";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.CheckBox chkInt;
        private System.Windows.Forms.CheckBox chkDouble;
        private System.Windows.Forms.CheckBox chkBool;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.ListBox lsbPlatillos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPlatillo;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnRecorrerDg;
    }
}

