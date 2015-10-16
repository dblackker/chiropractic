using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chiropractic.Models
{
    public class LocationHours
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public string DayOfTheWeek { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public bool IsClosed { get; set; }
    }
}
