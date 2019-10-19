using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_spaceways.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public string Interest { get; set; }
        public Risk Risk { get; set; }
    }
}
