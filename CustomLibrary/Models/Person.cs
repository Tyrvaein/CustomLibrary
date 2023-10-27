using System.Text.Json.Serialization;

namespace CustomLibrary.Models
{
	public class Person
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("uid")]
		public Guid Uid { get; set; }

		[JsonPropertyName("password")]
		public string? Password { get; set; }

		[JsonPropertyName("first_name")]
		public string? FirstName { get; set; }

		[JsonPropertyName("last_name")]
		public string? LastName { get; set; }

		[JsonPropertyName("username")]
		public string? Username { get; set; }

		[JsonPropertyName("email")]
		public string? Email { get; set; }

		[JsonPropertyName("avatar")]
		public string? Avatar { get; set; }

		[JsonPropertyName("gender")]
		public string? Gender { get; set; }

		[JsonPropertyName("phone_number")]
		public string? PhoneNumber { get; set; }

		[JsonPropertyName("social_insurance_number")]
		public string? SocialInsuranceNumber { get; set; }

		[JsonPropertyName("date_of_birth")]
		public DateTime DateOfBirth { get; set; }

		[JsonPropertyName("employment")]
		public Employment? Employment { get; set; }

		[JsonPropertyName("address")]
		public Address? Address { get; set; }

		[JsonPropertyName("credit_card")]
		public CreditCard? CreditCard { get; set; }

		[JsonPropertyName("subscription")]
		public Subscription? Subscription { get; set; }
	}
}