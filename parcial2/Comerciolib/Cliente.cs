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

        public Cliente (string Dni)
        {
            
            int dni = convertToInt32(tbDni.text);
                if (dni<300000000) { }
        }
    }
}
