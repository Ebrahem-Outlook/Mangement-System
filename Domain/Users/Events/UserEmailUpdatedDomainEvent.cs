using Domain.Core.Events;

namespace Domain.Users.Events;

public sealed record UserEmailUpdatedDomainEvent(
    Guid UserId, 
    string Email) : DomainEvent;
