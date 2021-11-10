using Microservice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailerController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Trailer> Get()
        {
            return new List<Trailer>()
            {
                new Trailer()
                {
                    Name = "Test",
                    Description = "Test",
                    Price = 9.99M,
                    CategoryId = 1
                }
            };
        }

        [HttpGet("{id}")]
        public Trailer Get(int? id)
        {
            return
                new Trailer()
                {
                    Name = "Test",
                    Description = "Test",
                    Price = 9.99M,
                    CategoryId = 1
                };
        }

        [HttpPost]
        public Trailer Post([FromBody] Trailer product)
        {
            return product;
        }

        // No need to update GPS location.
        [HttpPut("{id}")]
        public Trailer Put(int? id, [FromBody] Trailer product)
        {
            return product;
        }

        [HttpDelete("{id}")]
        public void Delete(int? id)
        {

        }
    }
}
