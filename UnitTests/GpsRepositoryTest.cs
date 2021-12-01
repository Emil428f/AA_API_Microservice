using Moq;
using FluentAssertions;
using System;
using Xunit;
using WebAPI.Interfaces;
using WebAPI.Models;
using WebAPI.EntityFramework.Repositories;
using WebAPI.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    public class GpsRepositoryTest
    {
        public Mock<IGps> expectedGpsMock = new();
        public Mock<IGpsRepository> gpsRepoMock = new();

        public GpsRepositoryTest()
        {
            expectedGpsMock = new Mock<IGps>();
            gpsRepoMock = new Mock<IGpsRepository>();
        }

        [Fact]
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

            gpsRepoMock.Setup(repo => repo.GetGpsByTruckId(1)).Returns(new Gps() { Id = 1, Coordinates = "50;30" });

            //act
            IGps result = gpsRepoMock.Object.GetGpsByTruckId(1);

            //assert
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

        //fact almindelig TDD test efter vi implementerede methoden



        //theory using memberdata(field-data, method-data)
        // kan bruges til DDT spørgsmål
        [Theory,
         InlineData(1, "50;30"),
         InlineData(2, "30;50"),
         InlineData(3, "40;20"),
         InlineData(4, "50;10"),
         InlineData(5, "20;40"),]
        public void GpsRepositoryTest_Mock_GetGpsByTruckId_ValidID_DDT_Should_Return_True(int id, string coordinates)
        {
            //Arrange
            expectedGpsMock.SetupGet(mock => mock.Id).Returns(id);
            expectedGpsMock.SetupGet(mock => mock.Coordinates).Returns(coordinates);

            gpsRepoMock.Setup(repo => repo.GetGpsByTruckId(id)).Returns(new Gps() { Id = id, Coordinates = coordinates });

            //act
            IGps result = gpsRepoMock.Object.GetGpsByTruckId(id);

            //Assert
            result.Should().BeEquivalentTo(expectedGpsMock.Object, options => options.Including(i => i.Id).Including(c => c.Coordinates));
        }

        //almindelig theory as integrationtest
        // kan bruges til TDD spørgsmål, med implementering
        [Theory, MemberData(nameof(GetGpsDTOs))]
        public void GpsRepository_Implemented_GetGpsByTruckId_ValidID_Should_return_true(Gps gpsDTO)
        {
            //Arrange
            //setup context
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase("Server=(localdb)\\mssqllocaldb;Database=SemesterProject_Microservice;Trusted_Connection=True;MultipleActiveResultSets=true");
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            GpsRepository gpsRepository = new(_dbContext);

            //Act
            var result = gpsRepository.GetGpsByTruckId(gpsDTO.Id);

            //Assert
            result.Should().BeEquivalentTo(gpsDTO, options => options.Including(i => i.Id).Including(c => c.Coordinates));
        }

        //[Fact]
        //public void GpsRepository_FakeDbSet_GetGpsByTruckId_ValidID_Should_return_true()
        //{
        //    //Arrange
        //    //setup context
        //    GpsContext context = new GpsContext();

        //    context.Gps = GetQueryableMockDbSet(
        //        new Gps { Id = 1, Coordinates = "10:10" },
        //        new Gps { Id = 2, Coordinates = "10:11" },
        //        new Gps { Id = 3, Coordinates = "10:12" }
        //    );
        //    Gps expectedGps = context.Gps.FirstOrDefault(x => x.Id == 1);
        //    GpsRepository gpsRepository = new(context);



        //    ////Act
        //    var result = gpsRepository.GetGpsByTruckId(1);

        //    ////Assert
        //    result.Should().BeEquivalentTo(expectedGps, options => options.Including(i => i.Id).Including(c => c.Coordinates));
        //}



        public static IEnumerable<object[]> GetGpsDTOs()
        {
            yield return new object[]
            {
                new Gps
                {
                    Id = 1,
                    Coordinates = "67:15"
                }
            };
            yield return new object[]
            {
                new Gps
                {
                    Id = 2,
                    Coordinates = "39:96"
                }
            };
            yield return new object[]
            {
                new Gps
                {
                    Id = 3,
                    Coordinates = "8:48"
                }
            };
            yield return new object[]
            {
                new Gps
                {
                    Id = 10,
                    Coordinates = "66:99"
                }
            };
            yield return new object[]
            {
                new Gps
                {
                    Id = 16,
                    Coordinates = "35:22"
                }
            };
            yield return new object[]
            {
                new Gps
                {
                    Id = 190,
                    Coordinates = "43:10"
                }
            };
        }

        private static DbSet<T> GetQueryableMockDbSet<T>(params T[] sourceList) where T : class
        {
            var queryable = sourceList.AsQueryable();

            var dbSet = new Mock<DbSet<T>>();
            dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());

            return dbSet.Object;
        }
    }
}
