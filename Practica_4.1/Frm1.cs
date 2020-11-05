using Practica_4._1.Clases;
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
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void rbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRectangulo.Checked)
            {
                txtLargo.Enabled = true;
                txtAncho.Enabled = true;
                txtRadio.Enabled = false;
                txtAltura.Enabled = false;
            }
        }

        private void rbCircunferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCircunferencia.Checked)
            {
                txtLargo.Enabled = false;
                txtAncho.Enabled = false;
                txtRadio.Enabled = true;
                txtAltura.Enabled = false;
            }
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTriangulo.Checked)
            {
                txtLargo.Enabled = false;
                txtAncho.Enabled = true;
                txtRadio.Enabled = false;
                txtAltura.Enabled = true;
            }
        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            Circunferencia C;
            Rectangulo R;
            Triangulo T;

            if (rbCircunferencia.Checked)
            {
                
                
                C = new Circunferencia();
                C.Radio = double.Parse(txtRadio.Text);
                MessageBox.Show($"El area de la circunferencia es de {C.CalcularArea()}");
                
            }
            if (rbRectangulo.Checked)
            {
                R = new Rectangulo();
                R.Ancho = double.Parse(txtAncho.Text);
                R.Largo = double.Parse(txtLargo.Text);
                MessageBox.Show($"El area del rectangulo es de {R.CalcularArea()}");
            }
            if (rbTriangulo.Checked)
            {
                T = new Triangulo();
                T.Altura = double.Parse(txtAltura.Text);
                T.Ancho = double.Parse(txtAncho.Text);
                MessageBox.Show($"El area del triangulo es de {T.CalcularArea()}");
            }
            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm1_Load(object sender, EventArgs e)
        {

        }
    }
}
