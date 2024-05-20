using System.ComponentModel.DataAnnotations;

namespace UPQC_RemoteMonitoring.Models
{
	public class EnergyExport
	{
		[Required]
		public int Id { get; set; }
		public double EnergyExported { get; set; }

		public DateTime Date { get; set; }
	}
}
