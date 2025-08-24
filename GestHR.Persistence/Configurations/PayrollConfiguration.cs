using GestHR.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestHR.Infrastructure.Configurations;

public class PayrollConfiguration : IEntityTypeConfiguration<Payroll>
{
    public void Configure(EntityTypeBuilder<Payroll> builder)
    {
        builder.ToTable("Payroll");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Month).HasColumnType("varchar(2)").IsRequired();
        builder.Property(x => x.Year).HasColumnType("varchar(2)").IsRequired();
        
        builder.Property(x=>x.GrossSalary).HasPrecision(18, 2);
        builder.Property(x=>x.Deductions).HasPrecision(18, 2);
        builder.Property(x=>x.Benefits).HasPrecision(18, 2);
        builder.Property(x=>x.NetSalary).HasPrecision(18, 2);
        builder.Property(x=>x.GenerateAt).HasColumnType("datetime").IsRequired();
    }
}