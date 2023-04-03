namespace Template.Domain.User.ValueObjects;

public class Password
{
    public string Value { get; private set; }

    public Password(string value)
    {
        if (value.Length is <= 100 and >= 8)
        {
            Value = value;
        }

        throw new Exceptions.InvalidPasswordLengthException();
    }
}