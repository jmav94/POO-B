using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3._1
{
    abstract class Publicacion
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
        public override string ToString()
        {
            return $"Titulo: {Titulo} \nPrecio: {Precio} \nVentas mes 1: {this[0]} \nVentas mes 2: {this[1]} \nVentas mes 3: {this[2]}";
        }
        double[] ventas = new double[3];
        public double this[int intCelda]
        {
            get { return ventas[intCelda]; }
            set { ventas[intCelda] = value; }
        }
    }
}
