namespace HomeAutomations.Common.Services.Bluetooth.AtCommands.Events;

public enum EventCode
{
	Unknown = -1,
	ConnectionEstablished = 256,
	DisconnectionEvent = 258,
	AdvertisingOperationCompleted = 260,
	ConnectionParametersUpdated = 263,
	PairingRequest = 264,
	PairingCompleted = 265,
	SecurityRequestFromPeer = 266,
	PasskeyRequest = 268,
	SecurityLevelChangedIndication = 269,
	SetSecurityLevelFailed = 271,
	ConnectionParametersUpdateCompleted = 272,
	DataLengthChanged = 273,
	NumericRequest = 276,
	LongTermKeyMissing = 278,
	SpsServiceEvent = 279,
	ServiceFoundDuringBrowsingProcedure = 768,
	BrowsingProcedureCompleted = 769,
	ServiceFoundDuringDiscovery = 770,
	IncludedServiceFoundDuringDiscovery = 771,
	CharacteristicFoundDuringDiscovery = 772,
	CharacteristicDescriptorFoundDuringDiscovery = 773,
	DiscoveryCompleted = 774,
	ReadAttributeValueCompleted = 775,
	WriteAttributeValueCompleted = 776,
	ValueNotificationReceived = 777,
	ValueIndicationReceived = 778
}
