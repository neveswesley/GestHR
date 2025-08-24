using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;
using GestHR.Infrastructure.Context;

namespace GestHR.Infrastructure.Repositories;

public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
{
    private readonly AppDbContext context;

    public EmployeeRepository(AppDbContext context) : base(context)
    {
    }
}