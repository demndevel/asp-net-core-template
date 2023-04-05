using Template.Application.Interfaces;
using Template.Domain.User.ValueObjects;

namespace Template.Application.Services.User;

public class AddUserService : IAddUserService
{
    private readonly IAppDbContext _db;

    public AddUserService(IAppDbContext db)
    {
        _db = db;
    }

    public async Task<int> AddUser(AddUserDto dto)
    {
        var username = new Username(dto.Username);
        var password = new Password(dto.Password);
        var user = new Domain.User.User(
            password: password, 
            username: username);
        
        await _db.Users.AddAsync(user);
        await _db.SaveChangesAsync();

        return user.Id;
    }
}