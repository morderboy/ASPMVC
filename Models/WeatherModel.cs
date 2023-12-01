using System.ComponentModel.DataAnnotations;

namespace ASPMVC.Models
{
	public class WeatherModel
	{
		[Key]
		public required int Id { get; set; }
		public DateTime UploadTime { get; set; } = DateTime.Now;

		public required int Temperature { get; set; }

		public string? Type { get; set; }
	}
}
