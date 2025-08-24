using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;
using GestHR.Infrastructure.Context;

namespace GestHR.Infrastructure.Repositories;

public class AttendenceRepository : BaseRepository<Attendence>, IAttendenceRepository
{
    public AttendenceRepository(AppDbContext context) : base(context)
    {
    }
}