using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepository<TModel> where TModel : class
    {
        void Add(TModel entity);
        IEnumerable<TModel> GetAll();
        TModel Get(int id);
        void Remove(TModel entity);
    }
}
