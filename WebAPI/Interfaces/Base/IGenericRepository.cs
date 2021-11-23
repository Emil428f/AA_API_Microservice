using System.Collections.Generic;

namespace WebAPI.Interfaces.Base
{
    public interface IGenericRepository<TModel> where TModel : class
    {
        IEnumerable<TModel> GetAll();
        TModel GetById(int id);
        void Create(TModel obj);
        void Delete(TModel obj);
        void Save();
    }   
}