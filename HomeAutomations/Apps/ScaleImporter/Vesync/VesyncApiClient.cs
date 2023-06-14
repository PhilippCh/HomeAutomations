using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using HomeAutomations.Apps.ScaleImporter.Vesync.Models;
using Newtonsoft.Json;

namespace HomeAutomations.Apps.ScaleImporter.Vesync;

public class VesyncApiClient
{
	private const string BaseUrl = "https://smartapi.vesync.com";

	private readonly string _username;
	private readonly string _password;

	public VesyncApiClient(string username, string password)
	{
		_username = username;
		_password = password;
	}

	public async Task<BaseResponse<LoginResult>?> LoginAsync()
	{
		var body = new LoginBody
		{
			Email = _username,
			Password = HashPassword(_password)
		};

		var response = await BaseUrl
			.AppendPathSegment("/cloud/v1/user/login")
			.WithHeader("Content-Type", "application/json")
			.PostJsonAsync(body)
			.ReceiveString()
			.ConfigureAwait(false);

		return JsonConvert.DeserializeObject<BaseResponse<LoginResult>>(response);
	}

	public async Task<BaseResponse<DevicesResult>> GetDevicesAsync(LoginResult userData)
	{
		var body = new DevicesRequest
		{
			Token = userData.Token,
			AccountId = userData.AccountId,
		};

		return await BaseUrl
			.AppendPathSegment("/cloud/v2/deviceManaged/devices")
			.WithHeader("Content-Type", "application/json")
			.PostJsonAsync(body)
			.ReceiveJson<BaseResponse<DevicesResult>>()
			.ConfigureAwait(false);
	}

	public async Task<BaseResponse<WeightDataResult>> GetWeightData(LoginResult userData, Device device, DateTimeOffset startDate)
	{
		var body = new WeightDataRequest
		{
			Token = userData.Token,
			AccountId = userData.AccountId,
			ConfigModule = device.ConfigModule,
			UploadTimestamp = startDate
		};

		return await BaseUrl
			.AppendPathSegment("/cloud/v3/deviceManaged/getWeighingDataV3")
			.WithHeader("Content-Type", "application/json")
			.PostJsonAsync(body)
			.ReceiveJson<BaseResponse<WeightDataResult>>()
			.ConfigureAwait(false);
	}

	private string HashPassword(string password)
	{
		using var md5Hash = MD5.Create();

		// Convert the input string to a byte array and compute the hash.
		var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

		// Create a new Stringbuilder to collect the bytes
		// and create a string.
		var sBuilder = new StringBuilder();

		// Loop through each byte of the hashed data
		// and format each one as a hexadecimal string.
		foreach (var t in data)
		{
			sBuilder.Append(t.ToString("x2"));
		}

		return sBuilder.ToString();
	}
}
