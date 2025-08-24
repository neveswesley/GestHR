using GestHR.Domain.Entities;
using GestHR.Domain.Repositories;
using GestHR.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace GestHR.Infrastructure.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<T> CreateAsync(T entity)
    {
        entity.DateCreated = DateTime.UtcNow;
        await _context.AddAsync(entity);
        return entity;
    }

    public Task<T> UpdateAsync(T entity)
    {
        entity.DateUpdated = DateTime.UtcNow;
        _context.Set<T>().Remove(entity);
        return Task.FromResult(entity);
    }

    public Task DeleteAsync(T entity)
    {
        entity.DateDeleted = DateTime.UtcNow;
        _context.Set<T>().Update(entity);
        return Task.CompletedTask;
    }

    public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
    }

    public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _context.Set<T>().AsNoTracking().ToListAsync(cancellationToken);
    }
}