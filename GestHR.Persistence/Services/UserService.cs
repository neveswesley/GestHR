using GestHR.Application.Services;
using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;

namespace GestHR.Application.Interfaces;

public class UserService : BaseService<User>, IUserService
{
    public UserService(IBaseRepository<User> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}