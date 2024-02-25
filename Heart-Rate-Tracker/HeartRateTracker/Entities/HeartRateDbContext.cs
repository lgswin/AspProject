using System;
using Microsoft.EntityFrameworkCore;

namespace HeartRateTracker.Entities
{
	public class HeartRateDbContext : DbContext
	{
		public HeartRateDbContext(DbContextOptions<HeartRateDbContext> dbContextOptions) : base(dbContextOptions)
		{

		}

		public DbSet<HeartRateMeasurement> HeartRateMeasurements { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<HeartRateMeasurement>().HasData(
				new HeartRateMeasurement()
				{
					HeartRateMeasurementId = 1,
					BPMValue = 148,
					MeasurementDate = DateTime.Now.AddDays(-5),
					Position = "Standing"
				},

				new HeartRateMeasurement()
				{
					HeartRateMeasurementId = 2,
					BPMValue = 148,
					MeasurementDate = DateTime.Now.AddDays(-1),
					Position = "Standing"
				},

				new HeartRateMeasurement()
				{
					HeartRateMeasurementId = 3,
					BPMValue = 148,
					MeasurementDate = DateTime.Now.AddDays(-4),
					Position = "Standing"
				}

			);
		}
	}
}

