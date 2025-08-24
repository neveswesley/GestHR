using GestHR.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestHR.Infrastructure.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        
        builder.Property(x=>x.FullName).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
        builder.Property(x => x.CPF).IsRequired().HasMaxLength(20).HasColumnType("varchar(20)");
        builder.Property(x=>x.CorporateEmail).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
        builder.Property(x => x.HireDate).IsRequired().HasColumnType("datetime2");
        builder.Property(x => x.DepartmentId).IsRequired();
        builder.Property(x=>x.UserId).IsRequired();
        builder.Property(x => x.BaseSalary).IsRequired().HasPrecision(1800,2);
    }
}