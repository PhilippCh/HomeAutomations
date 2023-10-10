namespace HomeAutomations.Models;

public interface ICompoundTrigger
{
	IObservable<bool?> GetTrigger();
}
