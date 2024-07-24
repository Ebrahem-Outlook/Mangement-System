using MediatR;

namespace Domain.Core.Events;

public interface IDomainEvent : INotification
{
    Guid EventId { get; }
    DateTime CreatedOn { get; }
}
