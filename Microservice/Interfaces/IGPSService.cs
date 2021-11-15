using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Interface
{
    public interface IGPSService
    {
        public string FetchRemoteGPSCoordinates();
    }
}
