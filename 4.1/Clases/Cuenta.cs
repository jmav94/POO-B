using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1.Clases
{
    class Cuenta
    {
        private int _intNumero;

        public int Numero
        {
            get { return _intNumero; }
            set { _intNumero = value; }
        }
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private double _dblSaldo;

        public double Saldo
        {
            get { return _dblSaldo; }
            set { _dblSaldo = value; }
        }
        public override string ToString()
        {
            return $"Numero: {Numero}\nNombre: {Nombre}\nSaldo: {Saldo}";
        }
        public double Depositar(double dblCantidad)
        {
            Saldo += dblCantidad;
            return Saldo;
        }
        public double Retirar(double dblCantidad)
        {
            if (Saldo >= dblCantidad)
            {
                Saldo -= dblCantidad;
            }
            
            return Saldo;
        }
    }
}
