using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;
using GestHR.Infrastructure.Context;

namespace GestHR.Infrastructure.Repositories;

public class AuditLogRepository : BaseRepository<AuditLog>, IAuditLogRepository
{
    public AuditLogRepository(AppDbContext context) : base(context)
    {
    }
}