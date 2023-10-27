using System.Text.Json.Serialization;

namespace CustomLibrary.Models
{
	public class Employment
	{
		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("key_skill")]
		public string? KeySkill { get; set; }
	}
}