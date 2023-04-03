using Microsoft.EntityFrameworkCore;
using Template.Domain.User;

namespace Template.Application.Interfaces;

public interface IAppDbContext
{
    public DbSet<User> Users { get; set; }
    public Task<int> SaveChangesAsync(CancellationToken ct = default);
}