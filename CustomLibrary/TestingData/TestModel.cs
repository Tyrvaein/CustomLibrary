using CustomLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCustomLibrary.TestData
{
	public class TestModel
	{
		[Mapping("Id")]
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		[Mapping("Type", "HH:mm:ss")]
		public string? Type { get; set; }

		[Mapping("Date","HH:mm:ss")]
		public DateTime DateTime { get; set; }
	}
}
