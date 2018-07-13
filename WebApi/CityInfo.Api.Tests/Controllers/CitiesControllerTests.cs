using CityInfo.Api.Controllers;
using CityInfo.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Xunit;

namespace CityInfo.Api.Tests.Controllers
{
    public class CitiesControllerTests
    {
        [Fact]
        public async Task GetCities_ReturnsOk()
        {
            var controller = new CitiesController();

            var result = await controller.GetCities();

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task GetCity_ReturnsOk()
        {
            var controller = new CitiesController();

            var result = await controller.GetCity(1);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task GetCity_ReturnObjectDeserialilzableToCityObject()
        {
            var controller = new CitiesController();

            var result = await controller.GetCity(1) as OkObjectResult;
            var city = result.Value as City;

            Assert.IsType<City>(city);
        }

        [Fact]
        public async Task  GetCity_ReturnsCorrectCity()
        {
            var controller = new CitiesController();

            var result = await controller.GetCity(1) as OkObjectResult;
            var city = result.Value as City;

            Assert.Equal(1,city.Id);
        }

    }
}
