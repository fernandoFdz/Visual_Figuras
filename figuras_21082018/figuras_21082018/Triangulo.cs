using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_21082018
{
    class Triangulo: Figura { 
        private float iAltura;
        private float iBase;

        public float Altura
        {
            get
            {
                return iAltura;
            }
            set
            {
                iAltura = value;
            }
        }

        public float Base
        {
            get
            {
                return iBase;
            }
            set
            {
                iBase = value;
            }
        }

        public override double CalcularArea()
        {
            double dRes = (iBase * iAltura) / 2;
            return dRes;
        }

        public override double CalcularPerimetro()
        {
            double dRes = iBase * (iAltura * 2);
            return dRes;
        }


    }
}
