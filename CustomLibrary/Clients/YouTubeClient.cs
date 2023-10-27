using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CustomLibrary.Clients
{
	public class YouTubeClient
	{
			public async Task<string> GetYoutubeSearchResult(string apiKey,string searchParameter)
			{


			using var  client = new HttpClient();
			
			var apiUrl = "https://youtube.googleapis.com/youtube/v3/search?q={searchParameter}&key={apiKey}";
			// Sende eine GET-Anfrage an die YouTube-API.
			var response = await client.GetAsync(apiUrl);

			// Überprüfe den Antwortcode.
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				// Verarbeite die Antwort.
				var data = (response.Content.ReadAsStringAsync().Result);
				Console.WriteLine(data);
				return data;
			}
			return response.StatusCode.ToString();
		}

	}
}
