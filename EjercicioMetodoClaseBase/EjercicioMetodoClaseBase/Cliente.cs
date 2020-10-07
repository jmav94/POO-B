using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMetodoClaseBase
{
    class Cliente: Persona
    {
        public Cliente(string strNombre, DateTime dtmFechaNacimiento, double dblLimiteDeCredito) : base(strNombre, dtmFechaNacimiento)
        {
            _dblLimiteCredito = dblLimiteDeCredito;
        }
        private double _dblLimiteCredito;

        public double LimiteCredito
        {
            get { return _dblLimiteCredito; }
            set { _dblLimiteCredito = value; }
        }

        public bool EsMayorDeEdad()
        {
            int intEdad;
            intEdad = CalcularEdad();
            if (intEdad>= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            if (EsMayorDeEdad())
            {
                return $"{Nombre} tiene {CalcularEdad()} y es mayor de Edad \nEl limite de credito es de: ${LimiteCredito}";
            }
            else
            {
                return $"{Nombre} tiene {CalcularEdad()} y no es mayor de Edad";
            }
        }
    }
}
