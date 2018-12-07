using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Library.Interfaces;

namespace Library.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected ModelContext _db;
        protected readonly DbSet<T> _dbSet;
        private bool _disposed = false;

        public GenericRepository()
        {
            this._db = new ModelContext();
            this._dbSet = _db.Set<T>();
        }

        public virtual List<T> Get()
        {
            List<T> get = this._dbSet.AsNoTracking().ToList();
            return get;
        }

        public virtual T FindById(int id)
        {
            T findById = this._dbSet.Find(id);
            return findById;
        }

        public virtual List<T> FindById(List<int> idList)
        {
            var findById = new List<T>();
            foreach (var id in idList)
            {
                findById.Add(this._dbSet.Find(id));
            }
            return findById;
        }

        public virtual void Create(T item)
        {
            this._dbSet.Add(item);
            this.SaveChanges();
        }

        public virtual void Create(List<T> items)
        {
            foreach (var item in items)
            {
                this._dbSet.Add(item);
                this.SaveChanges();
            }
        }

        public virtual void Update(T item)
        {
            T oldItem = null;
            oldItem = FindById(item.Id);

            this._db.Entry(oldItem).CurrentValues.SetValues(item);
            this.SaveChanges();
        }

        public virtual void Update(List<T> items)
        {
            T oldItem = null;
            foreach (var item in items)
            {
                oldItem = FindById(item.Id);

                this._db.Entry(oldItem).CurrentValues.SetValues(item);
            }
            this.SaveChanges();
        }

        public virtual void Remove(int id)
        {
            T item = _dbSet.Find(id);

            if (item != null)
            {
                this._dbSet.Remove(item);
                this.SaveChanges();
            }
        }

        protected virtual void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
