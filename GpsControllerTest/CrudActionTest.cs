using System;
using Xunit;
using Moq;
using FluentAssertions;
using WebAPI.Interfaces;
using WebAPI.EntityFramework.Repositories;
using WebAPI.EntityFramework.Context;
using WebAPI.EntityFramework.Repositories.Abstract;
using WebAPI.Models;
using WebAPI.Interfaces.Base;

namespace GpsRepositoryTest
{
    public class CrudActionTest
    {
        //public Mock<IGpsRepository> _igpsRepo;
        public Mock<IGps> _igps;
        //public Mock<IGenericRepository<IGps>> _igeneric;
        public FakeGpsContext _context;

        public CrudActionTest()
        {
            //_igpsRepo = new Mock<IGpsRepository>();
            //_igeneric = new Mock<IGenericRepository<IGps>>();
            _igps = new Mock<IGps>();
            _context = new FakeGpsContext();
        }

        [Fact]
        public void GetAll_ListOfGpsCoordinates_ReturnList()
        {
            //GpsRepository repo = new GpsRepository(_context);

            IGenericRepository<IGps> generic = new IGenericRepository<Gps>();
            throw new NotImplementedException();
        }
    }
}
