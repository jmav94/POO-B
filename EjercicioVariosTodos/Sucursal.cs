using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVariosTodos
{
    class Sucursal
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        List<Empleado> ListaEmpleados = new List<Empleado>();
        public void InsertarEmpleado(Empleado e)
        {
            ListaEmpleados.Add(e);
        }
        ~Sucursal(){
            ListaEmpleados.Clear();
        }
        public IEnumerator<Empleado> GetEnumerator()
        {
            return ListaEmpleados.GetEnumerator();
        }
        public override string ToString()
        {
            return Nombre;
        }
        public int ContarEmpleados()
        {
            return ListaEmpleados.Count;
        }
        public double SumarSueldos()
        {
            double suma = 0.0;
            foreach (Empleado empleado in ListaEmpleados)
            {
                // Acumulandolos sueldos de cada empleado.
                suma += empleado.Sueldo;
            }
            return suma;
        }
        public Empleado CalcularEmpleadoMayor()
        {
            Empleado empleadoSueldoMayor = new Empleado();
            empleadoSueldoMayor.Sueldo = 0.0;
            foreach (Empleado empleado in ListaEmpleados)
            {
                if (empleado.Sueldo > empleadoSueldoMayor.Sueldo)
                {
                    empleadoSueldoMayor = empleado;
                }
            }
            return empleadoSueldoMayor;
        }

    }
}
