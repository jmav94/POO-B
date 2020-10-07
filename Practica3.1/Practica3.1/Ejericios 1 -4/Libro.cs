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
            return $"{base.ToString()} \nNum. Paginas: {Paginas} \nVentas mes 1: {this[0]} \nVentas mes 2: {this[1]} \nVentas mes 3: {this[2]}";
            //return base.ToString() +"\nNum. Paginas: "+ Paginas;
        }
    }
}
