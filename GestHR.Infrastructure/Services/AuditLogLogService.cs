using GestHR.Application.Services;
using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;

namespace GestHR.Application.Interfaces;

public class AuditLogLogService : BaseService<AuditLog>, IAuditLogService
{
    public AuditLogLogService(IBaseRepository<AuditLog> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}