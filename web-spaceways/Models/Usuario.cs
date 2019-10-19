using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_spaceways.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public Profile Profile { get; set; }

    }
}
