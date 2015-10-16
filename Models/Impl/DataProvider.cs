using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chiropractic.Models
{
    public class DataProvider : IDataProvider
    {
        public User GetUser(int Id)
        {
            // TODO: Fake data for now until database api is in place.
            return new User()
            {
                Id = 1,
                Name = "Sioux Falls Chiropractic",
                Locations = new List<UserLocation>() {
                  new UserLocation() {
                    Id = 1,
                    UserId = 1,
                    Name = "Sioux Falls Chiropractic",
                    Address1 = "830 E 41st St",
                    Address2 = "",
                    City = "Sioux Falls",
                    LocationAbbreviation = "SD",
                    Zipcode = "57105",
                    Hours = new List<LocationHours>() {
                        new LocationHours() {
                            Id = 1,
                            LocationId = 1,
                            DayOfTheWeek = "Monday",
                            OpenTime = DateTime.Now,
                            CloseTime = DateTime.Now,
                            IsClosed = false
                        }
                    }
                  }
              }
            };
        }
    }
}
