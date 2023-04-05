namespace Template.Application.Services.User;

public interface IAddUserService
{
    public Task<int> AddUser(AddUserDto dto);
}