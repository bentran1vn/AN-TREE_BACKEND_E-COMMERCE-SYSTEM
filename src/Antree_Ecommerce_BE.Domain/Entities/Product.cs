using System.Collections;
using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class Product : Entity<Guid>, IAuditableEntity, ICreatedByEntity<Guid>, IUpdatedByEnity<Guid?>
{
    public Product(string name, decimal price, string description, int sku, int sold)
    {
        Name = name;
        Price = price;
        Description = description;
        Sku = sku;
        Sold = sold;
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

    public virtual ProductCategory ProductCategory { get; set; }
    public virtual IReadOnlyCollection<OrderDetail> OrderDetailList { get; set; } = default!;
    public virtual IReadOnlyCollection<ProductDiscount> ProductDiscountList { get; set; } = default!;
    public virtual IReadOnlyCollection<ProductFeedback> ProductFeedbackList { get; set; } = default!;
}