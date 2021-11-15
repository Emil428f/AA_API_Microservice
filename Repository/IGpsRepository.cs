using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IGpsRepository : IRepository<Gps>
    {
        IEnumerable<Gps> RetrieveGps();
        IEnumerable<Gps> RetrieveGpsById(int id);
    }
}
