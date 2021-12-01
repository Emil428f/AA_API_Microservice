using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.EntityFramework.Context
{
    public class GpsContext : DbContext, IDbContext
    {
        public DbSet<Gps> Gps { get; set; }
    }
}
