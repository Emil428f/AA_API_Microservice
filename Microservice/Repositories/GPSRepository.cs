using Microservice.Data_Access_Layer;
using Microservice.Interfaces;
using Microservice.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Microservice.Repositories
{
    public class GPSRepository : IGPSRepository
    {
        private readonly ApplicationContext _context;
        private DbSet<GPS> _gpsEntity;

        public GPSRepository(ApplicationContext context)
        {
            this._context = _context;
            _gpsEntity = context.Set<GPS>();
        }

        public IEnumerable<GPS> RetrieveAllGPS()
        {
            return _gpsEntity.AsEnumerable();
        }

        public GPS RetrieveById(int gpsId)
        {
            return _gpsEntity.SingleOrDefault(i => i.Id == gpsId);
        }

        public void DeleteById(int gpsId)
        {
            GPS gps = RetrieveById(gpsId);
            _gpsEntity.Remove(gps);
            _context.SaveChanges();
        }


        public void Save(GPS gps)
        {
            _context.Entry(gps).State = EntityState.Added;
            _context.SaveChanges();
        }
    }
}
