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
        public DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(
                new Position {  ID = "1", Name = "Standing"},
                new Position { ID = "2", Name = "Sitting" },
                new Position { ID = "3", Name = "Lying down" }
                );

            modelBuilder.Entity<BloodPressure>().HasData(
                new BloodPressure() { BloodPressureId = 1, Systolic=120, Diastolic=80, PositionId = "1", DateTime= new DateTime(2000, 02, 09, 0, 0, 0)},
                new BloodPressure() { BloodPressureId = 2, Systolic = 122, Diastolic = 79, PositionId = "1", DateTime = new DateTime(2000, 01, 09, 0, 0, 0)},
                new BloodPressure() { BloodPressureId = 3, Systolic = 130, Diastolic = 85, PositionId = "1", DateTime = new DateTime(2000, 12, 09, 0, 0, 0)},
                new BloodPressure() { BloodPressureId = 4, Systolic = 230, Diastolic = 85, PositionId = "1", DateTime = new DateTime(2000, 11, 09, 0,0, 0)}
               );
        }
    }
}

