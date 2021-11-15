using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Models
{
    public class Trailer : GPS
    {
        public int TrailerId { get; set; }
        public string Numberplate { get; set; }
        public string CurrentLocation { get; set; }
    }
}
