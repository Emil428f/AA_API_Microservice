using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Interfaces
{
    public interface IGps
    {
        public int Id { get; set; }

        public string Coordinates { get; set; }
    }
}
