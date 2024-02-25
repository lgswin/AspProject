using System;
using System.ComponentModel.DataAnnotations;

namespace HeartRateTracker.Entities
{
	public class HeartRateMeasurement
    {
        public int HeartRateMeasurementId { get; set; }

        [Required(ErrorMessage = " BPM value is required")]
        [Range(30, 300, ErrorMessage = " BPM Value should be in range of 30 to 300")]
        public int? BPMValue { get; set; }

        [Required(ErrorMessage = "Messagement Date is required")]
        public DateTime? MeasurementDate { get; set; }

        public string? Position { get; set; }
    }
}

