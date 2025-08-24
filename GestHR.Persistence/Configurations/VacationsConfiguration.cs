using GestHR.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestHR.Infrastructure.Configurations;

public class VacationsConfiguration : IEntityTypeConfiguration<Vacations>
{
    public void Configure(EntityTypeBuilder<Vacations> builder)
    {
        builder.ToTable("Vacations");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.EmployeeId).IsRequired();
        builder.Property(x => x.StartDate).HasColumnType("datetime").IsRequired();
        builder.Property(x => x.EndDate).HasColumnType("datetime").IsRequired();
        builder.Property(x=>x.Approved).IsRequired().HasColumnType("bit");
    }
}