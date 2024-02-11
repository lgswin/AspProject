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

        [Required(ErrorMessage ="Please select a position")]
		public string? PositionId { get; set; }

		public Position? Position { get; set; }

        public string Category
        {
            get
            {
                if (Systolic < 120 && Diastolic < 80)
                {
                    return "Normal";
                }
                else if (Systolic >= 120 && Systolic <= 129 && Diastolic < 80)
                {
                    return "Elevated";
                }
                else if ((Systolic >= 130 && Systolic <= 139) || (Diastolic >= 80 && Diastolic <= 89))
                {
                    return "High Blood Pressure (Hypertension) Stage 1";
                }
                else if (Systolic >= 140 || Diastolic >= 90)
                {
                    return "High Blood Pressure (Hypertension) Stage 2";
                }
                else if (Systolic > 180 || Diastolic > 120)
                {
                    return "Hypertensive Crisis";
                }
                else
                {
                    return "Unknown Category";
                }
            }
        }
    }
}

