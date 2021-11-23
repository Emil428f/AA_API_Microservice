using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.EntityFramework.Context
{
    public class FakeGpsSet : FakeDbSet<Gps>
    {
        public FakeGpsSet(): base()
        {

        }
    }
}
