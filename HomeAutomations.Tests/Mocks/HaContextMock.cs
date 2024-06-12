using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Subjects;
using System.Text.Json;
using System.Threading.Tasks;
using HomeAutomations.Tests.Extensions;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Tests.Mocks;

public record TestServiceCall(string Domain, string Service, ServiceTarget? Target = null, object? Data = null);

public sealed class HaContextMock : IHaContext
{

    public Dictionary<string, EntityState> EntityStates { get; } = new();
    public Subject<StateChange> StateAllChangeSubject { get; } = new();
    public Subject<Event> EventsSubject { get; } = new();
    public ReadOnlyCollection<TestServiceCall> ServiceCalls => new(_serviceCalls);
    public IObservable<StateChange> StateAllChanges() => StateAllChangeSubject;
    public EntityState? GetState(string entityId) => EntityStates.TryGetValue(entityId, out var result) ? result : null;
    public IReadOnlyList<Entity> GetAllEntities() => EntityStates.Keys.Select(s => new Entity(this, s)).ToList();

    private readonly List<TestServiceCall> _serviceCalls = [];

    public void CallService(string domain, string service, ServiceTarget? target = null, object? data = null)
    {
	    var dataElement = new
	    {
		    domain,
		    service,
		    service_data = data
	    };
	    var dataElementJson = JsonSerializer.Serialize(dataElement);
	    var dataElementJsonElement = JsonDocument.Parse(dataElementJson).RootElement;

        _serviceCalls.Add(new TestServiceCall(domain, service, target, data));
        EventsSubject.OnNext(new Event
        {
	        EventType = "call_service",
	        DataElement = dataElementJsonElement
        });
    }

    public Task<JsonElement?> CallServiceWithResponseAsync(string domain, string service, ServiceTarget? target = null, object? data = null)
    {
        throw new NotImplementedException();
    }

    public Area? GetAreaFromEntityId(string entityId) => null;

    public void SendEvent(string eventType, object? data = null)
    { }

    public IObservable<Event> Events => EventsSubject;

    public void TriggerStateChange(Entity entity, string newStateValue, object? attributes = null)
    {
        var newState = new EntityState { State = newStateValue };
        if (attributes != null)
        {
            newState = newState.WithAttributes(attributes);
        }

        TriggerStateChange(entity.EntityId, newState);
    }

    public void TriggerStateChange(string entityId, EntityState newState)
    {
        var oldState = EntityStates.TryGetValue(entityId, out var current) ? current : null;
        EntityStates[entityId] = newState;
        StateAllChangeSubject.OnNext(new StateChange(new Entity(this, entityId), oldState, newState));
    }
}
