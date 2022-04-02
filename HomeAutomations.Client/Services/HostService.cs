using System.Net;
using System.Net.Sockets;

namespace HomeAutomations.Client.Services;

public class HostService
{
	public string? GetLocalIpAddress()
	{
		using Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0);

		socket.Connect("8.8.8.8", 65530);

		if (socket.LocalEndPoint == null)
		{
			return null;
		}

		var endPoint = (IPEndPoint) socket.LocalEndPoint;

		return endPoint.Address.ToString();
	}
}
