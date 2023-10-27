using System.Text.Json.Serialization;

namespace CustomLibrary.Models
{
	public class Subscription
	{
		[JsonPropertyName("plan")]
		public string? Plan { get; set; }

		[JsonPropertyName("status")]
		public string? Status { get; set; }

		[JsonPropertyName("payment_method")]
		public string? PaymentMethod { get; set; }

		[JsonPropertyName("term")]
		public string? Term { get; set; }
	}
}