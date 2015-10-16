using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chiropractic.Models
{
    public class User
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserLocation> Locations { get; set; }
    }
}
