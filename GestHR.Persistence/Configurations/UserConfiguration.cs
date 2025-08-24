using GestHR.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestHR.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x=>x.Username).IsRequired().HasColumnType("varchar(100)");
        builder.Property(x=>x.Email).IsRequired().HasColumnType("varchar(100)");
        builder.Property(x=>x.PasswordHash).IsRequired().HasColumnType("varchar(100)");
        builder.Property(x=>x.Role).IsRequired().HasColumnType("varchar(100)");
    }
}