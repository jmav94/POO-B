using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3._1
{
    class Libro: Publicacion
    {
        private int _intPaginas;

        public int Paginas
        {
            get { return _intPaginas; }
            set { _intPaginas = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()} \nNum. Paginas: {Paginas}";
            //return base.ToString() +"\nNum. Paginas: "+ Paginas;
        }
    }
}
