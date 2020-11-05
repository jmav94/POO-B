using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1.Clases
{
    class Rectangulo: Figura
    {
        private double _dblLaredo;

        public double Largo
        {
            get { return _dblLaredo; }
            set { _dblLaredo = value; }
        }
        private double _dblAncho;

        public double Ancho
        {
            get { return _dblAncho; }
            set { _dblAncho = value; }
        }
        public override double CalcularArea()
        {
            // formula: base por altura
            return Ancho * Largo;
        }
    }
}
