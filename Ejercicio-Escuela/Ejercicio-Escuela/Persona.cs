using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Escuela
{
    class Persona
    {
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        public string Asistir()
        {
            return $"{Nombre} asiste a la escuela";
        }

    }
}
