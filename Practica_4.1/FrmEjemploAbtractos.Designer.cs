namespace Practica_4._1
{
    partial class FrmEjemploAbtractos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCircunferencia = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tpCuadrado = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarLado = new System.Windows.Forms.Button();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnSumaAreas = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpCircunferencia.SuspendLayout();
            this.tpCuadrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCircunferencia);
            this.tabControl1.Controls.Add(this.tpCuadrado);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(229, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCircunferencia
            // 
            this.tpCircunferencia.Controls.Add(this.label1);
            this.tpCircunferencia.Controls.Add(this.txtRadio);
            this.tpCircunferencia.Controls.Add(this.btnAgregar);
            this.tpCircunferencia.Location = new System.Drawing.Point(4, 22);
            this.tpCircunferencia.Name = "tpCircunferencia";
            this.tpCircunferencia.Padding = new System.Windows.Forms.Padding(3);
            this.tpCircunferencia.Size = new System.Drawing.Size(221, 74);
            this.tpCircunferencia.TabIndex = 0;
            this.tpCircunferencia.Text = "Circunferencia";
            this.tpCircunferencia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radio";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(54, 26);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(67, 20);
            this.txtRadio.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(139, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // tpCuadrado
            // 
            this.tpCuadrado.Controls.Add(this.label2);
            this.tpCuadrado.Controls.Add(this.btnAgregarLado);
            this.tpCuadrado.Controls.Add(this.txtLado);
            this.tpCuadrado.Location = new System.Drawing.Point(4, 22);
            this.tpCuadrado.Name = "tpCuadrado";
            this.tpCuadrado.Padding = new System.Windows.Forms.Padding(3);
            this.tpCuadrado.Size = new System.Drawing.Size(248, 74);
            this.tpCuadrado.TabIndex = 1;
            this.tpCuadrado.Text = "Cuadrado";
            this.tpCuadrado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lado";
            // 
            // btnAgregarLado
            // 
            this.btnAgregarLado.Location = new System.Drawing.Point(130, 21);
            this.btnAgregarLado.Name = "btnAgregarLado";
            this.btnAgregarLado.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarLado.TabIndex = 3;
            this.btnAgregarLado.Text = "Agregar";
            this.btnAgregarLado.UseVisualStyleBackColor = true;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(47, 23);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(67, 20);
            this.txtLado.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 95);
            this.listBox1.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(262, 36);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(184, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Datos de la figura seleccionada";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(262, 65);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(184, 23);
            this.btnMostrarTodos.TabIndex = 3;
            this.btnMostrarTodos.Text = "Datos de tosas las figuras";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // btnSumaAreas
            // 
            this.btnSumaAreas.Location = new System.Drawing.Point(262, 94);
            this.btnSumaAreas.Name = "btnSumaAreas";
            this.btnSumaAreas.Size = new System.Drawing.Size(184, 23);
            this.btnSumaAreas.TabIndex = 4;
            this.btnSumaAreas.Text = "Suma de areas";
            this.btnSumaAreas.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(262, 123);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(184, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(262, 186);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(184, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmEjemploAbtractos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 226);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSumaAreas);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmEjemploAbtractos";
            this.Text = "Figuras Geometricas";
            this.tabControl1.ResumeLayout(false);
            this.tpCircunferencia.ResumeLayout(false);
            this.tpCircunferencia.PerformLayout();
            this.tpCuadrado.ResumeLayout(false);
            this.tpCuadrado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCircunferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TabPage tpCuadrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnSumaAreas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}