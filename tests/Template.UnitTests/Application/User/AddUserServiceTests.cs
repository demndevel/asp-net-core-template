using Microsoft.EntityFrameworkCore;
using Template.Application.Services.User;

namespace Template.UnitTests.Application.User;

public class AddUserServiceTests
{
    [Fact]
    public async Task AddUser_Success()
    {
        using var testDb = TestDbContext.Create();
        var service = new AddUserService(testDb.DbContext);
        const string testUsername = "someTestUsername";
        const string testPassword = "someTestPassword";
        var testDto = new AddUserDto
        {
            Username = testUsername,
            Password = testPassword
        };
            
        var result = await service.AddUser(testDto);

        var user = await testDb.DbContext.Users
            .FirstOrDefaultAsync(u => u.Id == result);
            
        Assert.NotNull(user);
        Assert.Equal(testUsername, user.Username.Value);
        Assert.Equal(testPassword, user.Password.Value);
    }
}