using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary.Attributes
{
	[AttributeUsage(AttributeTargets.Property)]
	public class MappingAttribute: Attribute
	{
		public MappingAttribute(string name)
		{
			Name = name;
		}

		public MappingAttribute(string name, string format )
		{
			Name = name;
			Format = format ;
		
		}

		public string Name { get; }
		public string? Format { get;  }
	
	}
}
