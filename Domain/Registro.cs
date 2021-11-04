using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Registro
    {
        public EscalaTemperatura escalaTemperatura { get; set; }
        public decimal GradosCelcius { get; set; }
        public decimal Kelvin { get; set; }
        public decimal GradosFahrenheit { get; set; }
    }
}
