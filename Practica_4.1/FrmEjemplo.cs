using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4._1
{
    public partial class FrmEjemplo : Form
    {
        public FrmEjemplo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Empleado empleado;

            empleado = new Empleado();
            empleado.HorasTrabajadas = int.Parse(txtHorasTrabajadas.Text);
            empleado.SueldoPorHora = double.Parse(txtSueldoPorHora.Text);
            MessageBox.Show($"El sueldo del empleado es de {empleado.CalcularSalario()}");

            empleado = new EmpleadoSinHorasExtras();
            empleado.HorasTrabajadas = int.Parse(txtHorasTrabajadas.Text);
            empleado.SueldoPorHora = double.Parse(txtSueldoPorHora.Text);
            MessageBox.Show($"El sueldo del empleado sin horas extras es de {empleado.CalcularSalario()}");

            empleado = new EmpleadoConHorasDobles();
            empleado.HorasTrabajadas = int.Parse(txtHorasTrabajadas.Text);
            empleado.SueldoPorHora = double.Parse(txtSueldoPorHora.Text);
            MessageBox.Show($"El sueldo del empleado con horas dobles es de {empleado.CalcularSalario()}");

            empleado = new EmpleadoConHorasTriples();
            empleado.HorasTrabajadas = int.Parse(txtHorasTrabajadas.Text);
            empleado.SueldoPorHora = double.Parse(txtSueldoPorHora.Text);
            MessageBox.Show($"El sueldo del empleado con horas triples es de {empleado.CalcularSalario()}");


        }

        private void FrmEjemplo_Load(object sender, EventArgs e)
        {

        }
    }
}
