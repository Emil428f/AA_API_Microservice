using System.Collections.Generic;
using System.Linq;
using WebAPI.EntityFramework.Context;
using WebAPI.EntityFramework.Repositories.Abstract;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.EntityFramework.Repositories
{
    public class GpsRepository : GenericRepository<Gps>, IGpsRepository
    {
        public ApplicationDbContext ApplicationDbContext
        { 
            get { return _databaseContext as ApplicationDbContext; }
        }

        public GpsRepository(ApplicationDbContext context) :base(context) {}

        public IGps GetGpsByTruckId(int id)
        {
            throw new System.NotImplementedException();
        }

        //public IEnumerable<Gps> GetGpsByTrailerId()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
