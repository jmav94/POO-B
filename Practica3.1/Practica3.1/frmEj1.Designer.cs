namespace Practica3._1
{
    partial class frmEj1
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
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rdbLibro = new System.Windows.Forms.RadioButton();
            this.rdbAudio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbVentasLibro = new System.Windows.Forms.ListBox();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.btnCapturarVenta = new System.Windows.Forms.Button();
            this.lbVentasCD = new System.Windows.Forms.ListBox();
            this.gpbTipo.SuspendLayout();
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbTipo
            // 
            this.gpbTipo.Controls.Add(this.rdbAudio);
            this.gpbTipo.Controls.Add(this.rdbLibro);
            this.gpbTipo.Location = new System.Drawing.Point(12, 12);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(171, 100);
            this.gpbTipo.TabIndex = 0;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo de publicación";
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.txtTiempo);
            this.gpbDatos.Controls.Add(this.label4);
            this.gpbDatos.Controls.Add(this.txtPaginas);
            this.gpbDatos.Controls.Add(this.label3);
            this.gpbDatos.Controls.Add(this.txtPrecio);
            this.gpbDatos.Controls.Add(this.label2);
            this.gpbDatos.Controls.Add(this.txtTitulo);
            this.gpbDatos.Controls.Add(this.label1);
            this.gpbDatos.Location = new System.Drawing.Point(12, 133);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(250, 190);
            this.gpbDatos.TabIndex = 1;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos de publicación";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(314, 157);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 51);
            this.btnCapturar.TabIndex = 0;
            this.btnCapturar.Text = "Capturar Datos";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(314, 229);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 45);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(314, 300);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rdbLibro
            // 
            this.rdbLibro.AutoSize = true;
            this.rdbLibro.Location = new System.Drawing.Point(18, 30);
            this.rdbLibro.Name = "rdbLibro";
            this.rdbLibro.Size = new System.Drawing.Size(115, 21);
            this.rdbLibro.TabIndex = 4;
            this.rdbLibro.TabStop = true;
            this.rdbLibro.Text = "Libro Impreso";
            this.rdbLibro.UseVisualStyleBackColor = true;
            this.rdbLibro.CheckedChanged += new System.EventHandler(this.rdbLibro_CheckedChanged);
            // 
            // rdbAudio
            // 
            this.rdbAudio.AutoSize = true;
            this.rdbAudio.Location = new System.Drawing.Point(18, 57);
            this.rdbAudio.Name = "rdbAudio";
            this.rdbAudio.Size = new System.Drawing.Size(101, 21);
            this.rdbAudio.TabIndex = 5;
            this.rdbAudio.TabStop = true;
            this.rdbAudio.Text = "Audio Libro";
            this.rdbAudio.UseVisualStyleBackColor = true;
            this.rdbAudio.CheckedChanged += new System.EventHandler(this.rdbAudio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(91, 21);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(148, 22);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(139, 68);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(139, 107);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(100, 22);
            this.txtPaginas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Num. Paginas";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(139, 145);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 22);
            this.txtTiempo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tiempo (minutos)";
            // 
            // lbVentasLibro
            // 
            this.lbVentasLibro.FormattingEnabled = true;
            this.lbVentasLibro.ItemHeight = 16;
            this.lbVentasLibro.Location = new System.Drawing.Point(208, 43);
            this.lbVentasLibro.Name = "lbVentasLibro";
            this.lbVentasLibro.Size = new System.Drawing.Size(181, 84);
            this.lbVentasLibro.TabIndex = 4;
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(208, 12);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(64, 22);
            this.txtVenta.TabIndex = 5;
            // 
            // btnCapturarVenta
            // 
            this.btnCapturarVenta.Location = new System.Drawing.Point(278, 12);
            this.btnCapturarVenta.Name = "btnCapturarVenta";
            this.btnCapturarVenta.Size = new System.Drawing.Size(111, 23);
            this.btnCapturarVenta.TabIndex = 6;
            this.btnCapturarVenta.Text = "Capturar";
            this.btnCapturarVenta.UseVisualStyleBackColor = true;
            this.btnCapturarVenta.Click += new System.EventHandler(this.btnCapturarVenta_Click);
            // 
            // lbVentasCD
            // 
            this.lbVentasCD.FormattingEnabled = true;
            this.lbVentasCD.ItemHeight = 16;
            this.lbVentasCD.Location = new System.Drawing.Point(208, 43);
            this.lbVentasCD.Name = "lbVentasCD";
            this.lbVentasCD.Size = new System.Drawing.Size(181, 84);
            this.lbVentasCD.TabIndex = 7;
            // 
            // frmEj1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 353);
            this.Controls.Add(this.lbVentasCD);
            this.Controls.Add(this.btnCapturarVenta);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.lbVentasLibro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.gpbTipo);
            this.Name = "frmEj1";
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.frmEj1_Load);
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.RadioButton rdbAudio;
        private System.Windows.Forms.RadioButton rdbLibro;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lbVentasLibro;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Button btnCapturarVenta;
        private System.Windows.Forms.ListBox lbVentasCD;
    }
}