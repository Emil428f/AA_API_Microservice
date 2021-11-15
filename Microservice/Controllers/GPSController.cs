using Microservice.Data_Access_Layer;
using Microservice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GPSController : ControllerBase
    {
        private readonly GPSContext _gpsContext;

        public GPSController(GPSContext context)
        {
            _gpsContext = context ?? throw new ArgumentNullException(nameof(context));
            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        [HttpGet]
        public IEnumerable<GPS> Get()
        {
            return new List<GPS>()
            {
                new GPS()
                {

                }
            };
        }

        [HttpGet("{id}")]
        public GPS Get(int? id)
        {
            return
                new GPS()
                {

                };
        }

        [HttpPost]
        public GPS Post([FromBody] GPS product)
        {
            return product;
        }

        [HttpPut("{id}")]
        public GPS Put(int? id, [FromBody] GPS product)
        {
            return product;
        }

        [HttpDelete("{id}")]
        public void Delete(int? id)
        {

        }
    }
}
