using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Base;
using WebAPI.EntityFramework.Repositories;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GpsController : ParentController<Gps, GpsRepository>
    {
        public GpsController(GpsRepository repository) : base(repository)
        {
        }

    }
}
