using EntityFramework;
using Model;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controller.Generic;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GpsController : ParentController<Gps, GpsRepository>
    {
        public GpsController(GpsRepository gpsRepository) : base(gpsRepository)
        {

        }

        [Route("{id}")]
        [HttpGet]
        public IEnumerable<Gps> ById(int id)
        {
            return base._repository.RetrieveGpsById(id);
        }
    }
}
