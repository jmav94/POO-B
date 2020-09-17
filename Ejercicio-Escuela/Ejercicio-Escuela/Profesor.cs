using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Escuela
{
    class Profesor : Persona
    {
        private double _dblSueldo;

        public double Sueldo
        {
            get { return _dblSueldo; }
            set { _dblSueldo = value; }
        }
        public string Ensenar()
        {
            return $"{Nombre} esta enseñando";
        }

    }
}
