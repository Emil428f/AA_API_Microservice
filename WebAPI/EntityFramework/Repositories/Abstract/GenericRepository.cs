using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Interfaces.Base;

namespace WebAPI.EntityFramework.Repositories.Abstract
{
    public abstract class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {
        protected readonly DbContext _databaseContext;
        protected readonly DbSet<TModel> _dbSet;

        public GenericRepository(DbContext context)
        {
            this._databaseContext = context;
            this._dbSet = _databaseContext.Set<TModel>();
        }

        public void Create(TModel obj)
        {
            _databaseContext.Set<TModel>().Add(obj);
        }

        public void Delete(TModel obj)
        {
            TModel entityExists = _databaseContext.Set<TModel>().Find(obj);
            _databaseContext.Set<TModel>().Remove(entityExists);
        }

        public IEnumerable<TModel> GetAll()
        {
            return _databaseContext.Set<TModel>().ToList();
        }

        public TModel GetById(int id)
        {
            return _databaseContext.Set<TModel>().Find(id);
        }

        public void Save()
        {
            _databaseContext.SaveChanges();
        }
    }
}
