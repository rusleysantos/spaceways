﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_spaceways.Models
{
    public class VisitedPlace
    {
        [Key]
        public int VisitedPlaceId { get; set; }
        public Script Script { get; set; }
        public CelestialObject CelestialObject { get; set; }
    }
}
