using Template.Domain.User.ValueObjects;

namespace Template.Domain.User;

public class User
{
    public int Id { get; set; }
    public Username Username { get; }
    public Password Password { get; }

    public User(Password password, Username username)
    {
        Password = password;
        Username = username;
    }
}