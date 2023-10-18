using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HomeAutomations.Apps.ScaleImporter.Vesync.Models.Responses;

[DataContract]
public class WeightData
{
	[DataMember(Name = "ID")]
	public long Id { get; set; }

	[DataMember(Name = "userId")]
	public string UserId { get; set; }

	[DataMember(Name = "uploadTimestamp")]
	public DateTimeOffset UploadTimestamp { get; set; }

	[DataMember(Name = "weightG")]
	public float WeightGrams { get; set; }

	[DataMember(Name = "impedance")]
	public float Impedance { get; set; }

	[DataMember(Name = "gender")]
	public string Gender { get; set; }

	[DataMember(Name = "age")]
	public int Age { get; set; }

	[DataMember(Name = "heightCm")]
	public float HeightCm { get; set; }

	[DataMember(Name = "subUserID")]
	public string SubUserId { get; set; }

}

[DataContract]
public class WeightDataResult
{
	[DataMember(Name = "weightDatas")]
	public IEnumerable<WeightData> Data { get; set; }
}
