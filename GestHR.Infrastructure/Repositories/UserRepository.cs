using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;
using GestHR.Infrastructure.Context;

namespace GestHR.Infrastructure.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}