using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IDbContext
    {
        public DbSet<Gps> Gps { get; set; }

    }
}
