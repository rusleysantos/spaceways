using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_spaceways.Models
{
    public class Risk
    {
        [Key]
        public int RiskId { get; set; }
        public string TypeRisk { get; set; }   
    }
}
