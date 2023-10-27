using CustomLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary.TestData
{
	public class TestEntity
	{
		[Mapping("Id")]
		public int Id { get; set; } = 1;
		public string Name { get; set; } = "Entity";
		public string Description { get; set; } = "This is an Entiyt";
		public string Type { get; set; } = "Entity";

		[Mapping("Date")]
		public DateTime DateTime { get; set; }= DateTime.Now;
	}
}
