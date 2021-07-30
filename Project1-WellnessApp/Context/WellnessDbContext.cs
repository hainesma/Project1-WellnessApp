using Microsoft.EntityFrameworkCore;
using Project1_WellnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_WellnessApp.Context
{
    public class WellnessDbContext: DbContext
    {
        public DbSet<UserProfile> userProfiles { get; set; }
        public DbSet<FoodRegime> foodRegimes { get; set; }
        public DbSet<PhilosophySchool> philosophySchools { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public WellnessDbContext(DbContextOptions options) : base(options) { }
        public WellnessDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=WellnessDb;Trusted_Connection=True;");
        }
    }
}
