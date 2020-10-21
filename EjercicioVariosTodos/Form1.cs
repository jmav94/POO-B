#define DatosPrueba

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioVariosTodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturarSucursal_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal();
            sucursal.Nombre = txtNombreSucursal.Text;
            sucursal.Direccion = txtDireccion.Text;

            lbSucursales.Items.Add(sucursal);
            MessageBox.Show("Sucursal capturada correctamente.");

            Limpiar();
        }
        void Limpiar()
        {
            foreach (Control control in gbSucursal.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void btnCapturarEmpleado_Click(object sender, EventArgs e)
        {
            Sucursal sucursalSelected = new Sucursal();
            sucursalSelected = SeleccionarSucursal();

            Empleado empleado = new Empleado();
            empleado.Numero = int.Parse(txtNumero.Text);
            empleado.Nombre = txtNombreEmpleado.Text;
            empleado.Sueldo = double.Parse(txtSueldo.Text);

            sucursalSelected.InsertarEmpleado(empleado);

            MostrarDatosEmpleados(sucursalSelected);

            MessageBox.Show("Nuevo empleado insertado a la sucursal");
            LimpiarTextBoxes();
        }
        void LimpiarTextBoxes()
        {
            foreach (Control control in gbEmpleado.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }


        private void lbSucursales_Click(object sender, EventArgs e)
        {
            Sucursal sucursalSelected = new Sucursal();
            sucursalSelected = (Sucursal)lbSucursales.SelectedItem;
            if (sucursalSelected is null)
            {
                MessageBox.Show("Debe seleccionar una sucursal de la lista.");
            }
            MostrarDatosEmpleados(sucursalSelected);
        }
        void MostrarDatosEmpleados(Sucursal s)
        {
            dgEmpleados.Rows.Clear();
            foreach (Empleado empleado in s)
            {
                dgEmpleados.Rows.Add(empleado.Numero,empleado.Nombre,empleado.Sueldo.ToString("C"));
            }
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgEmpleados.Columns.Add("Numero", "Numero");
            dgEmpleados.Columns.Add("Nombre", "Nombre");
            dgEmpleados.Columns.Add("Sueldo", "Sueldo");

            dgEmpleados.ReadOnly = true;
            dgEmpleados.AllowUserToAddRows = false;
            dgEmpleados.AllowUserToDeleteRows = false;
            dgEmpleados.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            dgEmpleados.Columns["Sueldo"].DefaultCellStyle.Format = "C";

#if DatosPrueba
            const int intCantidadSucursales = 10;
            const int intLongitudNombreSucursal = 25;
            const int intLongitudDireccionSucursal = 25;
            for (int i = 1; i <= intCantidadSucursales; i++)
            {
                Sucursal sucursal = new Sucursal();
                sucursal.Nombre = Guid.NewGuid().ToString().Substring(0,
                intLongitudNombreSucursal);
                sucursal.Direccion = Guid.NewGuid().ToString().Substring(0,
                intLongitudDireccionSucursal);
                lbSucursales.Items.Add(sucursal);
            }
            Random rndNumeroAleatorio = new Random();
            const int intCantidadMaximaEmpleados = 20;
            const int intLongitudNombre = 25;
            const int intSueldoMaximo = 100000;
            foreach (Sucursal sucursal in lbSucursales.Items)
            {
                for (int i = 1; i <= rndNumeroAleatorio.Next(intCantidadMaximaEmpleados); i++)
                {
                    Empleado miEmpleado = new Empleado();
                    miEmpleado.Numero = rndNumeroAleatorio.Next(intCantidadMaximaEmpleados);
                    miEmpleado.Nombre = Guid.NewGuid().ToString().Substring(0,
                    intLongitudNombre);
                    miEmpleado.Sueldo =
                    rndNumeroAleatorio.NextDouble() * intSueldoMaximo;
                    sucursal.InsertarEmpleado(miEmpleado);
                }
            }      
#endif

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal();
            sucursal = SeleccionarSucursal();
            MessageBox.Show($"Los empleados de la sucursal {sucursal.Nombre} son: {sucursal.ContarEmpleados()}");
        }

        Sucursal SeleccionarSucursal()
        {
            Sucursal sucursalSelected = new Sucursal();
            sucursalSelected = (Sucursal)lbSucursales.SelectedItem;

            if (sucursalSelected is null)
            {
                MessageBox.Show("Debe seleccionar una sucursal de la lista");
            }
            return sucursalSelected;
        }

        private void btnSumarSueldosCorporativo_Click(object sender, EventArgs e)
        {
            double sumaSuledos = 0.0;
            foreach (Sucursal sucursal in lbSucursales.Items)
            {
                sumaSuledos += sucursal.SumarSueldos();
            }
            MessageBox.Show($"La suma de los sueldos de los empelados del corporativos es de: {sumaSuledos.ToString("C")}");
        }

        private void btnEmpleadosCorporativo_Click(object sender, EventArgs e)
        {
            int sumaEmplados = 0;
            foreach (Sucursal sucursal in lbSucursales.Items)
            {
                sumaEmplados += sucursal.ContarEmpleados();
            }

            MessageBox.Show($"Los empleados del corporativo son: {sumaEmplados}");
        }

        private void btnSueldosSucursal_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal();
            sucursal = SeleccionarSucursal();
            MessageBox.Show($"La suma de los sueldos de la sucursal {sucursal.Nombre} es: {sucursal.SumarSueldos().ToString("C")}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado empleadoSueldoMayor = new Empleado();
            empleadoSueldoMayor.Sueldo = 0.0;
            foreach (Sucursal sucursal in lbSucursales.Items)
            {
                if (sucursal.CalcularEmpleadoMayor().Sueldo > empleadoSueldoMayor.Sueldo)
                {
                    empleadoSueldoMayor = sucursal.CalcularEmpleadoMayor();
                }
            }
            MessageBox.Show($"El empleado con mayor sueldo de la compañia es: {empleadoSueldoMayor.Nombre} y gana: {empleadoSueldoMayor.Sueldo.ToString("C")}");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal();
            sucursal = SeleccionarSucursal();
            MessageBox.Show($"El empleado con sueldo mayor de la sucursal {sucursal.Nombre} es: {sucursal.CalcularEmpleadoMayor().Nombre} y su sueldo es de: {sucursal.CalcularEmpleadoMayor().Sueldo.ToString("C")}");

        }

        private void btnSucursalMenorSueldo_Click(object sender, EventArgs e)
        {
            Sucursal sucursalMenorSueldo = new Sucursal();
            bool first = true;
            foreach (Sucursal sucursal in lbSucursales.Items)
            {
                if (first)
                {
                    sucursalMenorSueldo = sucursal;
                    first = false;
                }
                if (sucursal.SumarSueldos() < sucursalMenorSueldo.SumarSueldos())
                {
                    sucursalMenorSueldo = sucursal;
                }
            }
            MessageBox.Show($"La sucursal con sueldo menor es: {sucursalMenorSueldo.Nombre} y la suma de sus sueldos es de: {sucursalMenorSueldo.SumarSueldos().ToString("C")}");
        }

        private void btnSucursalMenosEmpleados_Click(object sender, EventArgs e)
        {
            Sucursal sucursalMenosEmpleados = new Sucursal();
            bool first = true;
            foreach (Sucursal sucursal in lbSucursales.Items)
            {
                if (first)
                {
                    sucursalMenosEmpleados = sucursal;
                    first = false;
                }
                if (sucursal.ContarEmpleados() < sucursalMenosEmpleados.ContarEmpleados())
                {
                    sucursalMenosEmpleados = sucursal;
                }
            }
            MessageBox.Show($"La sucursal con menos empleados del corporativo es {sucursalMenosEmpleados.Nombre} y solo tiene {sucursalMenosEmpleados.ContarEmpleados()} empleados.");
        }

        private void btnPromedioSueldoCorporativo_Click(object sender, EventArgs e)
        {
            double sueldoPromedioCorporativo = 0.0;
            List<double> sueldosPromedioSucursales = new List<double>();
            foreach (Sucursal sucursal in lbSucursales.Items)
            {
                double sueldoPromedioSucursal = 0.0;
                foreach (Empleado empleado in sucursal)
                {
                    sueldoPromedioSucursal += empleado.Sueldo;
                }
                sueldoPromedioSucursal /= sucursal.ContarEmpleados();
                sueldosPromedioSucursales.Add(sueldoPromedioSucursal);
            }
            foreach (double sueldo in sueldosPromedioSucursales)
            {
                sueldoPromedioCorporativo += sueldo;
            }
            sueldoPromedioCorporativo /= lbSucursales.Items.Count;
            
            MessageBox.Show($"El sueldo promedio de los empleados del Corporativo es de {sueldoPromedioCorporativo.ToString("C")}.");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            double promedioEmpleadosPorSucursal =0.0;
            foreach (Sucursal sucursal in lbSucursales.Items)
            {
                promedioEmpleadosPorSucursal += sucursal.ContarEmpleados();
            }
            promedioEmpleadosPorSucursal /= lbSucursales.Items.Count;
            MessageBox.Show($"El promedio de empleados por sucursal en el corporativo es de {promedioEmpleadosPorSucursal} empleados.");
        }
    }
}
