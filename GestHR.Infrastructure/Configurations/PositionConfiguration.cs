using GestHR.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestHR.Infrastructure.Configurations;

public class PositionConfiguration : IEntityTypeConfiguration<Position>
{
    public void Configure(EntityTypeBuilder<Position> builder)
    {
        builder.ToTable("Position");
        
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
        builder.Property(x=>x.Level).IsRequired().HasColumnType("varchar(50)");
        builder.Property(x =>x.BaseSalary).IsRequired().HasPrecision(18,2);
    }
}