namespace Template.Domain.User;

public static class Exceptions
{
    public abstract class UserException : Exception
    {
        protected UserException(string message) : base(message) { }
    }
    
    public abstract class PasswordException : UserException
    {
        protected PasswordException(string message) : base(message) { }
    }
    
    public abstract class UsernameException : UserException
    {
        protected UsernameException(string message) : base(message) { }
    }
    
    public class InvalidPasswordLengthException : PasswordException
    {
        public InvalidPasswordLengthException() : base("Password length must be between 8 and 100") { }
    }
    
    public class InvalidUsernameLengthException : PasswordException
    {
        public InvalidUsernameLengthException() : base("Username length must be between 3 and 100") { }
    }
}