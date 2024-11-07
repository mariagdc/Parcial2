using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comerciolib
{
    public abstract class Ticket
    {
        protected int nroOrden;
        DateTime fechaHora;

        public int VerNumero()
        {
            return nroOrden;
        }

        public DateTime VerFecha()
        {
            return fechaHora;
        }
    }
}
