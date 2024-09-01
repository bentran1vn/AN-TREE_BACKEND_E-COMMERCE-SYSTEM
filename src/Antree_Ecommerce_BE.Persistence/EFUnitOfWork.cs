using Antree_Ecommerce_BE.Domain.Abstractions;

namespace Antree_Ecommerce_BE.Persistence;

public class EFUnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;

    public EFUnitOfWork(ApplicationDbContext dbContext)
        => _dbContext = dbContext;
    
    public async void Dispose()
    {
        await _dbContext.DisposeAsync();
    }

    public async Task CommitAsync(CancellationToken cancellationToken = default)
    {
        await _dbContext.SaveChangesAsync();
    }
}