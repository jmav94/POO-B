using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioMetodoClaseBase
{
    public partial class Form1 : Form
    {
        Cliente unCliente;
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpFechaActual.Value = DateTime.Now;
            dtpFechaActual.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente unCliente = new Cliente(txtNombre.Text,dtpFechaNacimiento.Value, double.Parse(txtLimite.Text));
            
            MessageBox.Show(unCliente.ToString());
            //Console.WriteLine(unCliente);
        }
    }
}
