using CustomLibrary;
using System;
using Xunit;

namespace TestCustomLibrary
{
	public class ConverterServiceTests
	{
		[Fact]
		public void CopyProperties_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var source = new SourceClass();
			var dest = new DestClass();

			// Act
			dest = ConverterService.MapProperties<DestClass>(source);

			// Assert
			Assert.True(source.Int1 == dest.Int1);
			Assert.True(source.Int2 == dest.Int4);
			Assert.True(source.Int3 == dest.Int5);
			Assert.True(source.String1 == dest.String1);
			Assert.True(source.String2 == dest.String2);
			Assert.True(source.String3 == dest.String3);
		}
	}
	public class SourceClass
	{
		[MappingAttribute("Prop1")]
		public int Int1 { get; set; } = 1;
		[MappingAttribute("Prop2")]
		public string String1 { get; set; } = "1";
		[MappingAttribute("Prop3")]
		public int Int2 { get; set; }=2;
		[MappingAttribute("Prop4")]
		public string String2 { get; set; } = "2";
		[MappingAttribute("Prop5")]
		public int Int3 { get; set; } = 3;
		[MappingAttribute("Prop6")]
		public string String3 { get; set; } = "3";
	}
	public class DestClass
	{
		[MappingAttribute("Prop1")]
		public int Int1 { get; set; }
		[MappingAttribute("Prop2")]
		public string String1 { get; set; }
		[MappingAttribute("Prop3")]
		public int Int4 { get; set; }
		[MappingAttribute("Prop4")]
		public string String2 { get; set; }
		[MappingAttribute("Prop5")]
		public int Int5 { get; set; }
		[MappingAttribute("Prop6")]
		public string String3 { get; set; } 
	}

	

}
