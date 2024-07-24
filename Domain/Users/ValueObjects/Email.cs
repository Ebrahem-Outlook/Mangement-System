using Domain.Core.BaseType;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Domain.Users.ValueObjects;

public sealed class Email : ValueObject
{
    public const int MaxLength = 50;

    private Email(string value) => Value = value;

    public string Value { get; }

    public static Email Create(string email)
    {

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email cannot be empty.");

        if (!IsValidEmail(email))
            throw new ArgumentException("Invalid email format.");

        if (email.Length >= MaxLength)
            throw new ArgumentException();

        return new Email(email);
    }

    private static bool IsValidEmail(string email)
    {
        // Simple regex for demonstration. You may use a more sophisticated regex if needed.
        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
        return emailRegex.IsMatch(email);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
