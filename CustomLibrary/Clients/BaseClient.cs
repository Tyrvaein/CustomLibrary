using CustomLibrary.Interfaces;
using CustomLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary.Clients
{
	public class BaseClient
	{
		public BaseClient(IBaseWebStrategy baseWebStrategy)
		{
			BaseWebStrategy = baseWebStrategy;
		}

		private IBaseWebStrategy BaseWebStrategy { get; set; }

		public async Task<BaseReturnModel> ExecuteStrategy() 
		{ 
			return await BaseWebStrategy.ExecuteWebRequest();
		}
	}
}
