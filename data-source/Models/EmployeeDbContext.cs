using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using web_spaceways.Models;

namespace data_source.Models
{
    public class EmployeeDbContext : DbContext
    {

        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<CelestialObject> CelestialObjects { get; set; }
        DbSet<Profile> Profiles { get; set; }
        DbSet<Risk> Risks { get; set; }
        DbSet<Script> Scripts { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<VisitedPlace> VisitedPlaces { get; set; }
    }
}
