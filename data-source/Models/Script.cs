using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_spaceways.Models
{
    public class Script
    {
        [Key]
        public int ScriptId { get; set; }
        public Profile Profile { get; set; }
        public string Observation { get; set; }

    }
}
