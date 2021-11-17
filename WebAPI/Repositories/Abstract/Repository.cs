using Microsoft.EntityFrameworkCore;
using Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public abstract class Repository<TModel> : IRepository<TModel> where TModel : class
    {
        protected readonly DbContext databaseContext;

        public Repository(DbContext context)
        {
            this.databaseContext = context;
        }

        public void Add(TModel entity)
        {
            databaseContext.Set<TModel>().Add(entity);
        }

        public IEnumerable<TModel> GetAll()
        {
            return databaseContext.Set<TModel>().ToList();
        }

        public TModel Get(int id)
        {
            return databaseContext.Set<TModel>().Find(id);
        }

        public void Remove(TModel entity)
        {
            databaseContext.Set<TModel>().Remove(entity);
        }
    }
}
