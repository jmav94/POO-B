using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3._1
{
    class Publicacion
    {
        private string _strTitulo;

        public string Titulo
        {
            get { return _strTitulo; }
            set { _strTitulo = value; }
        }
        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }
    }
}
