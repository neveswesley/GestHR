using GestHR.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestHR.Infrastructure.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Position> Positiosn { get; set; }
    public DbSet<Payroll> Payrolls { get; set; }
    public DbSet<Vacations> Vacations { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Attendence> Attendences { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }
}