using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;
using GestHR.Infrastructure.Context;

namespace GestHR.Infrastructure.Repositories;

public class PositionRepository : BaseRepository<Position>, IPositionRepository
{
    public PositionRepository(AppDbContext context) : base(context)
    {
    }
}