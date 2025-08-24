using GestHR.Application.Services;
using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;

namespace GestHR.Application.Interfaces;

public class VacationService : BaseService<Vacations>, IVacationService
{
    public VacationService(IBaseRepository<Vacations> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}