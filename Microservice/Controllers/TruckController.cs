using Microservice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruckController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Truck> Get()
        {
            return new List<Truck>()
            {
                new Truck()
                {
                    Name = "Test",
                    Description = "Test"
                }
            };
        }

        [HttpGet("{id}")]
        public Truck Get(int? id)
        {
            return
                new Truck()
                {
                    Name = "Test",
                    Description = "Test"
                };
        }

        [HttpPost]
        public Truck Post([FromBody] Truck category)
        {
            return category;
        }

        [HttpPut("{id}")]
        public Truck Put(int? id, [FromBody] Truck category)
        {
            return category;
        }

        [HttpDelete("{id}")]
        public void Delete(int? id)
        {

        }
    }
}
