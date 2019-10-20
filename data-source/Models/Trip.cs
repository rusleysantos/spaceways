using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_spaceways.Models
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }
        public DateTime ExitDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public Script Script { get; set; }
    }
}
