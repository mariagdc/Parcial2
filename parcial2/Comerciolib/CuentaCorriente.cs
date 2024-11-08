using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comerciolib
{
    public class CuentaCorriente: IComparable<CuentaCorriente>

    {
        private int nrocuenta;
        Cliente titular;
        private double saldo;


        public CuentaCorriente(int n, Cliente titular)
        {
            nrocuenta = n;
            this.titular = titular;
        }

        public void RegistrarPago(double m)
        { this.saldo -= m; }
        public void RegistrarCompra(double m)
        { this.saldo += m; }
        public int VerNumero()
        {
            return nrocuenta;
        }

        public int CompareTo (CuentaCorriente other)
        {
            if (other != null) return nrocuenta.CompareTo (other.nrocuenta);
            return 1;

        }
        public override string ToString()
        {
            return $"{nrocuenta};{saldo}";
        }

    }
}
