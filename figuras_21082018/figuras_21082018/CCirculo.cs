using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_21082018
{
    class CCirculo: Figura
    {
        public event EventHandler Changed;

        private float iDiametro;

        public float Diametro
        {
            get
            {
                return iDiametro;
            }
            set
            {
                iDiametro = value;
                Changed(this, EventArgs.Empty);
            }
        }

        public override double CalcularArea()
        {
            double dRes = Math.PI * Math.Pow((iDiametro / 2), 2);
            return dRes;
        }

        public override double CalcularPerimetro()
        {
            double dRes = ((2 * Math.PI) * (iDiametro / 2));
            return dRes;
        }

    
    }
}
