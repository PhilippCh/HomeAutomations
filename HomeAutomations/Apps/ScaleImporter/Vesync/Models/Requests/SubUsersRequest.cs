using System.Runtime.Serialization;

namespace HomeAutomations.Apps.ScaleImporter.VeSync.Models.Requests;

public class SubUsersRequest : RequestBody
{
	[DataMember(Name = "method")]
	public override string Method { get; set; } = "getAllSubUserV2";

	[DataMember(Name = "configModule")]
	public string ConfigModule { get; set; }

	[DataMember(Name = "pageSize")]
	public int PageSize { get; set; } = 300;

	[DataMember(Name = "isAsc")]
	public bool IsAsc { get; set; }
}
