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
            }
        }

        private void rdbAudio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAudio.Checked)
            {
                txtPaginas.Enabled = false;
                txtTiempo.Enabled = true;
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
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rdbLibro.Checked)
            {
                MessageBox.Show($"Titulo: {unLibro.Titulo} \nPrecio: {unLibro.Precio} \nNum.Paginas: {unLibro.Paginas}", "Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbAudio.Checked)
            {
                MessageBox.Show($"Titulo: {unCD.Titulo} \nPrecio: {unCD.Precio} \nNum.Paginas: {unCD.Tiempo}","CD", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
