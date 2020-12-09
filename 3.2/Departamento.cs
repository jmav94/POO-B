using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._2
{
    class Departamento
    {
        public Departamento()
        {
            numero = 0;
            nombre = "";
            jefe = "";
            ListaEmpleados = new List<Empleado>();
        }
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
        private string  jefe;

        public string  Jefe
        {
            get { return jefe; }
            set { jefe = value; }
        }

        List<Empleado> ListaEmpleados;
        public void InsertarEmpleado(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
        }
        public IEnumerator<Empleado> GetEnumerator()
        {
            return ListaEmpleados.GetEnumerator();
        }
        ~Departamento()
        {
            ListaEmpleados.Clear();
        }
        public void EliminarEmpleado(int index)
        {
            ListaEmpleados.RemoveAt(index);
        }
    }
}
