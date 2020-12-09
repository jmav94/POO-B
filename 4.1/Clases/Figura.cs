using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1
{
    abstract class Figura
    {
        public abstract double CalcularArea();
        //public abstract string MostrarDatos();
        //public new abstract string ToString();
    }
    /*class Circunferencia: Figura
    {
        private double _dblRadio;

        public double Radio
        {
            get { return _dblRadio; }
            set { _dblRadio = value; }
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio,2);
        }
        public override string MostrarDatos()
        {
            return Radio.ToString();
        }
        public override string ToString()
        {
            return $"El area de tu circunferencia es de {CalcularArea()}";
        }
    }
    class Cuadrado : Figura
    {
        private double _dblLado;

        public double Lado
        {
            get { return _dblLado; }
            set { _dblLado = value; }
        }

        public override double CalcularArea()
        {
            return Math.Pow(Lado, 2);
        }

        public override string MostrarDatos()
        {
            return Lado.ToString();
        }

        public override string ToString()
        {
            return $"El area de su cuadrado es de {CalcularArea()}";
        }
    }*/
    
}
