using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework
{
    public abstract class Repository<TModel> : IRepository<TModel> where TModel : class
    {
        protected readonly DbContext _context;

        public Repository(DbContext context)
        {
            this._context = context;
        }

        public void Add(TModel entity)
        {
            _context.Set<TModel>().Add(entity);
        }

        public IEnumerable<TModel> RetrieveAll()
        {
            return _context.Set<TModel>().ToList();
        }

        public TModel Retrieve(int id)
        {
            return _context.Set<TModel>().Find(id);
        }

        public void Remove(TModel entity)
        {
            _context.Set<TModel>().Remove(entity);
        }
    }
}
