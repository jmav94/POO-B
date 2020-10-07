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
    public partial class frmEj1 : Form
    {
        Libro unLibro;
        CD unCD;
        //Publicacion unaPublicacion = new Publicacion();
        public frmEj1()
        {
            InitializeComponent();
        }

        private void rdbLibro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLibro.Checked)
            {
                txtPaginas.Enabled = true;
                txtTiempo.Enabled = false;
                lbVentasCD.Visible = false;
                lbVentasLibro.Visible = true;
            }
        }

        private void rdbAudio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAudio.Checked)
            {
                txtPaginas.Enabled = false;
                txtTiempo.Enabled = true;
                lbVentasCD.Visible = true;
                lbVentasLibro.Visible = false;
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (rdbLibro.Checked)
            {
                unLibro = new Libro();
                unLibro.Titulo = txtTitulo.Text;
                unLibro.Precio = double.Parse(txtPrecio.Text);
                unLibro.Paginas = int.Parse(txtPaginas.Text);
            }
            if (rdbAudio.Checked)
            {
                unCD = new CD();
                unCD.Titulo = txtTitulo.Text;
                unCD.Precio = double.Parse(txtPrecio.Text);
                unCD.Tiempo = double.Parse(txtTiempo.Text);
            }
            foreach (Control x in gpbDatos.Controls)
                if (x is TextBox)
                    x.Text ="";
        }

        private void frmEj1_Load(object sender, EventArgs e)
        {
            txtPaginas.Enabled = false;
            txtTiempo.Enabled = false;
            lbVentasCD.Visible = false;
            lbVentasLibro.Visible = false;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rdbLibro.Checked)
            {
                for (int i = 0; i < 3; i++)
                {
                    unLibro[i] = double.Parse(lbVentasLibro.Items[i].ToString());
                }
                MessageBox.Show(unLibro.ToString(), "Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbAudio.Checked)
            {
                for (int i = 0; i < 3; i++)
                {
                    unCD[i] = double.Parse(lbVentasCD.Items[i].ToString());
                }
                MessageBox.Show(unCD.ToString(),"CD", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapturarVenta_Click(object sender, EventArgs e)
        {
            if (rdbLibro.Checked)
            {
                lbVentasLibro.Items.Add(txtVenta.Text);
            }
            if (rdbAudio.Checked)
            {
                lbVentasCD.Items.Add(txtVenta.Text);
            }
        }
    }
}
