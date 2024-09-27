using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace HomeAutomations.Extensions;

public static class ConfigurationExtensions
{
	public static void LogConfigurationAsJson(this IConfiguration configuration)
	{
		var configDictionary = new Dictionary<string, object>();
		foreach (var section in configuration.GetChildren())
		{
			configDictionary[section.Key] = GetSectionValues(section);
		}

		var json = JsonSerializer.Serialize(configDictionary, new JsonSerializerOptions { WriteIndented = true });
		Console.WriteLine(json);
	}

	private static object GetSectionValues(IConfigurationSection section)
	{
		var children = section.GetChildren().ToList();
		if (children.Count != 0)
		{
			var sectionDictionary = new Dictionary<string, object>();
			foreach (var child in children)
			{
				sectionDictionary[child.Key] = GetSectionValues(child);
			}
			return sectionDictionary;
		}
		return section.Value;
	}
}
