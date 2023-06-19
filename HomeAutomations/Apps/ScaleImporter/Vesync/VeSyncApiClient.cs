using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using HomeAutomations.Apps.ScaleImporter.VeSync.Models;
using HomeAutomations.Apps.ScaleImporter.VeSync.Models.Requests;
using HomeAutomations.Apps.ScaleImporter.VeSync.Models.Responses;

namespace HomeAutomations.Apps.ScaleImporter.VeSync;

public class VeSyncApiClient
{
	private const string BaseUrl = "https://smartapi.vesync.com";

	private readonly string _username;
	private readonly string _password;

	public VeSyncApiClient(string username, string password)
	{
		_username = username;
		_password = password;
	}

	public async Task<LoginResult?> LoginAsync() =>
		await QueryApiWithResultAsync<LoginRequest, LoginResult>(
			"/cloud/v1/user/login", new LoginRequest
			{
				Email = _username,
				Password = HashPassword(_password)
			});

	public async Task<SubUsersResult?> GetAllSubUsersAsync(LoginResult userData, string configModule) =>
		await QueryApiWithResultAsync<SubUsersRequest, SubUsersResult>(
			"/cloud/v2/user/getAllSubUserV2", new SubUsersRequest
			{
				Token = userData.Token,
				AccountId = userData.AccountId,
				ConfigModule = configModule
			});

	public async Task<DevicesResult?> GetDevicesAsync(LoginResult userData) =>
		await QueryApiWithResultAsync<DevicesRequest, DevicesResult>(
			"/cloud/v2/deviceManaged/devices", new DevicesRequest
			{
				Token = userData.Token,
				AccountId = userData.AccountId,
			});

	public async Task<WeightDataResult?> GetWeightDataAsync(LoginResult userData, Device device, DateTimeOffset startDate) =>
		await QueryApiWithResultAsync<WeightDataRequest, WeightDataResult>(
			"/cloud/v3/deviceManaged/getWeighingDataV3", new WeightDataRequest
			{
				Token = userData.Token,
				AccountId = userData.AccountId,
				ConfigModule = device.ConfigModule,
				UploadTimestamp = startDate
			});

	private async Task<TResponse?> QueryApiWithResultAsync<TRequest, TResponse>(string method, TRequest request)
	{
		try
		{
			return ReturnNullOnError(
				await BaseUrl
					.AppendPathSegment(method)
					.WithHeader("Content-Type", "application/json")
					.PostJsonAsync(request)
					.ReceiveJson<BaseResponse<TResponse>>()
					.ConfigureAwait(false));
		}
		catch (FlurlHttpException)
		{
			return default;
		}
	}

	private T? ReturnNullOnError<T>(BaseResponse<T> response) => response.Code.Equals("0") ? response.Result : default;

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
