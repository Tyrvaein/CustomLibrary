using System.Text.Json.Serialization;

namespace CustomLibrary.Models
{
	public class CreditCard
	{
		[JsonPropertyName("cc_number")]
		public string? CcNumber { get; set; }
	}
}