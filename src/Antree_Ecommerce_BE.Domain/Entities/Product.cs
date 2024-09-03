using System.Collections;
using Antree_Ecommerce_BE.Domain.Abstractions.Entities;
using Antree_Ecommerce_BE.Domain.Exceptions;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class Product : Entity<Guid>, IAuditableEntity, ICreatedByEntity<Guid>, IUpdatedByEnity<Guid?>
{
    public Product(Guid id, Guid productCategoryId, string name, decimal price, string description, int sku, int sold, Guid createdBy, Guid? updatedBy)
    {
        Id = id;
        ProductCategoryId = productCategoryId;
        Name = name;
        Price = price;
        Description = description;
        Sku = sku;
        Sold = sold;
        CreatedBy = createdBy;
        UpdatedBy = updatedBy;
    }

    public static Product CreateProduct(Guid id, Guid productCategoryId, string name, decimal price, string description, int sku, int sold, Guid createdBy, Guid? updatedBy)
    {
        if (name.Length > 50)
            throw new ProductException.ProductFieldException(nameof(Name));

        var product = new Product(id, productCategoryId, name, price, description, sku, sold, createdBy, updatedBy);
        
        return product;
    }
    
    public void Update(Guid productCategoryId, string name, decimal price, string description, int sku, int sold, Guid updatedBy)
    {
        if (name.Length > 50)
            throw new ProductException.ProductFieldException(nameof(Name));

        ProductCategoryId = productCategoryId;
        Name = name;
        Price = price;
        Description = description;
        Sku = sku;
        Sold = sold;
        UpdatedBy = updatedBy;
    }

    public Guid ProductCategoryId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int Sku { get; set; }
    public int Sold { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? UpdatedBy { get; set; }

    public virtual ProductCategory ProductCategory { get; set; } = default!;
    public virtual IReadOnlyCollection<OrderDetail> OrderDetailList { get; set; } = default!;
    public virtual IReadOnlyCollection<ProductDiscount> ProductDiscountList { get; set; } = default!;
    public virtual IReadOnlyCollection<ProductFeedback> ProductFeedbackList { get; set; } = default!;
}