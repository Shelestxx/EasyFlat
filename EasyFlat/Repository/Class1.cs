using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFlat.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected List<T> items = new List<T>();

        public void Add(T item) => items.Add(item);
        public void Remove(int id) => items.RemoveAll(i => i.Id == id);
        public T GetById(int id) => items.FirstOrDefault(i => i.Id == id);
        public IEnumerable<T> GetAll() => items;
        public IEnumerable<T> GetSorted() => items.OrderBy(i => i.Id);
    }

    // Базовый класс для сущностей
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }

    // 3. Создание конкретных репозиториев
    public class Apartment : BaseEntity
    {
        public string Address { get; set; }
        public decimal Price { get; set; }
    }

    public class ApartmentRepository : Repository<Apartment>
    {
        public IEnumerable<Apartment> GetByPrice(decimal minPrice) => items.Where(a => a.Price >= minPrice);
    }
}