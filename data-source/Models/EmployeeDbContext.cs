using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using web_spaceways.Models;

namespace data_source.Models
{

    public class EmployeeDbContext : DbContext
    {
        [Key]
        public int EmployeeDbContextId { get; set; }

        public DbSet<EmployeeDbContext> DbContext { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\git\\spaceways\\data-source\\DataBase.mdf;Integrated Security=True;");
        }

        public EmployeeDbContext() : base()
        {
        }


        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<CelestialObject> CelestialObjects { get; set; }
        DbSet<Profile> Profiles { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<Risk> Risks { get; set; }
        DbSet<Script> Scripts { get; set; }
        DbSet<Trip> Travels { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<VisitedPlace> VisitedPlaces { get; set; }

    }
}
