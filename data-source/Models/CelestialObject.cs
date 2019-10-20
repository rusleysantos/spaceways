using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_spaceways.Models
{
    public class CelestialObject
    {
        [Key]
        public int ObjectId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Distance { get; set; }
        public string Orbit { get; set; }
        public string Rotation { get; set; }
        public string Formation { get; set; }
        public string Facts { get; set; }
        public string Culture { get; set; }
        public string Atmosphere { get; set; }
        public double Temperature { get; set; }
        public string Observations { get; set; }
    }
}
