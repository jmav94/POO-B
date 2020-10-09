using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3._1
{
    class Vehiculo
    {
        public Vehiculo(string strNumSerie, string strMarca, int intAnio, double dblPrecio)
        {
            _strNumSerie = strNumSerie;
            _strMarca = strMarca;
            _intAnio = intAnio;
            _dblPrecio = dblPrecio;
        }
        private string _strNumSerie;

        public string NumSerie
        {
            get { return _strNumSerie; }
            set { _strNumSerie = value; }
        }
        private string _strMarca;

        public string Marca
        {
            get { return _strMarca; }
            set { _strMarca = value; }
        }
        private int _intAnio;

        public int Anio
        {
            get { return _intAnio; }
            set { _intAnio = value; }
        }
        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }
        public override string ToString()
        {
            return $"Numero de serie: {NumSerie}\nMarca: {Marca}\nAño: {Anio}\nPrecio: {Precio}\n";
        }

    }
}
