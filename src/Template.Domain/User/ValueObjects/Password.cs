namespace Template.Domain.User.ValueObjects;

public class Password
{
    public string Value { get; private set; }

    public Password(string value)
    {
        if (value.Length is not (<= 100 and >= 8))
            throw new Exceptions.InvalidPasswordLengthException();
        Value = value;
    }
}