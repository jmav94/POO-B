using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformsDesdeVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgEmpleados.Columns.Add("Nombre", "Nombre");
            dgEmpleados.Columns.Add("Sueldo", "Sueldo");
            dgEmpleados.Columns["Sueldo"].DefaultCellStyle.Format = "C";
            // Esta parte se encarga de crear renglones desde que se carga la forma
            dgEmpleados.Rows.Add(1, "Juan", 100.00);
            dgEmpleados.Rows.Add(2, "Abraham", 200.00);
            dgEmpleados.Rows.Add(3, "Rodrigo", 300.00);
            dgEmpleados.Rows.Add(4, "Gabriela", 400.00);
            dgEmpleados.Rows.Add(5, "Andrea", 500.00);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtDato.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (chkInt.Checked)
            {
                int Dato;
                Dato = int.Parse(txtDato.Text);
                MessageBox.Show($"su dato a sido transformado a {Dato.GetType()} y su valor es : {Dato}");
            }
            if (chkDouble.Checked)
            {
                double Dato;
                Dato = double.Parse(txtDato.Text);
                MessageBox.Show($"su dato a sido transformado a {Dato.GetType()} y su valor es : {Dato}");
            }
            if (chkBool.Checked)
            {
                bool Dato;
                Dato = bool.Parse(txtDato.Text);
                MessageBox.Show($"su dato a sido transformado a {Dato.GetType()} y su valor es : {Dato}");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lsbPlatillos.Items.Add(txtPlatillo.Text);
            txtPlatillo.Clear();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            string Salida = "";
            /*for (int i = 0; i < lsbPlatillos.Items.Count; i++)
            {
                if (Salida == "")
                {
                    Salida = $"{lsbPlatillos.Items[i]}";
                }
                else
                {
                    Salida = $"{Salida},  {lsbPlatillos.Items[i]}";
                }
            }*/
            

            foreach (var item in lsbPlatillos.Items)
            {
                if (Salida == "")
                {
                    Salida = $"{item}";
                }
                else
                {
                    Salida = $"{Salida},  {item}";
                }
            }
            MessageBox.Show($"Los items de su lista son los siguientes:\n{Salida}", "Recorrido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPlatillo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlatillo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                agregarPlatillo();
            }
        }
        void agregarPlatillo()
        {
            lsbPlatillos.Items.Add(txtPlatillo.Text);
            txtPlatillo.Clear();
        }

        private void txtPlatillo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAgregar_Click(this, new EventArgs());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Persona unaPersona;
            unaPersona = new Persona();
            unaPersona.Numero = int.Parse(txtNum.Text);
            unaPersona.Nombre = txtNom.Text;
            unaPersona.Sueldo = double.Parse(txtSueldo.Text);

            dgEmpleados.Rows.Add(unaPersona.Numero, unaPersona.Nombre, unaPersona.Sueldo);
            //dgEmpleados.Rows.Add(unaPersona);
        }

        private void btnRecorrerDg_Click(object sender, EventArgs e)
        {
            DateTime dtmHoraEntrada, dtmHoraSalida;
            dtmHoraEntrada = DateTime.Now;
            //int r, c;
            string salida = "";
            /*for (r = 0; r < dgEmpleados.Rows.Count; r++)
            {
                salida = salida + "\n";
                for (c = 0; c < dgEmpleados.Columns.Count; c++)
                    salida = salida + dgEmpleados[c, r].Value + "\t";
            }*/
            
            // Recorrido de datagridview con foreach
            foreach (DataGridViewRow renglon in dgEmpleados.Rows)
            {
                if (renglon.Cells["Numero"] != null)
                {
                    salida = salida += $"{renglon.Cells["Numero"].Value} , {renglon.Cells["Nombre"].Value} , {renglon.Cells["Sueldo"].Value}\n";

                    /*salida = salida += renglon.Cells["Numero"].Value + " ," + renglon.Cells["Nombre"].Value +
                        " ," + renglon.Cells["Sueldo"].Value + "\n";*/
                }

            }
            dtmHoraSalida = DateTime.Now;

            TimeSpan intervalo = dtmHoraSalida - dtmHoraEntrada;
            MessageBox.Show($"{salida}\nIntervalo de tiempo transcurrido durante el recorrido: {intervalo}");
        }

        private void txtPlatillo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregar.PerformClick();
            }
        }

        private void btnAbrirForma_Click(object sender, EventArgs e)
        {
            // Crea el objeto de la nueva forma
            Form2 miForma2 = new Form2();
            // Muestra la forma
            miForma2.Show();
        }
    }
}
