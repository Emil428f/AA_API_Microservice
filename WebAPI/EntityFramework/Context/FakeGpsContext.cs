using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.EntityFramework.Context
{
    public class FakeGpsContext : IApplicationDbContext
    {
        public DbSet<Gps> Gps { get; set; }

        public FakeGpsContext()
        {
            this.Gps = new FakeGpsSet();
        }
    }
}
