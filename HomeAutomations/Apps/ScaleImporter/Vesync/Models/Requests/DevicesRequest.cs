using System.Runtime.Serialization;

namespace HomeAutomations.Apps.ScaleImporter.VeSync.Models;

public class DevicesRequest : RequestBody
{
	[DataMember(Name = "pageNo")]
	public string PageNo { get; set; } = "1";

	[DataMember(Name = "pageSize")]
	public string PageSize { get; set; } = "50";

	[DataMember(Name = "method")]
	public override string Method { get; set; } = "devices";
}
