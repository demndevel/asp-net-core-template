using Template.Application.Interfaces;

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
        var user = new Domain.User.User(dto.Username, dto.Password);
        
        await _db.Users.AddAsync(user);
        await _db.SaveChangesAsync();

        return user.Id;
    }
}