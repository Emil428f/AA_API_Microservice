using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Models
{
    public class Truck : GPS
    {
        public int TruckId { get; set; }
        public string Numberplate { get; set; }
        public string CurrentLocation { get; set; }
    }
}
