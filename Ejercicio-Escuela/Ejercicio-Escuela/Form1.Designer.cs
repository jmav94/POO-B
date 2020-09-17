namespace Ejercicio_Escuela
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
            this.gbPersona = new System.Windows.Forms.GroupBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.rdbProfesor = new System.Windows.Forms.RadioButton();
            this.rdbEstudiante = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPersona.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersona
            // 
            this.gbPersona.Controls.Add(this.rdbEstudiante);
            this.gbPersona.Controls.Add(this.rdbProfesor);
            this.gbPersona.Location = new System.Drawing.Point(38, 32);
            this.gbPersona.Name = "gbPersona";
            this.gbPersona.Size = new System.Drawing.Size(142, 100);
            this.gbPersona.TabIndex = 0;
            this.gbPersona.TabStop = false;
            this.gbPersona.Text = "Tipo de persona";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(199, 40);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 35);
            this.btnCapturar.TabIndex = 0;
            this.btnCapturar.TabStop = false;
            this.btnCapturar.Text = "Capturar Datos";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(199, 92);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 40);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtCalificacion);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.txtSueldo);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(38, 157);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(224, 135);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de la persona";
            // 
            // rdbProfesor
            // 
            this.rdbProfesor.AutoSize = true;
            this.rdbProfesor.Location = new System.Drawing.Point(32, 26);
            this.rdbProfesor.Name = "rdbProfesor";
            this.rdbProfesor.Size = new System.Drawing.Size(64, 17);
            this.rdbProfesor.TabIndex = 2;
            this.rdbProfesor.TabStop = true;
            this.rdbProfesor.Text = "Profesor";
            this.rdbProfesor.UseVisualStyleBackColor = true;
            this.rdbProfesor.CheckedChanged += new System.EventHandler(this.rdbProfesor_CheckedChanged);
            // 
            // rdbEstudiante
            // 
            this.rdbEstudiante.AutoSize = true;
            this.rdbEstudiante.Location = new System.Drawing.Point(32, 60);
            this.rdbEstudiante.Name = "rdbEstudiante";
            this.rdbEstudiante.Size = new System.Drawing.Size(75, 17);
            this.rdbEstudiante.TabIndex = 3;
            this.rdbEstudiante.TabStop = true;
            this.rdbEstudiante.Text = "Estudiante";
            this.rdbEstudiante.UseVisualStyleBackColor = true;
            this.rdbEstudiante.CheckedChanged += new System.EventHandler(this.rdbEstudiante_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre : ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(100, 69);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sueldo : ";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(100, 102);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 20);
            this.txtCalificacion.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Calificacion : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 314);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.gbPersona);
            this.Name = "Form1";
            this.Text = "Personas de una escuela";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPersona.ResumeLayout(false);
            this.gbPersona.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersona;
        private System.Windows.Forms.RadioButton rdbEstudiante;
        private System.Windows.Forms.RadioButton rdbProfesor;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}

