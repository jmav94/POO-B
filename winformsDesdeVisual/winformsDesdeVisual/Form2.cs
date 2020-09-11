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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Cierra la forma
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '*';
        }
    }
}
