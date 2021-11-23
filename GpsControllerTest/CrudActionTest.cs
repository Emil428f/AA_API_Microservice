using System;
using Xunit;
using Moq;
using FluentAssertions;
using WebAPI.Interfaces;
using WebAPI.EntityFramework.Repositories;
using WebAPI.EntityFramework.Context;

namespace GpsRepositoryTest
{
    public class CrudActionTest
    {
        public Mock<IGpsRepository> _igpsRepo;

        public CrudActionTest()
        {
            _igpsRepo = new Mock<IGpsRepository>();
        }

        [Fact]
        public void GetAll_ListOfGpsCoordinates_ReturnList()
        {
            throw new NotImplementedException();
        }
    }
}
