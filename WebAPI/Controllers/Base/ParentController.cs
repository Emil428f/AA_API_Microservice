using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Interfaces.Base;

namespace WebAPI.Controllers.Base
{
    public abstract class ParentController<TModel, TRepository> : ControllerBase where TModel : class where TRepository : IGenericRepository<TModel>
    {
        protected readonly TRepository Repository;

        public ParentController(TRepository repository)
        {
            this.Repository = repository;
        }

        [HttpGet]
        public IEnumerable<TModel> GetAll()
        {
            return Repository.GetAll();
        }

        [HttpGet("{id}")]
        public TModel GetById(int id)
        {
            return Repository.GetById(id);
        }

        [HttpPost]
        public void Add([FromBody] TModel entity)
        {
            Repository.Create(entity);
        }

        [HttpDelete("{id}")]
        public void Remove(TModel obj)
        {
            Repository.Delete(obj);
        }
    }
}