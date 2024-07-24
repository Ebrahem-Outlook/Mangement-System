using Domain.Core.BaseType;

namespace Domain.Users.ValueObjects;

public sealed class LastName : ValueObject
{
    public const int MaxLength = 50;

    private LastName(string value) => Value = value;

    public string Value { get; }

    public static LastName Create(string lastName)
    {

        if (string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException();
        }

        if (lastName.Length <= MaxLength)
        {
            throw new ArgumentException();
        }

        return new LastName(lastName);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
