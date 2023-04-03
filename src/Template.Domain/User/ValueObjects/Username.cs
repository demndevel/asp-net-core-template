namespace Template.Domain.User.ValueObjects;

public class Username
{
    public string Value { get; }

    public Username(string value)
    {
        if (value.Length is <= 100 and >= 3)
        {
            Value = value;
        }

        throw new Exceptions.InvalidUsernameLengthException();
    }
}