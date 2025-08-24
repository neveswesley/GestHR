using GestHR.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestHR.Infrastructure.Configurations;

public class AttendenceConfiguration : IEntityTypeConfiguration<Attendence>
{
    public void Configure(EntityTypeBuilder<Attendence> builder)
    {
        builder.ToTable("Attendence");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x=>x.EmployeeId).HasColumnType("int").IsRequired();
        builder.Property(x=>x.Date).HasColumnType("datetime").IsRequired();
        builder.Property(x=>x.CheckIn).HasColumnType("datetime").IsRequired();
        builder.Property(x=>x.CheckOut).HasColumnType("datetime").IsRequired();
        builder.Property(x=>x.Notes).HasColumnType("varchar(100)").IsRequired();
    }
}