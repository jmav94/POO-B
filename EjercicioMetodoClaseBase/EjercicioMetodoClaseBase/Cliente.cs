using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMetodoClaseBase
{
    class Cliente: Persona
    {
        public bool EsMayorDeEdad()
        {
            int intEdad;
            intEdad = base.CalcularEdad();
            if (intEdad>= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
