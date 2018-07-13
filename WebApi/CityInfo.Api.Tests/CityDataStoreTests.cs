using Xunit;

namespace CityInfo.Api.Tests
{
    public class CityDataStoreTests
    {
        [Fact]
        public void GetAllCities_Test()
        {
            var dataStore = new CityDataStore();

            var cities = dataStore.GetAllCities();

            Assert.NotNull(cities);
        }
    }
}
