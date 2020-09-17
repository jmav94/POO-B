using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Escuela
{
    class Estudiante : Persona
    {
        private int _intCalificacion;

        public int Calificacion
        {
            get { return _intCalificacion; }
            set { _intCalificacion = value; }
        }
        public string Estudiar()
        {
            return $"{Nombre} esta estudiando";
        }

    }
}
