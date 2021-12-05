using System.Collections.Generic;
using WebAPI.Interfaces.Base;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IGpsRepository : IGenericRepository<IGps>
    {
        IGps GetGpsByTruckId(int id);
        //IEnumerable<Gps> GetGpsByTrailerId();
    }
}