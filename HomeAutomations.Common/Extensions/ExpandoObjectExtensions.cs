using System.Dynamic;

namespace HomeAutomations.Common.Extensions;

public static class ExpandoObjectExtensions
{
	public static void Add(this ExpandoObject target, string key, object value)
	{
		var d = (IDictionary<string, object>) target;
		d[key] = value;
	}
}
