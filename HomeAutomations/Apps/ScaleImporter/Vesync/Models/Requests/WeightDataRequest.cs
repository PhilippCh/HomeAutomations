using System.Globalization;
using System.Runtime.Serialization;

namespace HomeAutomations.Apps.ScaleImporter.VeSync.Models;

public class WeightDataRequest : RequestBody
{
	[DataMember(Name = "allData")]
	public bool AllData { get; set; } = true;

	[DataMember(Name = "configModule")]
	public string ConfigModule { get; set; }

	[DataMember(Name = "desc")]
	public bool Desc { get; set; }

	[DataMember(Name = "page")]
	public int Page { get; set; } = 1;

	[DataMember(Name = "pageSize")]
	public int PageSize { get; set; } = 100;

	[DataMember(Name = "method")]
	public override string Method { get; set; } = "getWeighingDataV3";

	public DateTimeOffset UploadTimestamp { get; set; } = DateTimeOffset.Now;

	[DataMember(Name = "userCountryCode")]
	public string UserCountryCode { get; set; } = "DE";

	[DataMember(Name = "weightUnit")]
	public string WeightUnit { get; set; } = "kg";

	[DataMember(EmitDefaultValue = false, Name = "uploadTimestamp")]
	public string UploadTimestampFormatted
	{
		get => this.UploadTimestamp.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss", CultureInfo.InvariantCulture);
	}
}
