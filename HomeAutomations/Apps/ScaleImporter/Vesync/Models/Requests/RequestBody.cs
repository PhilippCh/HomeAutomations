using System.Runtime.Serialization;

namespace HomeAutomations.Apps.ScaleImporter.VeSync.Models;

public abstract class RequestBody : BaseRequestBody
{
	[DataMember(Name = "accountID")]
	public string AccountId { get; set; }

	[DataMember(Name = "token")]
	public string Token { get; set; }

	[DataMember(Name = "uuid")]
	public string Uuid { get; set; }
}
