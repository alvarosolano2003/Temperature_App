﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Infraestructura.Interfaces
{
    public interface IRegistroRepository : IBase<Registro>
    {
        decimal Conversion(decimal e, int index);
     }
}
