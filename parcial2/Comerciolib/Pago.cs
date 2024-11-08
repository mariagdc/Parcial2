using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comerciolib
{
    public class Pago : Ticket

    {

        static int nroInicio;
        private CuentaCorriente cuentac;
        public Pago(CuentaCorriente cuentac)
        {
            this.cuentac = cuentac;
            nroOrden = nroInicio++;
        }

        public void MontoPago(double valor)
        {
            cuentac.RegistrarPago(valor);
        }

        public override string ToString()
        {
            return $"{nroInicio}; {cuentac.ToString()}";
        }
    }
}
