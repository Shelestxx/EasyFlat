using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFlat.Classes
{
    using EasyFlat.Interfaces;
    using EasyFlat.Repository;

    public class Repository<T> : IRepository<T> where T : IEntity
    {
        protected List<T> _entities = new List<T>();

        public virtual void Add(T entity) => _entities.Add(entity);
        public virtual void Remove(T entity) => _entities.Remove(entity);
        public T GetById(int id) => _entities.FirstOrDefault(e => e.ID == id);
        public IEnumerable<T> GetAll() => _entities;
        public IEnumerable<T> GetSorted() => _entities.OrderBy(e => e.ID);
    }
}