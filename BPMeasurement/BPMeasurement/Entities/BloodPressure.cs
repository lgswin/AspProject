using System;
namespace BPMeasurement.Entities
{
	public class BloodPressure
	{
		public int BloodPressureId { get; set; }
		public int Systolic { get; set; }
		public int Diastolic { get; set; }
        public string? DateTime { get; set; }
	}
}

