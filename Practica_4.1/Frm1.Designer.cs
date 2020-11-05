namespace Practica_4._1
{
    partial class Frm1
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
            this.gbFiguras = new System.Windows.Forms.GroupBox();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbCircunferencia = new System.Windows.Forms.RadioButton();
            this.rbRectangulo = new System.Windows.Forms.RadioButton();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbFiguras.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiguras
            // 
            this.gbFiguras.Controls.Add(this.rbTriangulo);
            this.gbFiguras.Controls.Add(this.rbCircunferencia);
            this.gbFiguras.Controls.Add(this.rbRectangulo);
            this.gbFiguras.Location = new System.Drawing.Point(12, 12);
            this.gbFiguras.Name = "gbFiguras";
            this.gbFiguras.Size = new System.Drawing.Size(133, 100);
            this.gbFiguras.TabIndex = 0;
            this.gbFiguras.TabStop = false;
            this.gbFiguras.Text = "Tipos de figura";
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(19, 65);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbTriangulo.TabIndex = 2;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "Triangulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbTriangulo_CheckedChanged);
            // 
            // rbCircunferencia
            // 
            this.rbCircunferencia.AutoSize = true;
            this.rbCircunferencia.Location = new System.Drawing.Point(19, 42);
            this.rbCircunferencia.Name = "rbCircunferencia";
            this.rbCircunferencia.Size = new System.Drawing.Size(93, 17);
            this.rbCircunferencia.TabIndex = 1;
            this.rbCircunferencia.TabStop = true;
            this.rbCircunferencia.Text = "Circunferencia";
            this.rbCircunferencia.UseVisualStyleBackColor = true;
            this.rbCircunferencia.CheckedChanged += new System.EventHandler(this.rbCircunferencia_CheckedChanged);
            // 
            // rbRectangulo
            // 
            this.rbRectangulo.AutoSize = true;
            this.rbRectangulo.Location = new System.Drawing.Point(19, 19);
            this.rbRectangulo.Name = "rbRectangulo";
            this.rbRectangulo.Size = new System.Drawing.Size(80, 17);
            this.rbRectangulo.TabIndex = 0;
            this.rbRectangulo.TabStop = true;
            this.rbRectangulo.Text = "Rectangulo";
            this.rbRectangulo.UseVisualStyleBackColor = true;
            this.rbRectangulo.CheckedChanged += new System.EventHandler(this.rbRectangulo_CheckedChanged);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtAltura);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.txtRadio);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.txtAncho);
            this.gbDatos.Controls.Add(this.label);
            this.gbDatos.Controls.Add(this.txtLargo);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(12, 118);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(287, 90);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de la figura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(208, 50);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(59, 20);
            this.txtAltura.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Altura";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(208, 24);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(59, 20);
            this.txtRadio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Radio";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(62, 50);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(59, 20);
            this.txtAncho.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 53);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Ancho";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(62, 24);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(59, 20);
            this.txtLargo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Largo";
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(180, 31);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(75, 34);
            this.btnCalcularArea.TabIndex = 4;
            this.btnCalcularArea.Text = "Calcular Area";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(180, 71);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 218);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbFiguras);
            this.Name = "Frm1";
            this.Text = "Figuras Geometricas";
            this.Load += new System.EventHandler(this.Frm1_Load);
            this.gbFiguras.ResumeLayout(false);
            this.gbFiguras.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiguras;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbCircunferencia;
        private System.Windows.Forms.RadioButton rbRectangulo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.Button btnSalir;
    }
}