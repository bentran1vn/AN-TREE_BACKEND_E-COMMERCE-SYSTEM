namespace Antree_Ecommerce_BE.Domain.Abstractions;

public interface IUnitOfWork : IDisposable
{
    Task CommitAsync(CancellationToken cancellationToken = default);
}