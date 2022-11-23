using System.Reactive.Linq;
using System.Reactive.Subjects;
using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Commands;

public abstract class AtCommand : IAtCommand
{
	public int Id { get; private set; }
	public abstract string CommandString { get; }

	public IObservable<IAtResult> Observable => _subject.AsObservable();

	private readonly Subject<IAtResult> _subject = new();

	public virtual void ProcessCommandResult(AtCommandService commandService, CommandAtResult result)
	{
		Id = result.Id;
	}

	public virtual void ProcessAckResult(AtCommandService commandService, AckAtResult result)
	{
	}

	public virtual void ProcessResponseResult(AtCommandService commandService, ResponseAtResult result)
	{
	}

	public virtual void ProcessEndResult(AtCommandService commandService, EndAtResultMessage result)
	{
		Success(result);
		commandService.RemoveCommand(this);
	}

	protected void Value(IAtResult result)
	{
		_subject.OnNext(result);
	}

	protected void Success(IAtResult result)
	{
		_subject.OnNext(result);
		_subject.OnCompleted();
	}
}
