using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEj_5
{
    class Fecha 
    {

        public Fecha()
        {
            _intDia = 23;
            _intMes = 09;
            _intAnio = 2020;
        }
        public Fecha(int intDia, int intMes, int intAnio)
        {
            _intDia = intDia;
            _intMes = intMes;
            _intAnio = intAnio;
            if(!ValidaFecha())
            {
                _intDia = 23;
                _intMes = 09;
                _intAnio = 2020;
            }

        }

        private int _intDia;

        private int _intMes;

        private int _intAnio;

        public bool ValidaFecha()
        {
            if (_intDia >= 1 && _intDia <= 31)
            {
                if (_intMes >= 1 && _intMes <=12)
                {
                    if (_intMes == 2 && _intDia > 28)
                    {
                        if ((_intAnio % 4 == 0 && _intAnio % 100 != 0) || _intAnio % 400 == 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void ModificarFecha(int intDia, int intMes, int intAnio)
        {
            _intDia = intDia;
            _intMes = intMes;
            _intAnio = intAnio;
            if (!ValidaFecha())
            {
                _intDia = 23;
                _intMes = 09;
                _intAnio = 2020;
            }
        }
        public override string ToString()
        {
            if (ValidaFecha())
            {
                return $"{_intDia}/{_intMes}/{_intAnio}";
            }
            else
            {
                return "Fecha default";
            }
            
        }
        public string MesEnLetras(int intMes)
        {
            string Mes = "";
            switch (intMes)
            {
                case 1: Mes = "Enero"; break;
                case 2: Mes = "Febrero"; break;
                case 3: Mes = "Mar"; break;
                case 4: Mes = "Abril"; break;
                case 5: Mes = "Mayo"; break;
                case 6: Mes = "Junio"; break;
                case 7: Mes = "Julio"; break;
                case 8: Mes = "Agosto"; break;
                case 9: Mes = "Septiembre"; break;
                case 10: Mes = "Octubre"; break;
                case 11: Mes = "Noviembre"; break;
                case 12: Mes = "Diciembre"; break;
                default: return "Mes incorrecto";
            }
            return $"{_intDia}/{Mes}/{_intAnio}";
            
        }
        
        public string MesEnLetras()
        {
            string Mes = "";
            switch (_intMes)
            {
                case 1: Mes = "Enero"; break;
                case 2: Mes = "Febrero"; break;
                case 3: Mes = "Mar"; break;
                case 4: Mes = "Abril"; break;
                case 5: Mes = "Mayo"; break;
                case 6: Mes = "Junio"; break;
                case 7: Mes = "Julio"; break;
                case 8: Mes = "Agosto"; break;
                case 9: Mes = "Septiembre"; break;
                case 10: Mes = "Octubre"; break;
                case 11: Mes = "Noviembre"; break;
                case 12: Mes = "Diciembre"; break;
            }
            return $"{_intDia}/{Mes}/{_intAnio}";
           }           
        }
    }


