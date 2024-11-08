using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comerciolib
{
    public class DniNoValidoExceptioon: ApplicationException
    {
        public DniNoValidoExceptioon() : base() { }
        public DniNoValidoExceptioon(string ex) : base(ex) { }
        public DniNoValidoExceptioon(string ex, Exception innerException) : base(ex, innerException) { }

    }
}
