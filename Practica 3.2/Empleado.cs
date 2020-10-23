using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._2
{
    class Empleado
    {
        public Empleado()
        {
            numero = 0;
            nombre = "";
            sueldo = 0.0;
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
        private double sueldo;

        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

    }
}
