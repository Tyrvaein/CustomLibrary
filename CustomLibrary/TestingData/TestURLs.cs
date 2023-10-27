using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary.TestData
{
	public static class TestURLs
	{
		public static string GetRandomUserListTestUrl(int count) {
			return "https://random-data-api.com/api/v2/users?size={count}";
		}
		public static string GetRandomBeerListTestUrl(int count)
		{
			return "https://random-data-api.com/api/v2/beers?size={count}";
		}
		
	}
}
