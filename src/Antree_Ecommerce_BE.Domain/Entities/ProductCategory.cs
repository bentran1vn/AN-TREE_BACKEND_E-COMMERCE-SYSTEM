using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class ProductCategory : Entity<Guid>, IAuditableEntity, ICreatedByEntity<Guid>, IUpdatedByEnity<Guid?>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? UpdatedBy { get; set; }

    public ProductCategory(Guid id, string name, string description, Guid createdBy, Guid? updatedBy)
    {
        Id = id;
        Name = name;
        Description = description;
        CreatedBy = createdBy;
        UpdatedBy = updatedBy;
    }
    
    public static ProductCategory CreateProductCategory(Guid id, string name, string description, Guid createdBy, Guid? updatedBy)
    {
        // if (name.Length > 50)
        //     throw new ProductException.ProductFieldException(nameof(Name));

        var productCategory = new ProductCategory(id, name, description, createdBy, updatedBy);
        
        return productCategory;
    }
    
    public void UpdateProductCategory(string? name, string? description, Guid? updatedBy, bool? isDeleted)
    {
        // if (name.Length > 50)
        //     throw new ProductException.ProductFieldException(nameof(Name));
        if (name is not null) Name = name;
        if (description is not null ) Description = description;
        if (isDeleted != null ) IsDeleted = (bool)isDeleted;
        if (name is not null && description is not null && isDeleted is not null) UpdatedBy = updatedBy;
    }

    public virtual IReadOnlyCollection<Product> ProductList { get; set; } = default!;
}