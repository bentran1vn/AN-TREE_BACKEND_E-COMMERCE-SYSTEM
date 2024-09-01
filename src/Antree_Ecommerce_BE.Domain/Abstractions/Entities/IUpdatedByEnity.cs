namespace Antree_Ecommerce_BE.Domain.Abstractions.Entities;

public interface IUpdatedByEnity<T>
{
    T UpdatedBy { get; set; }
}