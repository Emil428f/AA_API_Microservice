using EntityFramework.Context;
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class GpsRepository : Repository<Gps>, IGpsRepository
    {
        public ApplicationDbContext ApplicationDbContext
        {
            get { return _context as ApplicationDbContext; }
        }

        public GpsRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Gps> RetrieveGps()
        {
            return ApplicationDbContext.Gps.ToList();
        }

        public IEnumerable<Gps> RetrieveGpsById(int id)
        {
            return ApplicationDbContext.Gps.Where(i => i.Id == id);
        }
    }
}
