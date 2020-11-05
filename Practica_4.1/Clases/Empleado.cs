using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1
{
    class Empleado 
    {
        private int _intHorasTrabajadas;

        public int HorasTrabajadas
        {
            get { return _intHorasTrabajadas; }
            set { _intHorasTrabajadas = value; }
        }
        private double _dblSueldoPorHora;

        public double SueldoPorHora
        {
            get { return _dblSueldoPorHora; }
            set { _dblSueldoPorHora = value; }
        }
        public virtual double CalcularSalario()
        {
            return HorasTrabajadas * SueldoPorHora;
        }
        
    }
    class EmpleadoSinHorasExtras: Empleado
    {
        public override double CalcularSalario()
        {
            return base.CalcularSalario();
        }
    }
    class EmpleadoConHorasDobles : Empleado
    {
        public override double CalcularSalario()
        {
            int intHorasExtras = 0;
            double dblSueldoExtra = 0, dblSueldoNormal= 0;

            if (HorasTrabajadas < 41)
            {
                return base.CalcularSalario();
            }
            else
            {
                intHorasExtras = HorasTrabajadas - 40;
                dblSueldoExtra = intHorasExtras * SueldoPorHora * 2;
                dblSueldoNormal = 40 * SueldoPorHora;
                return dblSueldoNormal + dblSueldoExtra;
            }
        }
    }
    class EmpleadoConHorasTriples : Empleado
    {
        public override double CalcularSalario()
        {
            int intHorasExtras = 0;
            double dblSueldoExtra = 0, dblSueldoNormal = 0;

            if (HorasTrabajadas < 41)
            {
                return base.CalcularSalario();
            }
            else
            {
                intHorasExtras = HorasTrabajadas - 40;
                dblSueldoExtra = intHorasExtras * SueldoPorHora * 3;
                dblSueldoNormal = 40 * SueldoPorHora;
                return dblSueldoNormal + dblSueldoExtra;
            }
        }
    }
}
