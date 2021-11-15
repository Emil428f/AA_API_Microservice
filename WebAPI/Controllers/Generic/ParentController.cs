using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controller.Generic
{
    public abstract class ParentController<TModel, TRepository> : ControllerBase where TModel : class where TRepository : IRepository<TModel>
    {
        protected readonly TRepository _repository;

        public ParentController(TRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public IEnumerable<TModel> Get()
        {
            return _repository.RetrieveAll();
        }

        [HttpPost]
        public void Add([FromBody] TModel item)
        {
            _repository.Add(item);
        } 
    }
}
