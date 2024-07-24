namespace Domain.Core.Events;

public record DomainEvent : IDomainEvent
{
    public DomainEvent()
    {
        EventId = Guid.NewGuid();
        CreatedOn = DateTime.UtcNow;
    }

    public Guid EventId { get; }

    public DateTime CreatedOn { get; }
}
