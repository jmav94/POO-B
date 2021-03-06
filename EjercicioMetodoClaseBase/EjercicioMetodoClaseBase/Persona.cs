﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMetodoClaseBase
{
    class Persona
    {
        // Metodo constructor que recibe parametros y los asgina a los atributos. 
        // Esto es que desde la creacion del objeto le damos valor a sus atributos.
        public Persona(string strNombre, DateTime dtmFechaNacimiento)
        {
            _strNombre = strNombre;
            _dtmFechaNacimiento = dtmFechaNacimiento;
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private DateTime _dtmFechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }
        public int CalcularEdad()
        {
            int intEdad;
            TimeSpan intervalo;
            intervalo = DateTime.Now - FechaNacimiento;
            intEdad = (int)(intervalo.Days / 365.25);
            return intEdad;
        }
    }
}
