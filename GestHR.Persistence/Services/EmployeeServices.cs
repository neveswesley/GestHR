using GestHR.Application.Services;
using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;

namespace GestHR.Application.Interfaces;

public class EmployeeServices : BaseService<Employee>, IEmployeeService
{
    public EmployeeServices(IBaseRepository<Employee> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}