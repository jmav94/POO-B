using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Escuela
{
    public partial class Form1 : Form
    {
        // Creacion de objeto de tipo Profesor
        Profesor unProfesor = new Profesor();
        // Creacion de objeto de tipo Estudiante
        Estudiante unEstudiante = new Estudiante();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (rdbProfesor.Checked)
            {
                
                // Capturar datos del Profesor
                unProfesor.Nombre = txtNombre.Text;
                unProfesor.Sueldo = double.Parse(txtSueldo.Text);
            }
            if (rdbEstudiante.Checked)
            {
                
                // Capturar Datos del Estudiante
                unEstudiante.Nombre = txtNombre.Text;
                unEstudiante.Calificacion = int.Parse(txtCalificacion.Text);
            }
            txtNombre.Clear();
            txtSueldo.Clear();
            txtCalificacion.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rdbProfesor.Checked)
            {
                MessageBox.Show($"Nombre: {unProfesor.Nombre}\nSueldo: {unProfesor.Sueldo}\n{unProfesor.Asistir()}\n{unProfesor.Ensenar()}");
            }
            if (rdbEstudiante.Checked)
            {
                MessageBox.Show($"Nombre: {unEstudiante.Nombre}\nCalificacion: {unEstudiante.Calificacion}\n{unEstudiante.Asistir()}\n{unEstudiante.Estudiar()}");
            }
        }

        private void rdbProfesor_CheckedChanged(object sender, EventArgs e)
        {
            txtCalificacion.Enabled = false;
            txtSueldo.Enabled = true;
        }

        private void rdbEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            txtCalificacion.Enabled = true;
            txtSueldo.Enabled = false;
        }
    }
}
