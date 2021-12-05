using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Base;
using WebAPI.EntityFramework.Repositories;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GpsController : ParentController<IGps, IGpsRepository>
    {
        public GpsController(IGpsRepository repository) : base(repository) {}
    }
}
