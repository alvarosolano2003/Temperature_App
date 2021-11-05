using Domain;
using Infraestructura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositories
{
    public class RegistroRepository : BaseRepository<Registro>, IRegistroRepository
    {
        public virtual decimal Conversion(decimal e, int index)
        {
            throw new ArgumentException();
        }
    }
}
