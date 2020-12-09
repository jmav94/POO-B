namespace Practica3._1
{
    partial class frmEj5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAuto = new System.Windows.Forms.RadioButton();
            this.rdbCamioneta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEjes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRodadas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCamioneta);
            this.groupBox1.Controls.Add(this.rdbAuto);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rdbAuto
            // 
            this.rdbAuto.AutoSize = true;
            this.rdbAuto.Location = new System.Drawing.Point(39, 21);
            this.rdbAuto.Name = "rdbAuto";
            this.rdbAuto.Size = new System.Drawing.Size(58, 21);
            this.rdbAuto.TabIndex = 0;
            this.rdbAuto.TabStop = true;
            this.rdbAuto.Text = "Auto";
            this.rdbAuto.UseVisualStyleBackColor = true;
            this.rdbAuto.CheckedChanged += new System.EventHandler(this.rdbAuto_CheckedChanged);
            // 
            // rdbCamioneta
            // 
            this.rdbCamioneta.AutoSize = true;
            this.rdbCamioneta.Location = new System.Drawing.Point(39, 59);
            this.rdbCamioneta.Name = "rdbCamioneta";
            this.rdbCamioneta.Size = new System.Drawing.Size(96, 21);
            this.rdbCamioneta.TabIndex = 1;
            this.rdbCamioneta.TabStop = true;
            this.rdbCamioneta.Text = "Camioneta";
            this.rdbCamioneta.UseVisualStyleBackColor = true;
            this.rdbCamioneta.CheckedChanged += new System.EventHandler(this.rdbCamioneta_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Num. serie: ";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(116, 43);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(122, 22);
            this.txtNumSerie.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(138, 82);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 22);
            this.txtMarca.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca: ";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(172, 123);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(66, 22);
            this.txtAnio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(172, 167);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(66, 22);
            this.txtPrecio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(434, 40);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(50, 22);
            this.txtCantidad.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad de Pasajeros:";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(418, 85);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(66, 22);
            this.txtCapacidad.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Capacidad de carga: ";
            // 
            // txtEjes
            // 
            this.txtEjes.Location = new System.Drawing.Point(418, 123);
            this.txtEjes.Name = "txtEjes";
            this.txtEjes.Size = new System.Drawing.Size(66, 22);
            this.txtEjes.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ejes:";
            // 
            // txtRodadas
            // 
            this.txtRodadas.Location = new System.Drawing.Point(418, 167);
            this.txtRodadas.Name = "txtRodadas";
            this.txtRodadas.Size = new System.Drawing.Size(66, 22);
            this.txtRodadas.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rodadas";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(207, 50);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 17;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(302, 50);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 18;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(412, 50);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtCapacidad);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtNumSerie);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.txtRodadas);
            this.gbDatos.Controls.Add(this.txtMarca);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.txtEjes);
            this.gbDatos.Controls.Add(this.txtAnio);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.txtPrecio);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.txtCantidad);
            this.gbDatos.Location = new System.Drawing.Point(12, 119);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(518, 215);
            this.gbDatos.TabIndex = 20;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // frmEj5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 365);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEj5";
            this.Text = "Ejercicio 5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCamioneta;
        private System.Windows.Forms.RadioButton rdbAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEjes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRodadas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbDatos;
    }
}