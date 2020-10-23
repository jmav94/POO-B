﻿using System;
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
    public partial class frmE1 : Form
    {
        Empresa empresa;
        DataGridViewRow currentRow;

        public frmE1()
        {
            InitializeComponent();
        }

        private void frmE1_Load(object sender, EventArgs e)
        {
            dgDepartamentos.Columns.Add("Numero", "Numero");
            dgDepartamentos.Columns.Add("Nombre", "Nombre");
            dgDepartamentos.Columns.Add("Jefe", "Jefe");

            dgDepartamentos.ReadOnly = true;
            dgDepartamentos.AllowUserToAddRows = false;
            dgDepartamentos.AllowUserToDeleteRows = false;
            dgDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgEmpleados.Columns.Add("Numero", "Numero");
            dgEmpleados.Columns.Add("Nombre", "Nombre");
            dgEmpleados.Columns.Add("sueldo", "Sueldo");

            dgEmpleados.ReadOnly = true;
            dgEmpleados.AllowUserToAddRows = false;
            dgEmpleados.AllowUserToDeleteRows = false;
            dgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEmpleados.Columns["Sueldo"].DefaultCellStyle.Format = "C";

        }

        private void btnCapturarEmpresa_Click(object sender, EventArgs e)
        {
            if (empresa is null)
            {
                empresa = new Empresa();
                MessageBox.Show("Empresa creada correctamente","Captura Exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                empresa.RFC = txtRfc.Text;
                empresa.RazonSocial = txtRazonSocial.Text;
                empresa.Gerente = txtGerente.Text;
                MessageBox.Show("Datos modificados correctemente", "Captura Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void gbEmpresa_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertarDepartamento_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento();
            departamento.Numero = int.Parse(txtNumero.Text);
            departamento.Nombre = txtNombre.Text;
            departamento.Jefe = txtJefe.Text;
            empresa.InsertarDepartamento(departamento);
            MessageBox.Show("Departamento insertado correctemente", "Captura Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarDepartamentos();
            Limpiar();

        }
        public void Limpiar()
        {
            /*foreach (Control control in gbEmpresa.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }*/
            foreach (Control control1 in gbDepartamento.Controls)
            {
                if (control1 is TextBox)
                {
                    control1.Text = "";
                }
            }
        }
        public void MostrarDepartamentos()
        {
            dgDepartamentos.Rows.Clear();
            foreach (Departamento departamento in empresa)
            {
                dgDepartamentos.Rows.Add(departamento.Numero,departamento.Nombre,departamento.Jefe);
                // Buscar como definir un tipo en un bloque de codigo.
            }
        }

        private void btnEliminarDepartamento_Click(object sender, EventArgs e)
        {
            currentRow = dgDepartamentos.CurrentRow;
            if (currentRow is null)
            {
                MessageBox.Show("Seleccione un departamento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                empresa.EliminarDepartamento(currentRow.Index);
                // buscar como encontar un objeto en la lista y eliminarlo
                MostrarDepartamentos();
            }
            if (dgDepartamentos.Rows is null)
            {
                empresa = null; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Numero = int.Parse(txtNumeroEmpleado.Text);
            empleado.Nombre = txtNombreEmpleado.Text;
            empleado.Sueldo = double.Parse(txtSueldoEmpleado.Text);
            Departamento departamentoSelected = SeleccionarDepartamento();
            departamentoSelected.InsertarEmpleado(empleado);
            MessageBox.Show("Empleado insertado correctemente", "Captura Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MostrarEmpleados(departamentoSelected);

            foreach (Control control in gbEmpleados.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }

        }
        void MostrarEmpleados(Departamento departamento)
        {
            dgEmpleados.Rows.Clear();
            foreach (Empleado empleado in departamento)
            {
                dgEmpleados.Rows.Add(empleado.Numero,empleado.Nombre,empleado.Sueldo);
            }
        }
        Departamento SeleccionarDepartamento()
        {
            Departamento departamentoSelected = new Departamento();
            departamentoSelected.Numero = (int)dgDepartamentos.CurrentRow.Cells[0].Value;

            foreach (Departamento departamento in empresa)
            {
                if (departamento.Numero == departamentoSelected.Numero)
                {
                    departamentoSelected = departamento;
                    break;
                }
            }
            return departamentoSelected;
        }

        private void dgDepartamentos_Click(object sender, EventArgs e)
        {
            Departamento departamento = SeleccionarDepartamento();
            if (departamento is null)
            {
                MessageBox.Show("Seleccione un departamento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarEmpleados(departamento);
        }

        private void dgDepartamentos_SelectionChanged(object sender, EventArgs e)
        {
            Departamento departamento = SeleccionarDepartamento();
            if (departamento is null)
            {
                MessageBox.Show("Seleccione un departamento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarEmpleados(departamento);
        }

        private void btnElminarEmpleado_Click(object sender, EventArgs e)
        {
            currentRow = dgDepartamentos.CurrentRow;
            Departamento departamento = SeleccionarDepartamento();
            departamento.EliminarEmpleado(currentRow.Index);
        }
    }
}
