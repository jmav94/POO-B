using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1.Clases
{
    class Ahorros: Cuenta
    {
        private DateTime _dtmFechaVencimiento;

        public DateTime FechaVencimiento
        {
            get { return _dtmFechaVencimiento; }
            set { _dtmFechaVencimiento = value; }
        }
        private int _intPorcentajeInteres;

        public int PorcentajeInteres
        {
            get { return _intPorcentajeInteres; }
            set { _intPorcentajeInteres = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nFecha de vencimiento: {FechaVencimiento}\nPorcentaje de interes: {PorcentajeInteres}";
        }
        public double DepositarIntereses(DateTime dtmFecha)
        {
            if (FechaVencimiento < dtmFecha )
            {
                Saldo -= Saldo * (PorcentajeInteres / 100);
                //Saldo = Saldo - (Saldo * (PorcentajeInteres / 100));
            }
            return Saldo;
        }

    }
}
