using GestHR.Application.Services;
using GestHR.Domain.Entities;
using GestHR.Domain.Exceptions;
using GestHR.Domain.Repositories;
using GestHR.Infrastructure.Context;
using GestHR.Infrastructure.Repositories;

namespace GestHR.Application.Interfaces;

public class BaseService<T> : IBaseService<T> where T : BaseEntity
{

    private readonly IBaseRepository<T> _repository;
    private readonly IUnitOfWork _unitOfWork;

    public BaseService(IBaseRepository<T> repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(entity);
        return entity;
    }

    public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(id, cancellationToken);
        return entity;
    }

    public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken)
    {
        var entities = await _repository.GetAllAsync(cancellationToken);
        return entities;
    }

    public async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken)
    {
        await _repository.UpdateAsync(entity);
        return entity;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(id, cancellationToken);
        if (entity != null)
            throw new DomainExceptions("");
        
        await _repository.DeleteAsync(entity);
    }
}