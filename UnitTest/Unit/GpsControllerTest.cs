using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using WebAPI.Controllers;
using WebAPI.EntityFramework.Repositories;
using WebAPI.Models;
using Xunit;

namespace UnitTest
{
    //[TestClass]
    //public class GPSControllerTest
    //{
    //    [Fact]
    //    public async Task GpsController_Get_Should_ReturnSuccessCode()
    //    {
    //        var mockRepo = new Mock<GpsRepository>();
    //        mockRepo.Setup(repo => repo.GetAll()).

    //        var controller = new GpsController(mockRepo.Object);

    //        Gps gpsObject = new Gps();

    //        var repo = new Mock<GpsRepository>();
    //        var controller = new Mock<GpsController>(repo);

    //        controller.Setup(repo => repo.Get(40000)).Returns(gpsObject);
    //    }
    //}
}
