using Context;
using Interfaces;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class GpsRepository : Repository<Gps>, IGpsRepository
    {
        public ApplicationDbContext ApplicationDbContext
        {
            get { return databaseContext as ApplicationDbContext; }
        }

        public GpsRepository(ApplicationDbContext context) : base(context)
        {

        }



        // For implementing future functionality from the IGpsRepository.


        //public void Add(Gps entity)
        //{
        //    ApplicationDbContext.Gps.Add(entity);
        //}

        //public IEnumerable<Gps> GetCoordinates()
        //{
        //    return ApplicationDbContext.Gps.ToList();
        //}

        //public Gps Get(int id)
        //{
        //    return ApplicationDbContext.Gps.Find(id);
        //}

        //public void Remove(Gps entity)
        //{
        //    ApplicationDbContext.Gps.Remove(entity);
        //}
    }
}
