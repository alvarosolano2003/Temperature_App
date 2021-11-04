using Infraestructura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositories
{
    public class BaseRepository<T> : IBase<T>
    {
        protected List<T> data;
        public BaseRepository()
        {
            data = new List<T>();
        }

        public void Create(T t)
        {
            data.Add(t);
        }

        public List<T> GetAll(Predicate<T> predicate)
        {
            return data.FindAll(predicate);
        }
    }
}
