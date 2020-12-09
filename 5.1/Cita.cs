using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5._1
{
    class Cita
    {
        public Cita(string d, int h, int m, string desc)
        {
            Dia = d;
            Hora = h;
            Minuto = m;
            Descripcion = desc;
        }
        private string _strDia;

        public string Dia
        {
            get { return _strDia; }
            set { 
                _strDia = value;
                if (_strDia.ToLower() != "lunes" && _strDia.ToLower() != "miercoles" && _strDia.ToLower() != "viernes")
                {
                    throw new ArgumentException("No hay citas disponibles este dia");
                }
            }
        }
        private int _intHora;

        public int Hora
        {
            get { return _intHora; }
            set { 
                _intHora = value;
                if (_intHora < 0 || _intHora > 23)
                {
                    throw new ArgumentException("Hora incorrecta");
                }
            }
        }
        private int _intMinuto;

        public int Minuto
        {
            get { return _intMinuto; }
            set { _intMinuto = value;
                if (_intMinuto < 0 || _intMinuto > 59)
                {
                    throw new ArgumentException("Minuto incorrecto");
                }
            }
        }
        private string _strDescripcion;

        public string Descripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }

    }
}
