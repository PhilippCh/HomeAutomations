﻿using System.Text.Json.Serialization;

namespace HomeAssistant.Automations.Models.DeviceMessages;

public abstract class ZigbeeDeviceMessage
{
	[JsonPropertyName("battery")]
	public int Battery { get; set; }

	[JsonPropertyName("linkquality")]
	public int LinkQuality { get; set; }

	[JsonPropertyName("voltage")]
	public int Voltage { get; set; }
}
