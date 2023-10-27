using System.Text.Json.Serialization;

namespace CustomLibrary.Models
{
	public class Address
	{
		[JsonPropertyName("city")]
		public string? City { get; set; }

		[JsonPropertyName("street_name")]
		public string? StreetName { get; set; }

		[JsonPropertyName("street_address")]
		public string? StreetAddress { get; set; }

		[JsonPropertyName("zip_code")]
		public string? ZipCode { get; set; }

		[JsonPropertyName("state")]
		public string? State { get; set; }

		[JsonPropertyName("country")]
		public string? Country { get; set; }

		[JsonPropertyName("coordinates")]
		public Coordinates? Coordinates { get; set; }
	}
}