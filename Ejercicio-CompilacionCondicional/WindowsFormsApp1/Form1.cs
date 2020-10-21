#define GenerarEmpleadosAleatorios

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
#if GenerarEmpleadosAleatorios
            Random rdmNumeroAleatorio = new Random();
            const int CANTIDADEMPLEADOS = 50;
            const int LONGITUDNOMBRE = 25;
            const int SUELDOMAXIMO = 1000000;
            for (int i = 0; i < CANTIDADEMPLEADOS; i++)
            {
                Empleado empleado = new Empleado();
                empleado.Numero = rdmNumeroAleatorio.Next(CANTIDADEMPLEADOS);
                empleado.Nombre = Guid.NewGuid().ToString().Substring(0, LONGITUDNOMBRE);
                empleado.Sueldo = rdmNumeroAleatorio.NextDouble() * SUELDOMAXIMO;

                dgEmpleados.Rows.Add(empleado.Numero,empleado.Nombre,empleado.Sueldo);
            }
#endif
        }
    }
    class Empleado
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private double sueldo;

        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

    }
}
