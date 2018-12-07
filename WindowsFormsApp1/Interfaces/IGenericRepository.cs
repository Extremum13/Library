using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        void Create(T item);
        T FindById(int id);
        List<T> Get();
        void Remove(int id);
        void Update(T item);

        void Create(List<T> items);
        void Update(List<T> items);
        List<T> FindById(List<int> idList);
    }
}
