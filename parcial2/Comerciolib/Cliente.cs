using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comerciolib
{
    public class Cliente: Ticket
    {
        static int nroinicio;
        int dni;

        public Cliente(string DNI)
        {

            int Dni = Convert.ToInt32(DNI);
            if (dni < 300000000 && dni > 45000000)
            {
                throw new DniNoValidoExceptioon("Ingrese un dni valido");


            }
            this.dni = Dni;
            nroOrden = nroinicio++;
        }
        public override string ToString()
        {  
            return $"{nroinicio};{dni}"; 
        }
        
    }
}
