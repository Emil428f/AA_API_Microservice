using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebAPI.EntityFramework.Context;
using WebAPI.EntityFramework.Repositories;
using WebAPI.Interfaces;
using WebAPI.Interfaces.Base;
using WebAPI.Models;
using Xunit;

namespace UnitTest
{
    [TestClass]
    public class GpsRepositoryTest
    {
        public Mock<IGps> expectedGpsMock = new Mock<IGps>();
        public Mock<IGpsRepository> gpsRepoMock = new Mock<IGpsRepository>();

        public GpsRepositoryTest()
        {
            expectedGpsMock = new Mock<IGps>();
            gpsRepoMock = new Mock<IGpsRepository>();
        }
        public void Dispose()
        {
            expectedGpsMock = null;
            gpsRepoMock = null;
        }

        // almindelig fact 
        // kan bruges til TDD spørgsmål, da den mocker alt uden implementering
        [Fact]
        public void GpsRepositoryTest_GetGpsByTruckId_ValidID_Should_Return_True()
        {
            //arrange
            expectedGpsMock.SetupGet(mock => mock.Id).Returns(1);
            expectedGpsMock.SetupGet(mock => mock.Coordinates).Returns("50;30");

            gpsRepoMock.Setup(repo => repo.GetGpsByTruckId(1)).Returns(new Gps(){ Id = 1, Coordinates = "50;30" });

            //act
            IGps result = gpsRepoMock.Object.GetGpsByTruckId(1);

            //assert
            Assert.IsTrue(true);
            result.Should().BeEquivalentTo(expectedGpsMock.Object, options => options.Including(i => i.Id).Including(c => c.Coordinates));
        }
        // almindelig negative fact
        // kan bruges til TDD spørgsmål, da den mocker alt uden implementering
        [Fact]
        public void GpsRepositoryTest_GetGpsByTruckId_InvalidID_Should_Return_false()
        {
            //arrange
            expectedGpsMock.SetupGet(mock => mock.Id).Returns(1);
            expectedGpsMock.SetupGet(mock => mock.Coordinates).Returns("50;30");

            gpsRepoMock.Setup(repo => repo.GetGpsByTruckId(1)).Returns(new Gps() { Id = 1, Coordinates = "50;35" });

            //act
            IGps result = gpsRepoMock.Object.GetGpsByTruckId(1);

            //assert
            result.Should().NotBeEquivalentTo(expectedGpsMock.Object, options => options.Including(i => i.Id).Including(c => c.Coordinates));
        }

        //theory using memberdata(field-data, method-data)
        // kan bruges til DDT spørgsmål


        //almindelig Fact
        // kan bruges til TDD spørgsmål, med implementering
    }
}
