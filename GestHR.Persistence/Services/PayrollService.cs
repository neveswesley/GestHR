using GestHR.Application.Services;
using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;

namespace GestHR.Application.Interfaces;

public class PayrollService : BaseService<Payroll>, IPayrollService
{
    public PayrollService(IBaseRepository<Payroll> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}