using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFlat.Classes
{
    using EasyFlat.Interfaces;
    using EasyFlat.Repository;

    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        protected List<T> _entities = new List<T>();

        public virtual void Add(T entity)
        {
            _entities.Add(entity);
        }

        public virtual void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        public virtual T GetById(int id)
        {
            return _entities.FirstOrDefault(e => e.ID == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public virtual IEnumerable<T> GetSorted()
        {
            return _entities.OrderBy(e => e.ID); // або інша логіка
        }
    }
}
