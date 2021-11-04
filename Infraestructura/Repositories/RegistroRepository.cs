using Domain;
using Infraestructura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositories
{
    public class RegistroRepository : IRegistroRepository
    {
        protected List<Registro> registros;
        public RegistroRepository()
        {
            registros = new List<Registro>();
        }
        public virtual decimal Conversion(decimal e, int index)
        {
            throw new ArgumentException();
        }

        public void Create(Registro t)
        {
            registros.Add(t);
        }

        public List<Registro> GetAll(Predicate<Registro> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
