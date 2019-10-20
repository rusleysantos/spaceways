using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_spaceways.Models
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public string Interest { get; set; }
        public Risk Risk { get; set; }
    }
}
