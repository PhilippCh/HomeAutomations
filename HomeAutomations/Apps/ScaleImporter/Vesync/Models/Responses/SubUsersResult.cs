using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HomeAutomations.Apps.ScaleImporter.VeSync.Models.Responses;

public record SubUser
{
	[DataMember(Name = "subUserID")]
	public string Id { get; init; }

	[DataMember(Name = "nickname")]
	public string Nickname { get; init; }
}

public class SubUsersResult
{
	[DataMember(Name = "subUsers")]
	public IEnumerable<SubUser> SubUsers { get; set; }
}
