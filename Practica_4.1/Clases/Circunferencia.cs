using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1.Clases
{
    class Circunferencia: Figura
    {
        private double _dblRadio;

        public double Radio
        {
            get { return _dblRadio; }
            set { _dblRadio = value; }
        }
        public override double CalcularArea()
        {
            // formula 
            return Math.PI * Math.Pow(Radio,2);
        }
    }
}
