using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chiropractic.Models
{
    public class UserLocation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string LocationAbbreviation { get; set; }
        public string Zipcode { get; set; }
        public List<LocationHours> Hours { get; set; }
    }
}
