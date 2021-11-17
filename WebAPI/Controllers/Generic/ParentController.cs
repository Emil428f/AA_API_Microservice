using Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controller.Generic
{
    public abstract class ParentController<TModel, TRepository> : ControllerBase where TModel : class where TRepository : IRepository<TModel>
    {
        protected readonly TRepository repository;

        public ParentController(TRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public virtual IEnumerable<TModel> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet]
        public virtual TModel Get(int id)
        {
            return repository.Get(id);
        }

        [HttpPost]
        public virtual void Add([FromBody] TModel item)
        {
            repository.Add(item);
        }

        [HttpDelete]
        public virtual void Remove(TModel item)
        {
            repository.Remove(item);
        }
    }
}
