namespace Antree_Ecommerce_BE.Domain.Abstractions.Dappers.Repositories;

public interface IRepositoryBase<T>
    where T : class
{
    Task<T?> GetByIdAsync(Guid id);

    Task<IReadOnlyList<T>> GetAllAsync();

    // Task<int> AddAsync(T entity);
    //
    // Task<int> UpdateAsync(T entity);
    //
    // Task<int> DeleteAsync(Guid id);
}
