using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositories
{
    public class Kelvin : RegistroRepository
    {
        public override decimal Conversion(decimal grados, int index)
        {
            if (index == 0)
            {
                return grados - 273;
            }
            else if (index == 1)
            {
                return (grados - 273) * 9/5 + 32;
            }
            else
            {
                throw new ArgumentException("Los valores son incorrectos.");
            }
        }
    }
}
