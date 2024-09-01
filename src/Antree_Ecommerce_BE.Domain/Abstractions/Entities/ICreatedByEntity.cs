namespace Antree_Ecommerce_BE.Domain.Abstractions.Entities;

public interface ICreatedByEntity<T> 
{
    T CreatedBy { get; set; }
    
}