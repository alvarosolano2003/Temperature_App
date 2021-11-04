using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositories
{
    public class Fahrenheit : RegistroRepository
    {
        public override decimal Conversion(decimal grados, int index)
        { 
            if (index == 0)
            {
                return (grados - 32) * 5 / 9;
            }
            else if (index == 1)
            {
                return (grados - 32) * 5/9 + 273;
            }
            else
            {
                throw new ArgumentException("Los valores son incorrectos.");
            }
        }
    }
}
