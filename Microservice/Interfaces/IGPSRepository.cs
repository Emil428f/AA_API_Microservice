using Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Interfaces
{
    interface IGPSRepository
    {
        IEnumerable<GPS> RetrieveAllGPS();
        Models.GPS RetrieveById(int GpsId);

        // Use case does not need to insert or update gps coordinates.
        //void Insert(Models.GPS gps);
        //void Update(Models.GPS gps);

        void DeleteById(int gps);
        void Save(GPS gps);
    }
}
