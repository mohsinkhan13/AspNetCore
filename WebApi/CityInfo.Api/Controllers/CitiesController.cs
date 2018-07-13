using CityInfo.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api.Controllers
{
    [Route("api/Cities")]
    public class CitiesController : Controller
    {
        private CityDataStore _cityDataStore = new CityDataStore();

        public async Task<IActionResult> GetCities()
        {
            return Ok(_cityDataStore.GetAllCities());
        }

        [Route("{id}")]
        public async Task<IActionResult> GetCity(int id)
        {
            var result = _cityDataStore. GetAllCities().FirstOrDefault(x => x.Id == id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
