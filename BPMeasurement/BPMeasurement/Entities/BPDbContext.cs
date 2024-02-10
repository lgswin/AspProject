using System;
using Microsoft.EntityFrameworkCore;

namespace BPMeasurement.Entities
{
    public class BPDbContext : DbContext
	{
		public BPDbContext(DbContextOptions<BPDbContext> option) : base(option)
		{
		}

		public DbSet<BloodPressure> BloodPressures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BloodPressure>().HasData(
                new BloodPressure() { BloodPressureId = 1, Systolic=120, Diastolic=80, DateTime="2000-02-09"},
                new BloodPressure() { BloodPressureId = 2, Systolic = 122, Diastolic = 79, DateTime = "2010-02-09" },
                new BloodPressure() { BloodPressureId = 3, Systolic = 130, Diastolic = 85, DateTime = "1996-02-09" },
                new BloodPressure() { BloodPressureId = 4, Systolic = 230, Diastolic = 85, DateTime = "1996-02-09" }
               );
        }
    }
}

