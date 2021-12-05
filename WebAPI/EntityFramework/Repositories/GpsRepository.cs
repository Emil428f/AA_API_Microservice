using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebAPI.EntityFramework.Context;
using WebAPI.EntityFramework.Repositories.Abstract;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.EntityFramework.Repositories
{
    public class GpsRepository : GenericRepository<IGps>, IGpsRepository
    {
        public GpsRepository(ApplicationDbContext context) :base(context) {}

        public IGps GetGpsByTruckId(int id)
        {
            return _databaseContext.Gps.FirstOrDefault(x => x.Id == id);
        }
    }
            //throw new System.NotImplementedException();
}
