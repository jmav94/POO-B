﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformsDesdeVisual
{
    class Persona   
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
