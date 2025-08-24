using GestHR.Application.Services;
using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;

namespace GestHR.Application.Interfaces;

public class AttendenceService : BaseService<Attendence>, IAttendenceService
{
    public AttendenceService(IBaseRepository<Attendence> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}