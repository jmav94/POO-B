using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica_4._1.Clases;

namespace Practica_4._1
{
    public partial class frm4 : Form
    {
        Ahorros CtaAhorros;
        Cheques CtaCheques;
        Cuenta cta;
        
        public frm4()
        {
            InitializeComponent();
        }

        private void rbAhorros_CheckedChanged(object sender, EventArgs e)
        {
            dtpFecheVencimiento.Enabled = true;
            txtPorcentajeInteres.Enabled = true;
            txtComisionChequera.Enabled = false;
            dtpFecha.Enabled = true;
        }

        private void rbCheques_CheckedChanged(object sender, EventArgs e)
        {
            dtpFecheVencimiento.Enabled = false;
            txtPorcentajeInteres.Enabled = false;
            txtComisionChequera.Enabled = true;
            dtpFecha.Enabled = false;
        }

        private void btnCrearCta_Click(object sender, EventArgs e)
        {
            if (rbAhorros.Checked)
            {
                CtaAhorros = new Ahorros();
                CtaAhorros.Numero = int.Parse(txtNumCta.Text);
                CtaAhorros.Nombre = txtNomCta.Text;
                CtaAhorros.Saldo = double.Parse(txtSaldoCta.Text);
                CtaAhorros.FechaVencimiento = dtpFecheVencimiento.Value;
                CtaAhorros.PorcentajeInteres = int.Parse(txtPorcentajeInteres.Text);
                MessageBox.Show("Cuenta de ahorros creada correctamente");
            }
            if (rbCheques.Checked)
            {
                CtaCheques = new Cheques();
                CtaCheques.Numero = int.Parse(txtNumCta.Text);
                CtaCheques.Nombre = txtNomCta.Text;
                CtaCheques.Saldo = double.Parse(txtSaldoCta.Text);
                CtaCheques.ComisionChequera = int.Parse(txtComisionChequera.Text);
                MessageBox.Show("Cuenta de cheques creada correctamente");
            }
        }

        private void frm4_Load(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (rbAhorros.Checked)
            {
                double dblSaldo = CtaAhorros.Depositar(double.Parse(txtCantidad.Text));
                dblSaldo = CtaAhorros.DepositarIntereses(dtpFecha.Value);
                MessageBox.Show($"Deposito efectuado correctamente \nSu nuevo saldo es de {CtaAhorros.Saldo.ToString("C")}");
                
            }
            if (rbCheques.Checked)
            {
                MessageBox.Show($"Deposito efectuado correctamente \nSu nuevo saldo es de {CtaCheques.Depositar(double.Parse(txtCantidad.Text)).ToString("C")}");
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (rbAhorros.Checked)
            {
                if (CtaAhorros.Saldo < double.Parse(txtCantidad.Text))
                {
                    MessageBox.Show("No se pudo realizar el retiro, debido a que no cuenta con saldo suficiente.");
                }
                else
                {
                    MessageBox.Show($"Deposito efecutado correctamente su saldo actual es de {CtaAhorros.Retirar(double.Parse(txtCantidad.Text))}");
                }
            }
            if (rbCheques.Checked)
            {
                if (CtaCheques.Saldo < double.Parse(txtCantidad.Text))
                {
                    MessageBox.Show($"Retiro efectuado pero consaldo insuficienta, susaldo actual con intereses es de : {CtaCheques.SaldoInsuficiente(double.Parse(txtCantidad.Text))}");
                    
                }
                else
                {
                    MessageBox.Show($"Retiro Efectuado correctamente, su saldo actual es de {CtaCheques.Retirar(double.Parse(txtCantidad.Text))}");
                }
                
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rbAhorros.Checked)
            {
                MessageBox.Show(CtaAhorros.ToString());
            }
            if (rbCheques.Checked)
            {
                MessageBox.Show(CtaCheques.ToString());
            }
        }
    }
}
