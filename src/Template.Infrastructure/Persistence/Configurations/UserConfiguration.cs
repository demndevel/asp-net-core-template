using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain.User;
using Template.Domain.User.ValueObjects;

namespace Template.Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
        
        builder.Property(u => u.Username)
            .HasConversion(u => u.Value, value => new Username(value));
        
        builder.Property(u => u.Password)
            .HasConversion(u => u.Value, value => new Password(value));
    }
}