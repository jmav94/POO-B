﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3._1
{
    class CD : Publicacion
    {
        private double _dblTiempo;

        public double Tiempo
        {
            get { return _dblTiempo; }
            set { _dblTiempo = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()} \nTiempo de reproduccion: {Tiempo} \nVentas mes 1: {this[0]} \nVentas mes 2: {this[1]} \nVentas mes 3: {this[2]}";
        }
    }
}
