using CityInfo.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CityInfo.Api.Controllers
{
    [Route("api/Cities")]
    public class CitiesController : Controller
    {
        List<City> _cities = new List<City>
            {
                new City{Id=1, Name="London"  , Description = "Some description"},
                new City{Id=2, Name="New York", Description = "Some description"},
                new City{Id=3, Name="Mumbai"  , Description = "Some description"},
                new City{Id=4, Name="Prague"  , Description = "Some description"}
            };

        public ActionResult GetCities()
        {
            return new JsonResult(_cities);
        }

        [Route("{id}")]
        public ActionResult GetCity(int id)
        {
            var result = _cities.FirstOrDefault(x => x.Id == id);
            if (result == null)
                return new NotFoundResult();

            return new JsonResult(result);
        }
    }
}
