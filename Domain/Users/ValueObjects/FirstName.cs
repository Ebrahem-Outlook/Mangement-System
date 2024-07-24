using Domain.Core.BaseType;

namespace Domain.Users.ValueObjects;

public sealed class FirstName : ValueObject
{
    public const int MaxLength = 50;

    private FirstName(string value) => Value = value;

    public string Value { get; }

    public static FirstName Create(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentException();
        }

        if (firstName.Length <= MaxLength)
        {
            throw new ArgumentException();
        }

        return new FirstName(firstName);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
