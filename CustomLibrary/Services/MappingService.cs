

using CustomLibrary.Attributes;
using System.Globalization;
using System.Reflection;

namespace CustomLibrary.Services
{
	public static class MappingService
	{
		public static TTarget MapProperties<TTarget>(object source) where TTarget : new() { 
		

			// Retrieve the types of the source and destination objects.
			Type sourceType = source.GetType();
			Type targetType =typeof(TTarget);
			TTarget tempTarget = new();
			// Get all the properties of the source and destination objects.
			PropertyInfo[] sourceProperties = sourceType.GetProperties();
			PropertyInfo[] destProperties = targetType.GetProperties();

			foreach (PropertyInfo sourceProp in sourceProperties)
			{
				// Check if the source property has a MappingAttribute.
				MappingAttribute mappingAttribute = destProperties.FirstOrDefault(p =>
						p?.GetCustomAttribute<MappingAttribute>()?.Name == sourceProp?.GetCustomAttribute<MappingAttribute>()?.Name)?.GetCustomAttribute<MappingAttribute>();
				if (mappingAttribute != null)
				{
					// Find the corresponding destination property with the same description.
					PropertyInfo destProp = destProperties.FirstOrDefault(p =>
						p.GetCustomAttribute<MappingAttribute>()?.Name == mappingAttribute.Name);
				
					var format = destProp?.GetCustomAttribute<MappingAttribute>()?.Format??null;
					if (destProp != null && sourceProp.PropertyType == destProp.PropertyType)
					{
					
						var value= Convert.ChangeType(sourceProp.GetValue(source), destProp.PropertyType);
						
						// Map the property values from source to destination.
						destProp.SetValue(tempTarget, value);
					}
				}
			}
			return tempTarget;
		}
	}


}
