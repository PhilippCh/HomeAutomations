using System.Runtime.Serialization;

namespace HomeAutomations.Apps.ScaleImporter.VeSync.Models;

[DataContract]
public abstract class BaseRequestBody
{
	[DataMember(Name = "timeZone")]
	public string TimeZone { get; set; } = "Europe/Berlin";

	[DataMember(Name = "acceptLanguage")]
	public string AcceptLanguage { get; set; } = "en";

	[DataMember(Name = "method")]
	public abstract string Method { get; set; }

	[DataMember(Name = "appVersion")]
	public string AppVersion { get; set; } = "VeSync 3.0.54";

	[DataMember(Name = "phoneBrand")]
	public string PhoneBrand { get; set; } = "SM N9005";

	[DataMember(Name = "phoneOS")]
	public string PhoneOS { get; set; } = "Android";

	[DataMember(Name = "traceId")]
	public string TraceId { get; set; } = "142312341234";

	[DataMember(Name = "debugMode")]
	public bool DebugMode { get; set; } = true;

	[DataMember(Name = "deviceRegion")]
	public string DeviceRegion { get; set; } = "DE";
}
