using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3._1
{
    public partial class frmEj5 : Form
    {
        Auto auto;
        Camioneta camioneta;
        public frmEj5()
        {
            InitializeComponent();
        }

        private void rdbAuto_CheckedChanged(object sender, EventArgs e)
        {
            txtCantidad.Enabled = true;
            txtCapacidad.Enabled = false;
            txtEjes.Enabled = false;
            txtRodadas.Enabled = false;
        }

        private void rdbCamioneta_CheckedChanged(object sender, EventArgs e)
        {
            txtCantidad.Enabled = false;
            txtCapacidad.Enabled = true;
            txtEjes.Enabled = true;
            txtRodadas.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (rdbAuto.Checked)
            {
                auto = new Auto(int.Parse(txtCantidad.Text),txtNumSerie.Text,txtMarca.Text,int.Parse(txtAnio.Text),double.Parse(txtPrecio.Text));
            }
            if (rdbCamioneta.Checked)
            {
                camioneta = new Camioneta(double.Parse(txtCapacidad.Text), int.Parse(txtEjes.Text), int.Parse(txtRodadas.Text), txtNumSerie.Text, txtMarca.Text, int.Parse(txtAnio.Text), double.Parse(txtPrecio.Text));
            }
            MessageBox.Show("Los datos fueron capturados correctamente", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }
        public void clear()
        {
            foreach (Control x in gbDatos.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rdbAuto.Checked)
            {
                MessageBox.Show(auto.ToString(), "Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbCamioneta.Checked)
            {
                MessageBox.Show(camioneta.ToString(), "Camioneta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
