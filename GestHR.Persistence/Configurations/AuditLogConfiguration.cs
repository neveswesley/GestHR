using GestHR.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestHR.Infrastructure.Configurations;

public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
{
    public void Configure(EntityTypeBuilder<AuditLog> builder)
    {
        builder.ToTable("AuditLogs");
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        
        builder.Property(x=>x.UserId).HasColumnType("varchar(100)").IsRequired();
        builder.Property(x=>x.Action).HasColumnType("varchar(100)").IsRequired();
        builder.Property(x=>x.Timestamp).HasColumnType("datetime").IsRequired();
        builder.Property(x=>x.Details).HasColumnType("varchar(1000)").IsRequired();
    }
}