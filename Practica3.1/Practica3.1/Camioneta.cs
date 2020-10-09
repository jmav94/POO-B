using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3._1
{
    class Camioneta: Vehiculo
    {
        public Camioneta(double dblCapacidadCarga, int intEjes, int intRodadas, string strNumSerie, string strMarca, int intAnio, double dblPrecio): base(strNumSerie, strMarca, intAnio, dblPrecio)
        {
            _dblCapacidadCarga = dblCapacidadCarga;
            _intEjes = intEjes;
            _intRodadas = intRodadas;
        }
        private double _dblCapacidadCarga;

        public double CapacidadCarga
        {
            get { return _dblCapacidadCarga; }
            set { _dblCapacidadCarga = value; }
        }
        private int _intEjes;

        public int Ejes
        {
            get { return _intEjes; }
            set { _intEjes = value; }
        }
        private int _intRodadas;

        public int MyProperty
        {
            get { return _intRodadas; }
            set { _intRodadas = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()} Capacidad de carga: {CapacidadCarga} Kgs. \nEjes: {_intEjes}\nRodadas: {_intRodadas}";
        }

    }
}
