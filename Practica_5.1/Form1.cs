using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string dia = txtDia.Text;
            int hora = int.Parse(txtHora.Text);
            int minuto = int.Parse(txtMinuto.Text);
            string descripcion = txtDescripcion.Text;
            Cita c = new Cita("lunes",1,1,"Desc");
            try
            {
                Cita cita = new Cita(dia, hora, minuto, descripcion);
                c = cita;
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message);
            }
            MessageBox.Show($"Dia: {c.Dia}\nHora: {c.Hora}:{c.Minuto}\nDescripcion: {c.Descripcion}");

            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = null;
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
