using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comerciolib
{
    internal class CuentaCorriente: IComparable<CuentaCorriente>

    {
        private int nrocuenta;
        Cliente titular;
        private double saldo;

            public int VerNumero()
        {
            return nrocuenta;
        }

        public int CompareTo (CuentaCorriente other)
        {
            if (other != null) return nrocuenta.CompareTo (other.nrocuenta);
            return 1;

        }


    }
}
