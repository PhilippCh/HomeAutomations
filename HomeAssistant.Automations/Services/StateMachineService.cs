using System;
using IoC.StateMachine.Abstractions;

namespace HomeAssistant.Automations.Services;

public class StateMachineService
{
	private readonly ISMService _smService;

	public StateMachineService(ISMService smService)
	{
		_smService = smService;
	}

	public T Start<T>(IStateMachineDefinition definition, ISMParameters? parameters = default) where T : class, IStateMachine
	{
		var sm = _smService.Start<T>(parameters, definition);
		Push(sm, null);

		return sm;
	}

	public void Push(IStateMachine stateMachine, ISMParameters? parameters) => _smService.Push(stateMachine, parameters);
}
