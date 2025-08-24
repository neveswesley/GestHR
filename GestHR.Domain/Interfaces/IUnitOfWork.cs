namespace GestHR.Domain.Repositories;

public interface IUnitOfWork
{
    Task Commit(CancellationToken cancellationToken);
}