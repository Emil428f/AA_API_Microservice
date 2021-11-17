using Models;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controller.Generic;
using System.Collections.Generic;
using Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GpsController : ParentController<Gps, GpsRepository>
    {
        public GpsController(GpsRepository gpsRepository) : base(gpsRepository)
        {

        }

        [HttpGet]
        public override IEnumerable<Gps> GetAll()
        {
            return repository.GetAll();
        }

        [Route("{id}")]
        [HttpGet]
        public override Gps Get(int id)
        {
            return repository.Get(id);
        }

        [HttpPost]
        public override void Add([FromBody] Gps item)
        {
            repository.Add(item);
        }

        [Route("{id}")]
        [HttpDelete]
        public override void Remove(Gps item)
        {
            repository.Remove(item);
        }
    }
}
