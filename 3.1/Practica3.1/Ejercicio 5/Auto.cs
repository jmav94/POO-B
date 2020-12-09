using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3._1
{
    class Auto: Vehiculo
    {
        public Auto(int intCantidadPasajeros, string strNumSerie, string strMarca, int intAnio, double dblPrecio):base(strNumSerie, strMarca, intAnio, dblPrecio)
        {
            _intCantidadPasajero = intCantidadPasajeros;
        }
        private int _intCantidadPasajero;

        public int CantidadPasajeros
        {
            get { return _intCantidadPasajero; }
            set { _intCantidadPasajero = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()} Cantidad de pasajeros: {CantidadPasajeros}";
            //return base.ToString() + "Cantidad de pasajeros: " + CantidadPasajeros;
        }

    }
}
