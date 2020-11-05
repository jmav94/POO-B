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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEjemplo form = new FrmEjemplo();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmEjemploAbtractos form = new FrmEjemploAbtractos();
            form.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Frm1 form = new Frm1();
            form.Show();
        }
    }
}
