using System;
using System.ComponentModel.DataAnnotations;

namespace BPMeasurement.Entities
{
	public class BloodPressure
	{
		public int BloodPressureId { get; set; }
		public int Systolic { get; set; }
		public int Diastolic { get; set; }

		[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateTime { get; set; }

		public string PositionId { get; set; }
		public Position Position { get; set; }
    }
}

