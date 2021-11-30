using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebAPI.EntityFramework.Context;
using WebAPI.EntityFramework.Repositories;
using WebAPI.Models;

namespace UnitTest
{
    [TestClass]
    public class GPSControllerTest
    {
        [TestMethod]
        public void GpsController_Inherrited_Methods_From_Parent()
        {
            //var gpsId = 40000;
            //var expectedCoordinate = "onetwothree";
            //var gps = new Gps() { Id = gpsId, Coordinates = expectedCoordinate };

            //var gpsRepository = new Mock<GpsRepository>();
            //gpsRepository.Setup(o => o.GetById(gpsId)).Returns(gps).Verifiable();

            //var actual = gpsRepository.Object.GetById(gpsId);

            //gpsRepository.Verify();
            //actual.Should().BeOfType<Gps>();

            //var contextMock = new Mock<ApplicationDbContext>();
            //var gpsRepoMock = new Mock<GpsRepository>();
            //contextMock.Setup(o => o.Gps.Find(40000)).Verifiable();

            //var actual = gpsRepoMock.Object.ApplicationDbContext.Gps.Find(40000);

            //contextMock.Verify();
            //actual.Should().BeOfType<Gps>();

            var gpsMock = new Mock<Gps>();
            var gpsRepoMock = new Mock<GpsRepository>();

            gpsRepoMock.Setup(repo => repo.GetById(40000)).Returns(gpsMock.Object);

            gpsRepoMock.Verify();
        }
    }
}
