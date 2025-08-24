using GestHR.Application.Services;
using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;
using GestHR.Infrastructure.Context;

namespace GestHR.Infrastructure.Repositories;

public class VacationRepository : BaseRepository<Vacations>, IVacationsRepository
{
    public VacationRepository(AppDbContext context) : base(context)
    {
    }
}