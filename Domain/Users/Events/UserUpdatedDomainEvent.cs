using Domain.Core.Events;

namespace Domain.Users.Events;

public sealed record UserUpdatedDomainEvent(
    Guid UserId, 
    string FirstName,
    string LastName) : DomainEvent;
