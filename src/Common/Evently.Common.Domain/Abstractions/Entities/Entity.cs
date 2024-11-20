using Evently.Common.Domain.Abstractions.DomainEvents;

namespace Evently.Common.Domain.Abstractions.Entities;

public abstract class Entity
{
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.ToList();
    private readonly List<IDomainEvent> _domainEvents = [];

    protected void Raise(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}
