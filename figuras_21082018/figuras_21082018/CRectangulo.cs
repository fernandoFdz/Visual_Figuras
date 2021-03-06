﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_21082018
{
    class CRectangulo : Figura { 
    private float iAltura;
        public event EventHandler Changed2;

        public float Lado
        {
            get
            {
                return iAltura;
            }
            set
            {
                iAltura = value;
                Changed2(this, EventArgs.Empty);
            }
        }

        public override double CalcularArea()
        {
            double dRes = iAltura * iAltura;
            return dRes;
        }

        public override double CalcularPerimetro()
        {
            double dRes = iAltura + iAltura + iAltura + iAltura;
            return dRes;
        }


    }    
}
