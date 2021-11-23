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


        //[HttpGet("Something")]
        //public string getsome()
        //{
        //    System.Diagnostics.Debug.WriteLine("Hej verden !");

        //    System.Diagnostics.Debug.WriteLine("Hej verden !");

        //    return "Hello World";
        //}
    }
}
