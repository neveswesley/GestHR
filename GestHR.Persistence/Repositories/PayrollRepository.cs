using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;
using GestHR.Infrastructure.Context;

namespace GestHR.Infrastructure.Repositories;

public class PayrollRepository : BaseRepository<Payroll>, IPayrollRepository
{
    public PayrollRepository(AppDbContext context) : base(context)
    {
    }
}