using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class Product : Entity<Guid>, IAuditableEntity, ICreatedByEntity<Guid>, IUpdatedByEnity<Guid?>
{
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

    public IReadOnlyCollection<OrderDetail> OrderDetailList { get; set; } = default!;
    public IReadOnlyCollection<ProductDiscount> ProductDiscountList { get; set; } = default!;
    public IReadOnlyCollection<ProductFeedback> ProductFeedbackList { get; set; } = default!;
}