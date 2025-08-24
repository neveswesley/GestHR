using GestHR.Application.Interfaces;
using GestHR.Application.Services;
using GestHR.Domain.Repositories;
using GestHR.Infrastructure.Context;
using GestHR.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GestHR.Infrastructure;

public static class ServicesExtensions
{
    public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(opt=> opt.UseSqlServer(configuration.GetConnectionString("sqlServer")));
        
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IEmployeeService, EmployeeServices>();
        
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
        
        services.AddScoped<IPositionRepository, PositionRepository>();
        services.AddScoped<IPositionService, PositionService>();
        
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<IDepartmentService, DepartmentService>();
        
        services.AddScoped<IAttendenceRepository, AttendenceRepository>();
        services.AddScoped<IAttendenceService, AttendenceService>();
        
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();
        
        services.AddScoped<IVacationsRepository, VacationRepository>();
        services.AddScoped<IVacationService, VacationService>();
        
        services.AddScoped<IPayrollRepository, PayrollRepository>();
        services.AddScoped<IPayrollService, PayrollService>();
        
        services.AddScoped<IAuditLogRepository, AuditLogRepository>();
        services.AddScoped<IAuditLogService, AuditLogLogService>();
        
    }
}