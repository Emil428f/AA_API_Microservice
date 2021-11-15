using System.Collections.Generic;

namespace Repository
{
    public interface IRepository<TModel> where TModel : class
    {
        IEnumerable<TModel> RetrieveAll();
        TModel Retrieve(int id);
        void Add(TModel entity);
        void Remove(TModel entity);
    }
}
