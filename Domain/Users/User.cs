using Domain.Core.BaseType;
using Domain.Users.Events;
using Domain.Users.ValueObjects;

namespace Domain.Users;

public sealed class User : AggregateRoot
{
    private string PasswordHash = default!;

    private User(FirstName firstName, LastName lastName, Email email, string passwordHash) : base(Guid.NewGuid())
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordHash = passwordHash;
    }

    private User() { }

    public FirstName FirstName { get; private set; } = default!;
    public LastName LastName { get; private set; } = default!;
    public Email Email { get; private set; } = default!;
    
    
    public static User Create(FirstName firstName, LastName lastName, Email email, string passwordHash)
    {
        User user = new(firstName, lastName, email, passwordHash);

        user.Raise(new UserCreatedDomainEvent(user.Id, user.FirstName.Value, user.LastName.Value, user.Email.Value));

        return user;
    }
    
    public void Update(FirstName firstName, LastName lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        Raise(new UserUpdatedDomainEvent(Id, FirstName.Value, LastName.Value));
    }

    public void UpdateEmail(Email email)
    {
        Email = email;

        Raise(new UserEmailUpdatedDomainEvent(Id, Email.Value));
    }

    public void UpdatePassword(string PasswordHash)
    {
        // Edit in Futher
        this.PasswordHash = PasswordHash;

        Raise(new UserPasswordUpdatedDomainEvent(Id));
    }
}
