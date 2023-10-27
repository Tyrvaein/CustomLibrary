using CustomLibrary.Interfaces;
using CustomLibrary.Models;
using CustomLibrary.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomLibrary.Strategies
{
	public class RandomUserStrategy : IBaseWebStrategy
	{
		public async Task<BaseReturnModel> ExecuteWebRequest()
		{
			var url = TestURLs.GetRandomUserListTestUrl(10);
			using (var client = new HttpClient()) {
				try
				{
					var res = await client.GetAsync(url);
					var content = await res.Content.ReadAsStringAsync();
					var serialized = JsonSerializer.Deserialize<List<Beer>>(content);
					return new BaseReturnModel { Result = serialized! };
				}
				catch (Exception ex)
				{

					return new BaseReturnModel { Error = ex.Message };
				}
			
			}
		}
	}

}
