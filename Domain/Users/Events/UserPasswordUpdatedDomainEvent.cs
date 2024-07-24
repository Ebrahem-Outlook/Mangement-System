using Domain.Core.Events;

namespace Domain.Users.Events;

public sealed record UserPasswordUpdatedDomainEvent(Guid UserId) : DomainEvent;
