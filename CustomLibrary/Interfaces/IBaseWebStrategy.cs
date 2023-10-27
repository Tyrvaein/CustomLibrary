using CustomLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary.Interfaces
{
	public interface IBaseWebStrategy
	{
		public Task<BaseReturnModel> ExecuteWebRequest(); 
	}
}
