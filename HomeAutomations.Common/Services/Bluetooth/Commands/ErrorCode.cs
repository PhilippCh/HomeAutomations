namespace HomeAutomations.Common.Services.Bluetooth.Commands;

public enum ErrorCode
{
	Success,
	GenericFailure,
	AlreadyDone,
	OperationAlreadyInProgress,
	InvalidParameter,
	NotAllowed,
	NotConnected,
	NotSupported,
	NotAccepted,
	Busy,
	RequestTimedOut,
	NotSupportedByPeer,
	CanceledByUser,
	EncryptionKeyMissing,
	InsufficientResources,
	NotFound,
	NoCreditsAvailableOnL2CapCoC,
	MtuExceededOnL2CapCoC,
	InsufficientBandwidth
}
