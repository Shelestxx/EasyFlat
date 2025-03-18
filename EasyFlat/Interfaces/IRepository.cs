using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyFlat.Repository;

namespace EasyFlat.Repository
{ 

    public interface IRepository<T> // просто набір МЕТОДІВ
    {
        void Add(T entity);
        void Remove(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetSorted();
    }
}
