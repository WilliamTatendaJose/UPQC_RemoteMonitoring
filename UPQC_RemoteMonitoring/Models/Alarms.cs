using System.ComponentModel.DataAnnotations;

namespace UPQC_RemoteMonitoring.Models
{
	public class Alarms
	{
		[Required]
		public int Id { get; set; }
		public double Voltage { get; set; }
		public double Current { get; set; }
		public double Energy { get; set; }
		public double PowerFactor { get; set; }
		public double Power { get; set; }

		public DateTime Timestamp { get; set; }
	}
}
