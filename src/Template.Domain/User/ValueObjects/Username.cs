namespace Template.Domain.User.ValueObjects;

public class Username
{
    public string Value { get; }

    public Username(string value)
    {
        if (value.Length is not (<= 100 and >= 3))
            throw new Exceptions.InvalidUsernameLengthException();
        Value = value;
    }
}