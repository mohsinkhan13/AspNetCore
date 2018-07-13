using CityInfo.Api.Models;
using System.Collections.Generic;

namespace CityInfo.Api
{
    public class CityDataStore
    {
        private List<City> _cities;
        public CityDataStore()
        {
            _cities = new List<City>
            {
                new City{
                    Id =1, Name="London"  ,
                    Description = "Some description",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest() {
                             Id = 1,
                             Name = "Big Ben",
                             Description = "The parliament" },
                          new PointOfInterest() {
                             Id = 2,
                             Name = "Buckingham Palace",
                             Description = "where the queen lives" },
                    }
                },
                new City
                {
                    Id =2,
                    Name ="New York",
                    Description = "Some description",
                    PointsOfInterest =  new List<PointOfInterest>{
                        new PointOfInterest{
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterest {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan."
                        }
                    }
                },
                new City
                {
                    Id =3,
                    Name ="Mumbai",
                    Description = "Busy city of India",
                    PointsOfInterest =  new List<PointOfInterest>{
                        new PointOfInterest{
                            Id = 1,
                            Name = "Gate way of India",
                            Description = "Sea port"
                        },
                        new PointOfInterest {
                            Id = 2,
                            Name = "Juhu beach",
                            Description = "Home to some of the biggest bollywood stars"
                        }
                    }
                },
            };
        }

        public ICollection<City> GetAllCities()
        {
            return _cities;
        }
    }
}
