using System.ComponentModel.DataAnnotations.Schema;

namespace Antree_Ecommerce_BE.Domain.Abstractions.Entities;

public abstract class Entity<T> : IEntity<T>
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public T Id { get; set; }

    public bool IsDeleted { get; set; }
}
