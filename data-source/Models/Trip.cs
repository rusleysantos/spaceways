using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_spaceways.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public DateTime ExitDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public Script Script { get; set; }
    }
}
