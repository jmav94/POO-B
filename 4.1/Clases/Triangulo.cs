using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1.Clases
{
    class Triangulo: Figura
    {
        private double _dblAultura;

        public double Altura
        {
            get { return _dblAultura; }
            set { _dblAultura = value; }
        }
        private double _dblAncho;

        public double Ancho
        {
            get { return _dblAncho; }
            set { _dblAncho = value; }
        }
        public override double CalcularArea()
        {
            // formula : base * altura / 2
            return (Ancho * Altura) / 2;
        }
    }
}
