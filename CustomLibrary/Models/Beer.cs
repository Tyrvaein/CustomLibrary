using System.Text.Json.Serialization;

namespace CustomLibrary.Models
{
	public class Beer
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("uid")]
		public Guid Uid { get; set; }

		[JsonPropertyName("brand")]
		public string? Brand { get; set; }

		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("style")]
		public string? Style { get; set; }

		[JsonPropertyName("hop")]
		public string? Hop { get; set; }

		[JsonPropertyName("yeast")]
		public string? Yeast { get; set; }

		[JsonPropertyName("malts")]
		public string? Malts { get; set; }

		[JsonPropertyName("ibu")]
		public string? Ibu { get; set; }

		[JsonPropertyName("alcohol")]
		public string? Alcohol { get; set; }

		[JsonPropertyName("blg")]
		public string? Blg { get; set; }
	}

}
