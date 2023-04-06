using Microsoft.EntityFrameworkCore;
using Template.Application.Persistence;

namespace Template.UnitTests;

public class TestDbContext : IDisposable
{
    public readonly AppDbContext DbContext;
    private readonly string _dbFileName;

    private TestDbContext(AppDbContext dbContext, string dbFileName)
    {
        DbContext = dbContext;
        _dbFileName = dbFileName;
    }

    public static TestDbContext Create()
    {
        var dbFileName = Guid.NewGuid().ToString();
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlite($"Data Source={dbFileName}.db")
            .Options;

        var context = new AppDbContext(options);

        context.Database.EnsureCreated();
        
        context.SaveChanges();

        return new TestDbContext(context, dbFileName);
    }

    public void Dispose()
    {
        DbContext.Database.EnsureDeleted();
    }
}