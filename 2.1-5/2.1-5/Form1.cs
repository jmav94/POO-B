using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rdbFecha1.Checked)
            {
                Fecha unaFecha;
                if (txtDia.Text == "" || txtMes.Text == "" || txtAnio.Text == "")
                {
                    unaFecha = new Fecha();
                    MessageBox.Show(unaFecha.ToString());
                    MessageBox.Show(unaFecha.MesEnLetras());
                }
                else
                {
                    unaFecha = new Fecha( int.Parse(txtDia.Text),int.Parse(txtMes.Text),int.Parse(txtAnio.Text));
                    MessageBox.Show(unaFecha.ToString());
                    MessageBox.Show(unaFecha.MesEnLetras(int.Parse(txtMes.Text)));
                }
            }
            if (rdbFecha2.Checked)
            {
                Fecha otraFecha;
                if (txtDia.Text == "" || txtMes.Text == "" || txtAnio.Text == "")
                {
                    otraFecha = new Fecha();
                    MessageBox.Show(otraFecha.ToString());
                    MessageBox.Show(otraFecha.MesEnLetras());
                }
                else
                {
                    otraFecha = new Fecha(int.Parse(txtDia.Text), int.Parse(txtMes.Text), int.Parse(txtAnio.Text));
                    MessageBox.Show(otraFecha.ToString());
                    MessageBox.Show(otraFecha.MesEnLetras(int.Parse(txtMes.Text)));
                }
            }
        }
    }
}
