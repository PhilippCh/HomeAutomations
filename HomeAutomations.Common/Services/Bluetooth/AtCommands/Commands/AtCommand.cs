using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace HomeAutomations.Common.Services.Bluetooth.AtCommands.Commands;

public abstract class AtCommand : IAtCommand
{
	public int Id { get; private set; }
	public abstract string CommandString { get; }

	public IObservable<ResponseAtResult> Observable => _subject.AsObservable();

	private readonly Subject<ResponseAtResult> _subject = new();

	public virtual void ProcessCommandResult(CommandAtResult result)
	{
		Id = result.Id;
	}

	public virtual void ProcessAckResult(AckAtResult result)
	{
	}

	public virtual void ProcessResponseResult(ResponseAtResult result)
	{
	}

	public virtual void ProcessEndResult(EndAtResultMessage result)
	{
		Success();
	}

	protected void Success()
	{
		_subject.OnCompleted();
	}
}
