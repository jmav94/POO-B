using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1.Clases
{
    class Cheques: Cuenta
    {
        private int _intComisionChequera;

        public int ComisionChequera
        {
            get { return _intComisionChequera; }
            set { _intComisionChequera = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nComision por uso de chequera: {ComisionChequera}";
        }
        public double SaldoInsuficiente(double dblCantidad)
        {
            Saldo -= dblCantidad -(Saldo * ComisionChequera / 100);
            return Saldo;
        }

    }
}
