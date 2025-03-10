using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyFlat.Repository;

namespace EasyFlat.Repository
{

   public interface IRepository<T>
{
    void Add(T item);
    void Remove(int id);
    T GetById(int id);
    IEnumerable<T> GetAll();
    IEnumerable<T> GetSorted();
}
}