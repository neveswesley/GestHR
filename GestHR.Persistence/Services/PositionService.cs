using GestHR.Application.Services;
using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;

namespace GestHR.Application.Interfaces;

public class PositionService : BaseService<Position>, IPositionService
{
    public PositionService(IBaseRepository<Position> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}