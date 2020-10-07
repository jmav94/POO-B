using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEj_5
{
    public partial class Form1 : Form
    {
        Fecha unaFecha, otraFecha;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rdbFecha1.Checked)
            {
                unaFecha = new Fecha();
                MessageBox.Show($"{unaFecha.ToString()}\n{unaFecha.MesEnLetras()}" );
            }
            if (rdbFecha2.Checked)
            {
                int dia, mes, anio;
                if (txtDia.Text == "" || txtMes.Text == "" || txtAnio.Text == "")
                {
                    MessageBox.Show("No deje los campos en blanco");
                }
                else
                {
                    dia = int.Parse(txtDia.Text);
                    mes = int.Parse(txtMes.Text);
                    anio = int.Parse(txtAnio.Text);                    
                    otraFecha = new Fecha(dia, mes, anio);
                    MessageBox.Show(otraFecha.ToString());
                    MessageBox.Show(otraFecha.MesEnLetras());                           
                }
            }
        }

        private void rdbFecha1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFecha1.Checked)
            {
                txtDia.Enabled = false;
                txtMes.Enabled = false;
                txtAnio.Enabled = false;
            }
        }

        private void rdbFecha2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFecha2.Checked)
            {
                txtDia.Enabled = true;
                txtMes.Enabled = true;
                txtAnio.Enabled = true;
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            otraFecha.ModificarFecha(int.Parse(txtDia.Text), int.Parse(txtMes.Text), int.Parse(txtAnio.Text));
            MessageBox.Show(otraFecha.ToString());
            MessageBox.Show(otraFecha.MesEnLetras());
        }
    }
}
