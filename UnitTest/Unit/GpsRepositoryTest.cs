using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebAPI.EntityFramework.Context;
using WebAPI.EntityFramework.Repositories;
using WebAPI.Interfaces;
using WebAPI.Interfaces.Base;
using WebAPI.Models;

namespace UnitTest
{
    [TestClass]
    public class GpsRepositoryTest
    {
        [TestMethod]
        public void GpsRepositoryTest_GetGpsByTruckId_Should_Return_True()
        {
            //arrange
            var expectedGpsMock = new Mock<IGps>();
            expectedGpsMock.SetupGet(mock => mock.Id).Returns(1);
            expectedGpsMock.SetupGet(mock => mock.Coordinates).Returns("50;30");

            var gpsRepoMock = new Mock<IGpsRepository>();
            gpsRepoMock.Setup(repo => repo.GetGpsByTruckId(1)).Returns(new Gps(){ Id = 1, Coordinates = "50;30" });

            //act
            IGps result = gpsRepoMock.Object.GetGpsByTruckId(1);

            //assert
            result.Should().BeEquivalentTo(expectedGpsMock.Object, options => options.Including(i => i.Id).Including(c => c.Coordinates));
        }
    }
}
