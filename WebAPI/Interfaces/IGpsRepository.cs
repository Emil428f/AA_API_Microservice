using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IGpsRepository : IRepository<Gps>
    {
        // For implementing specific GPS functionality that shouldn't be used in other classes besides the GPS related ones.
    }
}
