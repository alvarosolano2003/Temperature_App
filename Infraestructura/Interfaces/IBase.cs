using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Interfaces
{
    public interface IBase<T>
    {
        void Create(T t);
        List<T> GetAll(Predicate<T> predicate);
    }
}
