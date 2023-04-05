using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Template.Application.Interfaces;
using Template.Domain.User;

namespace Template.Infrastructure.Persistence;

public class AppDbContext : DbContext, IAppDbContext
{
    public DbSet<User> Users { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}