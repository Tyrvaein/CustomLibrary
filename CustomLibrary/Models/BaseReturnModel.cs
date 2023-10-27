using System.Net;

namespace CustomLibrary.Models
{
	public class BaseReturnModel
	{
		public object? Result { get; set; }
		public string? Error { get; set; }
	}
}