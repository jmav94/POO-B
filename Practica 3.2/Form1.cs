using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEj1_Click(object sender, EventArgs e)
        {
            frmE1 frm = new frmE1();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Close();
            Application.Exit();
        }
    }
}
