using System.Text.Json.Serialization;

namespace CustomLibrary.Models
{
	public class Coordinates
	{
		[JsonPropertyName("lat")]
		public double Lat { get; set; }

		[JsonPropertyName("lng")]
		public double Lng { get; set; }
	}
}