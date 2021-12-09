using System.Runtime.Serialization;
using IoC.StateMachine.Abstractions;
using IoC.StateMachine.Core;
using IoC.StateMachine.Core.Extension;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine;

[DataContract]
public class VacuumContext : ContextBase
{
	public VacuumContext()
	{
		Number = -1;
	}
	[DataMember]
	public int Number { get; set; }
}

[DataContract]
public class VacuumStateMachine : StateMachineBase<VacuumContext>, IStateMachine
{
	public VacuumStateMachine(ISMService smService)
	{

	}

	public static IStateMachineDefinition GetDefinition()
	{
		var def = new StateMachineDefinition();

		def.GetOrCreateState("New")
			.Setup(_=>_.StartPoint = true)
			.Action("InitContext")
			.SetParameter<int>("MaxNumber", 20);

		def.GetOrCreateState("Guess")
			.ExitAction("CheckNumber");

		def.GetOrCreateState("Done")
			.Setup(_ => _.EndPoint = true);

		def.GetOrCreateTran("NewToGuess", "New", "Guess")
			.Trigger("GuessOKTrigger")
			.Setup(_ => _.Inverted = true);

		def.GetOrCreateTran("GuessToDone", "Guess", "Done")
			.Trigger("GuessOKTrigger");

		def.GetOrCreateTran("GuessToGues1", "Guess", "Guess")
			.Trigger("GuessOKTrigger")
			.Setup(_ => _.Inverted = true);


		return def;

	}
}
