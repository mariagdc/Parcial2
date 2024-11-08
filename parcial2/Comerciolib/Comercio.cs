using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Comerciolib
{
    public  class Comercio
    {


        List <CuentaCorriente> cuentasCorrientes = new List<CuentaCorriente> ();
        Queue<Pago> pagos = new Queue<Pago> ();
        Queue<Cliente> clientes = new Queue<Cliente> ();    
        List <Ticket> ticketes = new List<Ticket> ();


        public void AgregarTicket(Ticket turno)
        {
            if (turno is Cliente)

            {
                clientes.Enqueue((Cliente) turno);
            }
            if (turno is Pago)
            {
                pagos.Enqueue((Pago) turno);//hace el CASTEOOO

            }
        }
        public CuentaCorriente pedirCuenta(int nroCuenta)
        {
            cuentasCorrientes.Sort();
            int idx =cuentasCorrientes.BinarySearch(new CuentaCorriente (nroCuenta, null));
            if (idx > 0)
            {
                return cuentasCorrientes[idx];
            }
            return null;

            
        }

        public void AtenderTicket(int Tipo)
        {
            Ticket t = null;
            if (Tipo == 0)
            {
                if (pagos.Count > 0)
                {
                    t = pagos.Dequeue();
                    ticketes.Add(t);
                }
            }
            else if (Tipo == 1)
            {

                if (clientes.Count > 0)
                {
                    t = clientes.Dequeue();
                    ticketes.Add(t);
                }


            }


        }

        public void CrearCuentaC(int c, Cliente nc)
        {
            cuentasCorrientes.Add(new CuentaCorriente(c,nc));
        }
    }
}
